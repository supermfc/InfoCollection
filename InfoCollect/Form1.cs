using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using NPOI;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using NPOI.HSSF.UserModel;
using System.Runtime.InteropServices;

namespace InfoCollect
{
    public partial class Form1 : Form
    {

        //Excel文件中列索引常量
        const int SAVESN = 0;
        const int SHEQUNAME = 1;
        const int LOUYUANNAME = 2;
        const int NAME = 3;
        const int SEX = 4;
        const int SHENFENID = 5;
        const int BRITHDAY = 6;
        const int NATION = 7;
        const int SHENFENADDRESS = 8;
        const int NOWADDRESS = 9;
        const int FENLIREASON = 10;
        const int GUOJI = 11;
        const int GUDINGPHONE = 12;
        const int PHONE1 = 13;
        const int PHONE2 = 14;
        const int WORKDEPARTMENT = 15;
        const int SHENGAO = 16;
        const int XUEXING = 17;
        const int TECHANG = 18;
        const int LIVETYPE = 19;
        const int ISHUZHU = 20;
        const int HUZHURELATION = 21;
        const int NOCARNUMBER = 22;
        const int NOCARDETAIL = 23;
        const int CARNUM = 24;        //拥有机动车数量
        const int CARPAN = 25;      //车辆品牌
        const int CARNUMBER = 26;   //车牌号码
        const int CARCOLOR = 27;    //车辆颜色
        const int CARTYPE = 28;     //车型
               
        const int MAGICSN = 36;


        private FilterInfoCollection videoDevices;//所有摄像设备
        private VideoCaptureDevice videoDevice;//摄像设备
        private VideoCapabilities[] videoCapabilities;//摄像头分辨率

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            initEnv();

            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);//得到机器所有接入的摄像设备
            if (videoDevices.Count != 0)
            {
                foreach (FilterInfo device in videoDevices)
                {
                    cboVideo.Items.Add(device.Name);//把摄像设备添加到摄像列表中
                }
            }
            else
            {
                cboVideo.Items.Add("没有找到摄像头");
            }
            cboVideo.SelectedIndex = 0;//默认选择第一个
        }

        //初始化环境信息，如果不存在今天的目录，那么创建，并且将模板excel文件拷贝进去
        private void initEnv()
        {
            
            string dayDataPath = getDataPath();

            if (!Directory.Exists(dayDataPath))
            {
                Directory.CreateDirectory(dayDataPath);
                File.Copy("template.xls", dayDataPath + Path.DirectorySeparatorChar + "result.xls");

                //用于保存图片的目录
                Directory.CreateDirectory(dayDataPath + Path.DirectorySeparatorChar.ToString() + "image");
            }

            if (Base.Options.ContainsKey("severInfo") && Base.Options["severInfo"].Split(':').Length == 2)
            {
                string[] serverStr = Base.Options["severInfo"].Split(':');
                Base.setTheServer(serverStr[0], int.Parse(serverStr[1]), "125.94.214.121", 6000);
            }
            else
            {
                Base.setTheServer("59.41.39.51", 6000, "125.94.214.121", 6000);
            }
        }

        private string getDataPath()
        {
            string dayPath = DateTime.Now.ToString("yyyy-MM-dd");
            string dayDataPath = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory)
                        + Path.DirectorySeparatorChar.ToString() + "data" + Path.DirectorySeparatorChar.ToString() + dayPath;

            return dayDataPath;
        }

        private void cboVideo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (videoDevices.Count != 0)
            {
                //获取摄像头
                videoDevice = new VideoCaptureDevice(videoDevices[cboVideo.SelectedIndex].MonikerString);
                GetDeviceResolution(videoDevice);//获得摄像头的分辨率
            }
        }
        //获得摄像头的分辨率
        private void GetDeviceResolution(VideoCaptureDevice videoCaptureDevice)
        {
            cboResolution.Items.Clear();//清空列表
            videoCapabilities = videoCaptureDevice.VideoCapabilities;//设备的摄像头分辨率数组
            foreach (VideoCapabilities capabilty in videoCapabilities)
            {
                //把这个设备的所有分辨率添加到列表
                cboResolution.Items.Add($"{capabilty.FrameSize.Width} x {capabilty.FrameSize.Height}");
            }
            cboResolution.SelectedIndex = cboResolution.Items.Count - 1; //默认选择最后一个，最清楚的。
            
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (videoDevice != null)//如果摄像头不为空
            {
                if ((videoCapabilities != null) && (videoCapabilities.Length != 0))
                {
                    videoDevice.VideoResolution = videoCapabilities[cboResolution.SelectedIndex];//摄像头分辨率
                    vispShoot.VideoSource = videoDevice;//把摄像头赋给控件
                    vispShoot.Start();//开启摄像头
                    EnableControlStatus(false);
                }
            }
        }
        //控件的显示切换
        private void EnableControlStatus(bool status)
        {
            cboVideo.Enabled = status;
            cboResolution.Enabled = status;
            btnConnect.Enabled = status;
            btnPic.Enabled = !status;
            btnCut.Enabled = !status;
        }

        private void btnCut_Click(object sender, EventArgs e)
        {
            DisConnect();//断开连接
            EnableControlStatus(true);
        }

        private void btnPic_Click(object sender, EventArgs e)
        {
            Bitmap img = vispShoot.GetCurrentVideoFrame();//拍照
           
            //这里可以根据情况，把照片存到某个路径下
            //img.Save("");
            if (tBName.Text.Trim() == "" || !IDCheck.CheckIDCard(tBShenFenID.Text.Trim()))
            {
                MessageBox.Show("未录入姓名或者身份证格式不正常！请核对后重新拍照！");
                return;
            }
            else
            {
                img.Save(getDataPath() + Path.DirectorySeparatorChar.ToString() + "image" + Path.DirectorySeparatorChar.ToString() + tBShenFenID.Text.Trim() + ".jpg" , System.Drawing.Imaging.ImageFormat.Jpeg);
                img.Save(getDataPath() + Path.DirectorySeparatorChar.ToString() + "image" + Path.DirectorySeparatorChar.ToString() + tBName.Text.Trim() + tBShenFenID.Text.Trim() + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

            }
            picbPreview.Image = img;
        }
        //关闭并释放
        private void DisConnect()
        {
            if (vispShoot.VideoSource != null)
            {
                vispShoot.SignalToStop();
                vispShoot.WaitForStop();
                vispShoot.VideoSource = null;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DisConnect();//关闭并释放
        }

        private void bReadID_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("身份证厂家特别垃圾，还没有提供阅读器SDK，该功能稍等！");
            Base.IDInfo idInfo = new Base.IDInfo();

            string resultMsg = Base.getRspMsg(Base.readCard(ref idInfo, 15));

            if (resultMsg.IndexOf("读取成功") == -1)
                MessageBox.Show(resultMsg);

            //if (Base.getRspMsg(Base.readCard(ref idInfo,15)).IndexOf("读取成功") != -1)

            //MessageBox.Show(Base.getRspMsg(Base.readCard(ref idInfo, 15)));
            //readCard(ref idInfo, 15);
            tBName.Text = idInfo.name;
            cBSex.Text = idInfo.sex;
            tBNation.Text = IDCheck.getNational(idInfo.ethnicity);
            tBShenFenID.Text = idInfo.cardNo;
            tBIDAddress.Text = idInfo.address;

        }


        private void bSave_Click(object sender, EventArgs e)
        {
            string filename = getDataPath() + Path.DirectorySeparatorChar.ToString() + "result.xls";
            if (File.Exists(filename))
            {
                try
                {
                    HSSFWorkbook wk = null;
                    using (FileStream fs = File.Open(filename, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    {
                        wk = new HSSFWorkbook(fs);
                        fs.Close();
                    }
                    //获取第一个工作薄
                    ISheet sheet = wk.GetSheetAt(0);
                    IRow row = sheet.GetRow(0);
                    if (row != null)
                    {
                        //魔术糖，用于保存当前序号
                        ICell cellsn = row.GetCell(MAGICSN);

                        int saveSN = Convert.ToInt32(cellsn.ToString());

                        if (CheckInfo())
                        {
                            //如果保存信息成功
                            if (SaveInfo(sheet, saveSN))
                            {


                                cellsn.SetCellValue((saveSN + 1).ToString());  //序号增加一

                                using (FileStream fs = File.OpenWrite(filename))
                                {
                                    wk.Write(fs);
                                }

                                lSavedIndex.Text = saveSN.ToString();
                                clearInfo();
                            }
                        }



                    }
                }

                catch(Exception ex)
                {
                    MessageBox.Show("产生异常：" + ex.Message + "，请拍照后和丁冰联系!");
                }
            }
            else
            {
                MessageBox.Show("结果文件丢失!");
            }
        }

        private void clearInfo()
        {
            //tBNowLiveArea.Text = "";
            tBCarNum.Text = "";
            tBWorkDepartment.Text = "";

            tBName.Text = "";
            cBSex.SelectedIndex = -1;
            tBNation.Text = "";
            tBShenFenID.Text = "";
            tBIDAddress.Text = "";

            tBCar.Text = "";
            tBCarNumber.Text = "豫H";
            cBCarColor.SelectedIndex = -1;
            cBCarType.SelectedIndex = -1;
            //tBNowLiveArea.Focus();
            tBLouNumber.Text = "";
            tBDanYuan.Text = "";
            tBRoom.Text = "";
            tBLouNumber.Focus();

            tBRenHuReason.Text = "";
            tBGuDingPhone.Text = "";
            tBPhone1.Text = "";
            tBPhone2.Text = "";
            tBShenGao.Text = "";
            cBXueXing.SelectedIndex = -1;
            tBTeChang.Text = "";
            cBLiveType.SelectedIndex = -1;
            tBHuZhuRelation.Text = "";
            tBNoCarNumber.Text = "";
            tBNoCarDetail.Text = "";
            
        }
        private bool CheckInfo()
        {
            if(tBSheQuName.Text.Trim() == "" || tBLouYuanName.Text.Trim() == "")
            {
                MessageBox.Show("请检查社区名称和楼院名称!");
                return false;
            }

            if(tBName.Text.Trim() == "" ||  !IDCheck.CheckIDCard(tBShenFenID.Text.Trim()))
            {
                MessageBox.Show("请检查名字或者身份证号码非法！");
                return false;

            }

            
            return true;
        }

        private bool SaveInfo(ISheet sheet,int sn)
        {
            IRow row = sheet.CreateRow(sn);

            ICell cellsn = row.CreateCell(SAVESN);
            cellsn.SetCellValue(sn);

            //return true;
            //社区名称和楼院名称
            ICell cellSheQuName = row.CreateCell(SHEQUNAME);
            cellSheQuName.SetCellValue(tBSheQuName.Text.Trim());

            ICell cellLouYuanName = row.CreateCell(LOUYUANNAME);
            cellLouYuanName.SetCellValue(tBLouYuanName.Text.Trim());


            //身份证信息区
            ICell cellname = row.CreateCell(NAME);
            cellname.SetCellValue(tBName.Text.Trim());

            ICell cellSex = row.CreateCell(SEX);
            cellSex.SetCellValue(cBSex.Text.Trim());

            ICell cellShenFenID = row.CreateCell(SHENFENID);
            cellShenFenID.SetCellValue(tBShenFenID.Text.Trim());

            ICell cellBirthday = row.CreateCell(BRITHDAY);
            cellBirthday.SetCellValue(tBShenFenID.Text.Trim().Substring(6, 8).Insert(6, "-").Insert(4, "-"));

            ICell cellNation = row.CreateCell(NATION);
            cellNation.SetCellValue(tBNation.Text.Trim());

            ICell cellShenFenIDAddress = row.CreateCell(SHENFENADDRESS);
            cellShenFenIDAddress.SetCellValue(tBIDAddress.Text.Trim());

            //其它信息区
            ICell cellNowLiveAddress = row.CreateCell(NOWADDRESS);
            string nowLive = tBNowLiveArea.Text.Trim() + tBLouNumber.Text.Trim() + "号楼" + tBDanYuan.Text.Trim() + "单元" + tBRoom.Text.Trim() + "室";
            //cellNowLiveAddress.SetCellValue(tBNowLiveArea.Text.Trim());
            cellNowLiveAddress.SetCellValue(nowLive);

            ICell cellRenHuReason = row.CreateCell(FENLIREASON);
            cellRenHuReason.SetCellValue(tBRenHuReason.Text.Trim());

            ICell cellGuoJi = row.CreateCell(GUOJI);
            cellGuoJi.SetCellValue(tBGuoJi.Text.Trim());

            ICell cellGuDingPhone = row.CreateCell(GUDINGPHONE);
            cellGuDingPhone.SetCellValue(tBGuDingPhone.Text.Trim());

            ICell cellPhone1 = row.CreateCell(PHONE1);
            cellPhone1.SetCellValue(tBPhone1.Text.Trim());

            ICell cellPhone2 = row.CreateCell(PHONE2);
            cellPhone2.SetCellValue(tBPhone2.Text.Trim());

            //ICell cellPhone = row.CreateCell(PHONE);
            //cellPhone.SetCellValue(tBCarNum.Text.Trim());


            //详细工作单位
            ICell cellWorkDepartment = row.CreateCell(WORKDEPARTMENT);
            cellWorkDepartment.SetCellValue(tBWorkDepartment.Text.Trim());


            ICell cellShenGao = row.CreateCell(SHENGAO);
            cellShenGao.SetCellValue(tBShenGao.Text.Trim());

            ICell cellXueXing = row.CreateCell(XUEXING);
            cellXueXing.SetCellValue(cBXueXing.Text.Trim());

            ICell cellTeChang = row.CreateCell(TECHANG);
            cellTeChang.SetCellValue(tBTeChang.Text.Trim());

            ICell cellLiveType = row.CreateCell(LIVETYPE);
            cellLiveType.SetCellValue(cBLiveType.Text.Trim());

            ICell cellIsHuZhu = row.CreateCell(ISHUZHU);
            if (cBHuZhu.Checked)
                cellIsHuZhu.SetCellValue("是");
            else
                cellIsHuZhu.SetCellValue("否");

            ICell cellHuZhuRelation = row.CreateCell(HUZHURELATION);
            //如果不是户主，需要记录和户主关系
            if (!cBHuZhu.Checked)
                cellHuZhuRelation.SetCellValue(tBHuZhuRelation.Text.Trim());

            ICell cellNoCarNumber = row.CreateCell(NOCARNUMBER);
            cellNoCarNumber.SetCellValue(tBNoCarNumber.Text.Trim());

            ICell cellNoCarDetail = row.CreateCell(NOCARDETAIL);
            cellNoCarDetail.SetCellValue(tBNoCarDetail.Text.Trim());

            ICell cellCarNum = row.CreateCell(CARNUM);
            cellCarNum.SetCellValue(tBCarNum.Text.Trim());

            //如果车牌不等于豫H，则视为有车
            if(tBCarNumber.Text.Trim() != "豫H" || tBCarNumber.Text.Trim() != "")
            {
                ICell cellCarPan = row.CreateCell(CARPAN);
                cellCarPan.SetCellValue(tBCar.Text.Trim());

                ICell cellCarNumber = row.CreateCell(CARNUMBER);
                cellCarNumber.SetCellValue(tBCarNumber.Text.Trim());

                ICell cellCarColor = row.CreateCell(CARCOLOR);
                cellCarColor.SetCellValue(cBCarColor.Text.Trim());

                ICell cellCarType = row.CreateCell(CARTYPE);
                cellCarType.SetCellValue(cBCarType.Text.Trim());
            }
            
            return true;
        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void cBHuZhu_CheckedChanged(object sender, EventArgs e)
        {
            if (cBHuZhu.Checked)
                tBHuZhuRelation.Enabled = false;
            else
                tBHuZhuRelation.Enabled = true;
        }
    }
}
