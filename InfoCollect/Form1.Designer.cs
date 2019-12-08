namespace InfoCollect
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.cboVideo = new System.Windows.Forms.ComboBox();
            this.cboResolution = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnCut = new System.Windows.Forms.Button();
            this.btnPic = new System.Windows.Forms.Button();
            this.vispShoot = new AForge.Controls.VideoSourcePlayer();
            this.picbPreview = new AForge.Controls.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cBCarType = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cBCarColor = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tBCarNumber = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tBCar = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tBNoCarDetail = new System.Windows.Forms.TextBox();
            this.tBNoCarNumber = new System.Windows.Forms.TextBox();
            this.tBHuZhuRelation = new System.Windows.Forms.TextBox();
            this.cBHuZhu = new System.Windows.Forms.CheckBox();
            this.cBLiveType = new System.Windows.Forms.ComboBox();
            this.tBTeChang = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.cBXueXing = new System.Windows.Forms.ComboBox();
            this.label30 = new System.Windows.Forms.Label();
            this.tBShenGao = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.tBPhone2 = new System.Windows.Forms.TextBox();
            this.tBPhone1 = new System.Windows.Forms.TextBox();
            this.tBGuDingPhone = new System.Windows.Forms.TextBox();
            this.tBGuoJi = new System.Windows.Forms.TextBox();
            this.tBRenHuReason = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.tBRoom = new System.Windows.Forms.TextBox();
            this.tBDanYuan = new System.Windows.Forms.TextBox();
            this.tBLouNumber = new System.Windows.Forms.TextBox();
            this.tBWorkDepartment = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tBCarNum = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tBNowLiveArea = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tBIDAddress = new System.Windows.Forms.TextBox();
            this.tBNation = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tBShenFenID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cBSex = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tBName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tBLouYuanName = new System.Windows.Forms.TextBox();
            this.tBSheQuName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bSave = new System.Windows.Forms.Button();
            this.bReadID = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.lSavedIndex = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picbPreview)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboVideo
            // 
            this.cboVideo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVideo.FormattingEnabled = true;
            this.cboVideo.Location = new System.Drawing.Point(624, 12);
            this.cboVideo.Name = "cboVideo";
            this.cboVideo.Size = new System.Drawing.Size(140, 20);
            this.cboVideo.TabIndex = 6;
            this.cboVideo.SelectedIndexChanged += new System.EventHandler(this.cboVideo_SelectedIndexChanged);
            // 
            // cboResolution
            // 
            this.cboResolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboResolution.FormattingEnabled = true;
            this.cboResolution.Location = new System.Drawing.Point(822, 12);
            this.cboResolution.Name = "cboResolution";
            this.cboResolution.Size = new System.Drawing.Size(131, 20);
            this.cboResolution.TabIndex = 7;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(987, 11);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(46, 23);
            this.btnConnect.TabIndex = 8;
            this.btnConnect.Text = "连接";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnCut
            // 
            this.btnCut.Location = new System.Drawing.Point(1055, 11);
            this.btnCut.Name = "btnCut";
            this.btnCut.Size = new System.Drawing.Size(46, 23);
            this.btnCut.TabIndex = 9;
            this.btnCut.Text = "断开";
            this.btnCut.UseVisualStyleBackColor = true;
            this.btnCut.Click += new System.EventHandler(this.btnCut_Click);
            // 
            // btnPic
            // 
            this.btnPic.Enabled = false;
            this.btnPic.Location = new System.Drawing.Point(714, 634);
            this.btnPic.Name = "btnPic";
            this.btnPic.Size = new System.Drawing.Size(78, 37);
            this.btnPic.TabIndex = 4;
            this.btnPic.Text = "拍照";
            this.btnPic.UseVisualStyleBackColor = true;
            this.btnPic.Click += new System.EventHandler(this.btnPic_Click);
            // 
            // vispShoot
            // 
            this.vispShoot.Location = new System.Drawing.Point(568, 43);
            this.vispShoot.Name = "vispShoot";
            this.vispShoot.Size = new System.Drawing.Size(763, 579);
            this.vispShoot.TabIndex = 3;
            this.vispShoot.Text = "videoSourcePlayer1";
            this.vispShoot.VideoSource = null;
            // 
            // picbPreview
            // 
            this.picbPreview.Image = null;
            this.picbPreview.Location = new System.Drawing.Point(1210, 634);
            this.picbPreview.Name = "picbPreview";
            this.picbPreview.Size = new System.Drawing.Size(121, 76);
            this.picbPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbPreview.TabIndex = 4;
            this.picbPreview.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(569, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "摄像头：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(779, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "像素：";
            // 
            // cBCarType
            // 
            this.cBCarType.FormattingEnabled = true;
            this.cBCarType.Items.AddRange(new object[] {
            "小客车",
            "面包车",
            "小型轿车",
            "皮卡",
            "大货车",
            "房车",
            "小货车"});
            this.cBCarType.Location = new System.Drawing.Point(314, 386);
            this.cBCarType.Name = "cBCarType";
            this.cBCarType.Size = new System.Drawing.Size(169, 20);
            this.cBCarType.TabIndex = 22;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(267, 389);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 12);
            this.label16.TabIndex = 6;
            this.label16.Text = "车型：";
            // 
            // cBCarColor
            // 
            this.cBCarColor.FormattingEnabled = true;
            this.cBCarColor.Items.AddRange(new object[] {
            "白色",
            "红色",
            "黑色",
            "棕色",
            "香槟色",
            "绿色",
            "黄色",
            "蓝色",
            "灰色"});
            this.cBCarColor.Location = new System.Drawing.Point(100, 386);
            this.cBCarColor.Name = "cBCarColor";
            this.cBCarColor.Size = new System.Drawing.Size(135, 20);
            this.cBCarColor.TabIndex = 21;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(30, 386);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 12);
            this.label15.TabIndex = 4;
            this.label15.Text = "车辆颜色：";
            // 
            // tBCarNumber
            // 
            this.tBCarNumber.Location = new System.Drawing.Point(314, 355);
            this.tBCarNumber.Name = "tBCarNumber";
            this.tBCarNumber.Size = new System.Drawing.Size(167, 21);
            this.tBCarNumber.TabIndex = 20;
            this.tBCarNumber.Text = "豫H";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(243, 358);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 12);
            this.label14.TabIndex = 2;
            this.label14.Text = "车牌号码：";
            // 
            // tBCar
            // 
            this.tBCar.Location = new System.Drawing.Point(100, 351);
            this.tBCar.Name = "tBCar";
            this.tBCar.Size = new System.Drawing.Size(135, 21);
            this.tBCar.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(30, 352);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 0;
            this.label13.Text = "车辆品牌：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tBNoCarDetail);
            this.groupBox2.Controls.Add(this.tBNoCarNumber);
            this.groupBox2.Controls.Add(this.tBHuZhuRelation);
            this.groupBox2.Controls.Add(this.cBHuZhu);
            this.groupBox2.Controls.Add(this.cBLiveType);
            this.groupBox2.Controls.Add(this.tBTeChang);
            this.groupBox2.Controls.Add(this.label31);
            this.groupBox2.Controls.Add(this.cBXueXing);
            this.groupBox2.Controls.Add(this.label30);
            this.groupBox2.Controls.Add(this.tBShenGao);
            this.groupBox2.Controls.Add(this.label29);
            this.groupBox2.Controls.Add(this.tBPhone2);
            this.groupBox2.Controls.Add(this.tBPhone1);
            this.groupBox2.Controls.Add(this.tBGuDingPhone);
            this.groupBox2.Controls.Add(this.tBGuoJi);
            this.groupBox2.Controls.Add(this.tBRenHuReason);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.tBRoom);
            this.groupBox2.Controls.Add(this.tBDanYuan);
            this.groupBox2.Controls.Add(this.tBLouNumber);
            this.groupBox2.Controls.Add(this.cBCarType);
            this.groupBox2.Controls.Add(this.tBWorkDepartment);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.cBCarColor);
            this.groupBox2.Controls.Add(this.tBCarNum);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.label27);
            this.groupBox2.Controls.Add(this.label28);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.tBCarNumber);
            this.groupBox2.Controls.Add(this.tBNowLiveArea);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.tBCar);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label33);
            this.groupBox2.Controls.Add(this.label35);
            this.groupBox2.Controls.Add(this.label36);
            this.groupBox2.Controls.Add(this.label34);
            this.groupBox2.Controls.Add(this.label32);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(12, 295);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(522, 422);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "人员信息";
            // 
            // tBNoCarDetail
            // 
            this.tBNoCarDetail.Location = new System.Drawing.Point(363, 270);
            this.tBNoCarDetail.Name = "tBNoCarDetail";
            this.tBNoCarDetail.Size = new System.Drawing.Size(100, 21);
            this.tBNoCarDetail.TabIndex = 17;
            // 
            // tBNoCarNumber
            // 
            this.tBNoCarNumber.Location = new System.Drawing.Point(100, 271);
            this.tBNoCarNumber.Name = "tBNoCarNumber";
            this.tBNoCarNumber.Size = new System.Drawing.Size(117, 21);
            this.tBNoCarNumber.TabIndex = 16;
            // 
            // tBHuZhuRelation
            // 
            this.tBHuZhuRelation.Location = new System.Drawing.Point(363, 230);
            this.tBHuZhuRelation.Name = "tBHuZhuRelation";
            this.tBHuZhuRelation.Size = new System.Drawing.Size(100, 21);
            this.tBHuZhuRelation.TabIndex = 15;
            // 
            // cBHuZhu
            // 
            this.cBHuZhu.AutoSize = true;
            this.cBHuZhu.Location = new System.Drawing.Point(182, 233);
            this.cBHuZhu.Name = "cBHuZhu";
            this.cBHuZhu.Size = new System.Drawing.Size(84, 16);
            this.cBHuZhu.TabIndex = 14;
            this.cBHuZhu.Text = "是否为户主";
            this.cBHuZhu.UseVisualStyleBackColor = true;
            this.cBHuZhu.CheckedChanged += new System.EventHandler(this.cBHuZhu_CheckedChanged);
            // 
            // cBLiveType
            // 
            this.cBLiveType.FormattingEnabled = true;
            this.cBLiveType.Items.AddRange(new object[] {
            "常住",
            "暂住",
            "租住"});
            this.cBLiveType.Location = new System.Drawing.Point(100, 233);
            this.cBLiveType.Name = "cBLiveType";
            this.cBLiveType.Size = new System.Drawing.Size(63, 20);
            this.cBLiveType.TabIndex = 13;
            // 
            // tBTeChang
            // 
            this.tBTeChang.Location = new System.Drawing.Point(363, 184);
            this.tBTeChang.Name = "tBTeChang";
            this.tBTeChang.Size = new System.Drawing.Size(100, 21);
            this.tBTeChang.TabIndex = 12;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(314, 188);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(41, 12);
            this.label31.TabIndex = 28;
            this.label31.Text = "特长：";
            // 
            // cBXueXing
            // 
            this.cBXueXing.FormattingEnabled = true;
            this.cBXueXing.Items.AddRange(new object[] {
            "O型",
            "A型",
            "B型",
            "AB血型",
            "其它"});
            this.cBXueXing.Location = new System.Drawing.Point(221, 185);
            this.cBXueXing.Name = "cBXueXing";
            this.cBXueXing.Size = new System.Drawing.Size(56, 20);
            this.cBXueXing.TabIndex = 11;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(178, 188);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(41, 12);
            this.label30.TabIndex = 26;
            this.label30.Text = "血型：";
            // 
            // tBShenGao
            // 
            this.tBShenGao.Location = new System.Drawing.Point(100, 185);
            this.tBShenGao.Name = "tBShenGao";
            this.tBShenGao.Size = new System.Drawing.Size(67, 21);
            this.tBShenGao.TabIndex = 10;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(361, 109);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(47, 12);
            this.label29.TabIndex = 24;
            this.label29.Text = "手机二:";
            // 
            // tBPhone2
            // 
            this.tBPhone2.Location = new System.Drawing.Point(415, 106);
            this.tBPhone2.Name = "tBPhone2";
            this.tBPhone2.Size = new System.Drawing.Size(100, 21);
            this.tBPhone2.TabIndex = 8;
            // 
            // tBPhone1
            // 
            this.tBPhone1.Location = new System.Drawing.Point(263, 106);
            this.tBPhone1.Name = "tBPhone1";
            this.tBPhone1.Size = new System.Drawing.Size(94, 21);
            this.tBPhone1.TabIndex = 7;
            // 
            // tBGuDingPhone
            // 
            this.tBGuDingPhone.Location = new System.Drawing.Point(100, 106);
            this.tBGuDingPhone.Name = "tBGuDingPhone";
            this.tBGuDingPhone.Size = new System.Drawing.Size(100, 21);
            this.tBGuDingPhone.TabIndex = 6;
            // 
            // tBGuoJi
            // 
            this.tBGuoJi.Location = new System.Drawing.Point(415, 67);
            this.tBGuoJi.Name = "tBGuoJi";
            this.tBGuoJi.Size = new System.Drawing.Size(59, 21);
            this.tBGuoJi.TabIndex = 5;
            this.tBGuoJi.Text = "中国";
            // 
            // tBRenHuReason
            // 
            this.tBRenHuReason.Location = new System.Drawing.Point(100, 68);
            this.tBRenHuReason.Name = "tBRenHuReason";
            this.tBRenHuReason.Size = new System.Drawing.Size(253, 21);
            this.tBRenHuReason.TabIndex = 4;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(472, 36);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(17, 12);
            this.label24.TabIndex = 18;
            this.label24.Text = "室";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(395, 34);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(29, 12);
            this.label23.TabIndex = 17;
            this.label23.Text = "单元";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(314, 34);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(29, 12);
            this.label22.TabIndex = 10;
            this.label22.Text = "号楼";
            // 
            // tBRoom
            // 
            this.tBRoom.Location = new System.Drawing.Point(429, 31);
            this.tBRoom.Name = "tBRoom";
            this.tBRoom.Size = new System.Drawing.Size(39, 21);
            this.tBRoom.TabIndex = 3;
            // 
            // tBDanYuan
            // 
            this.tBDanYuan.Location = new System.Drawing.Point(349, 31);
            this.tBDanYuan.Name = "tBDanYuan";
            this.tBDanYuan.Size = new System.Drawing.Size(39, 21);
            this.tBDanYuan.TabIndex = 2;
            // 
            // tBLouNumber
            // 
            this.tBLouNumber.Location = new System.Drawing.Point(266, 31);
            this.tBLouNumber.Name = "tBLouNumber";
            this.tBLouNumber.Size = new System.Drawing.Size(42, 21);
            this.tBLouNumber.TabIndex = 1;
            // 
            // tBWorkDepartment
            // 
            this.tBWorkDepartment.Location = new System.Drawing.Point(100, 145);
            this.tBWorkDepartment.Name = "tBWorkDepartment";
            this.tBWorkDepartment.Size = new System.Drawing.Size(383, 21);
            this.tBWorkDepartment.TabIndex = 9;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(367, 71);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(41, 12);
            this.label26.TabIndex = 4;
            this.label26.Text = "国籍：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 148);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 4;
            this.label12.Text = "工作单位：";
            // 
            // tBCarNum
            // 
            this.tBCarNum.Location = new System.Drawing.Point(100, 306);
            this.tBCarNum.Name = "tBCarNum";
            this.tBCarNum.Size = new System.Drawing.Size(121, 21);
            this.tBCarNum.TabIndex = 18;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(6, 71);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(89, 12);
            this.label25.TabIndex = 2;
            this.label25.Text = "人户分离原因：";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(30, 109);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(65, 12);
            this.label27.TabIndex = 2;
            this.label27.Text = "固定电话：";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(213, 112);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(53, 12);
            this.label28.TabIndex = 2;
            this.label28.Text = "手机一：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(53, 188);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 2;
            this.label11.Text = "身高：";
            // 
            // tBNowLiveArea
            // 
            this.tBNowLiveArea.Location = new System.Drawing.Point(100, 29);
            this.tBNowLiveArea.Name = "tBNowLiveArea";
            this.tBNowLiveArea.Size = new System.Drawing.Size(135, 21);
            this.tBNowLiveArea.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "现居住地：";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(276, 233);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(77, 12);
            this.label33.TabIndex = 0;
            this.label33.Text = "与户主关系：";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(264, 274);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(89, 12);
            this.label35.TabIndex = 0;
            this.label35.Text = "非机动车详情：";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(17, 310);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(77, 12);
            this.label36.TabIndex = 0;
            this.label36.Text = "机动车数量：";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(6, 271);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(89, 12);
            this.label34.TabIndex = 0;
            this.label34.Text = "非机动车数量：";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(30, 233);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(65, 12);
            this.label32.TabIndex = 0;
            this.label32.Text = "居住性质：";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tBIDAddress);
            this.groupBox3.Controls.Add(this.tBNation);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.tBShenFenID);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.cBSex);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.tBName);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(14, 111);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(522, 151);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "身份证信息";
            // 
            // tBIDAddress
            // 
            this.tBIDAddress.Location = new System.Drawing.Point(104, 103);
            this.tBIDAddress.Name = "tBIDAddress";
            this.tBIDAddress.Size = new System.Drawing.Size(365, 21);
            this.tBIDAddress.TabIndex = 4;
            // 
            // tBNation
            // 
            this.tBNation.Location = new System.Drawing.Point(404, 28);
            this.tBNation.Name = "tBNation";
            this.tBNation.Size = new System.Drawing.Size(65, 21);
            this.tBNation.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(369, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 6;
            this.label8.Text = "民族：";
            // 
            // tBShenFenID
            // 
            this.tBShenFenID.Location = new System.Drawing.Point(104, 66);
            this.tBShenFenID.Name = "tBShenFenID";
            this.tBShenFenID.Size = new System.Drawing.Size(365, 21);
            this.tBShenFenID.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 12);
            this.label9.TabIndex = 4;
            this.label9.Text = "身份证地址：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "身份证号码：";
            // 
            // cBSex
            // 
            this.cBSex.FormattingEnabled = true;
            this.cBSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cBSex.Location = new System.Drawing.Point(300, 28);
            this.cBSex.Name = "cBSex";
            this.cBSex.Size = new System.Drawing.Size(53, 20);
            this.cBSex.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(253, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "性别：";
            // 
            // tBName
            // 
            this.tBName.Location = new System.Drawing.Point(104, 28);
            this.tBName.Name = "tBName";
            this.tBName.Size = new System.Drawing.Size(135, 21);
            this.tBName.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "姓名：";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tBLouYuanName);
            this.groupBox4.Controls.Add(this.tBSheQuName);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(12, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(522, 59);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "社区信息";
            // 
            // tBLouYuanName
            // 
            this.tBLouYuanName.Location = new System.Drawing.Point(303, 27);
            this.tBLouYuanName.Name = "tBLouYuanName";
            this.tBLouYuanName.Size = new System.Drawing.Size(168, 21);
            this.tBLouYuanName.TabIndex = 1;
            // 
            // tBSheQuName
            // 
            this.tBSheQuName.Location = new System.Drawing.Point(86, 26);
            this.tBSheQuName.Name = "tBSheQuName";
            this.tBSheQuName.Size = new System.Drawing.Size(135, 21);
            this.tBSheQuName.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "楼院名称:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "社区名称:";
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(714, 679);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(78, 37);
            this.bSave.TabIndex = 5;
            this.bSave.Text = "信息入库";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bReadID
            // 
            this.bReadID.Location = new System.Drawing.Point(229, 68);
            this.bReadID.Name = "bReadID";
            this.bReadID.Size = new System.Drawing.Size(88, 37);
            this.bReadID.TabIndex = 1;
            this.bReadID.Text = "读取身份证";
            this.bReadID.UseVisualStyleBackColor = true;
            this.bReadID.Click += new System.EventHandler(this.bReadID_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(860, 687);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(109, 20);
            this.label17.TabIndex = 11;
            this.label17.Text = "入库序号：";
            // 
            // lSavedIndex
            // 
            this.lSavedIndex.AutoSize = true;
            this.lSavedIndex.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lSavedIndex.ForeColor = System.Drawing.Color.DarkRed;
            this.lSavedIndex.Location = new System.Drawing.Point(965, 685);
            this.lSavedIndex.Name = "lSavedIndex";
            this.lSavedIndex.Size = new System.Drawing.Size(0, 20);
            this.lSavedIndex.TabIndex = 12;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(10, 74);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(189, 19);
            this.label18.TabIndex = 13;
            this.label18.Text = "第一步：读取身份证";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(18, 265);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(209, 19);
            this.label19.TabIndex = 14;
            this.label19.Text = "第二步：录入人员信息";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.ForeColor = System.Drawing.Color.Red;
            this.label20.Location = new System.Drawing.Point(567, 640);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(129, 19);
            this.label20.TabIndex = 15;
            this.label20.Text = "第三步：拍照";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label21.ForeColor = System.Drawing.Color.Red;
            this.label21.Location = new System.Drawing.Point(567, 685);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(129, 19);
            this.label21.TabIndex = 16;
            this.label21.Text = "第四步：入库";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 720);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.lSavedIndex);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.bReadID);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picbPreview);
            this.Controls.Add(this.vispShoot);
            this.Controls.Add(this.btnPic);
            this.Controls.Add(this.btnCut);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.cboResolution);
            this.Controls.Add(this.cboVideo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "社区人员信息采集-V2.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbPreview)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboVideo;
        private System.Windows.Forms.ComboBox cboResolution;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnCut;
        private System.Windows.Forms.Button btnPic;
        private AForge.Controls.VideoSourcePlayer vispShoot;
        private AForge.Controls.PictureBox picbPreview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tBShenFenID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cBSex;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tBName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tBLouYuanName;
        private System.Windows.Forms.TextBox tBSheQuName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cBCarType;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cBCarColor;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tBCarNumber;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tBCar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tBWorkDepartment;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tBCarNum;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tBNowLiveArea;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tBIDAddress;
        private System.Windows.Forms.TextBox tBNation;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bReadID;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lSavedIndex;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox tBRoom;
        private System.Windows.Forms.TextBox tBDanYuan;
        private System.Windows.Forms.TextBox tBLouNumber;
        private System.Windows.Forms.TextBox tBNoCarDetail;
        private System.Windows.Forms.TextBox tBNoCarNumber;
        private System.Windows.Forms.TextBox tBHuZhuRelation;
        private System.Windows.Forms.CheckBox cBHuZhu;
        private System.Windows.Forms.ComboBox cBLiveType;
        private System.Windows.Forms.TextBox tBTeChang;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.ComboBox cBXueXing;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox tBShenGao;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox tBPhone2;
        private System.Windows.Forms.TextBox tBPhone1;
        private System.Windows.Forms.TextBox tBGuDingPhone;
        private System.Windows.Forms.TextBox tBGuoJi;
        private System.Windows.Forms.TextBox tBRenHuReason;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label32;
    }
}

