namespace LocalApp
{
    partial class MainWnd
	{
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btLogin = new System.Windows.Forms.Button();
            this.btMG = new System.Windows.Forms.Button();
            this.plcGroupBox3 = new YHMI.PlcGroupBox();
            this.plcLabelVaule7 = new YHMI.PlcLabelVaule();
            this.plC_GroupBox2 = new YHMI.PlcGroupBox();
            this.plC_LampText7 = new YHMI.PlcLampText();
            this.plC_LampText6 = new YHMI.PlcLampText();
            this.plC_LampText5 = new YHMI.PlcLampText();
            this.plC_LampText4 = new YHMI.PlcLampText();
            this.plC_LampText3 = new YHMI.PlcLampText();
            this.plC_LampText1 = new YHMI.PlcLampText();
            this.plcLabelVaule5 = new YHMI.PlcLabelVaule();
            this.plcLabelVaule4 = new YHMI.PlcLabelVaule();
            this.plcLabelVaule3 = new YHMI.PlcLabelVaule();
            this.plcLabelVaule2 = new YHMI.PlcLabelVaule();
            this.btPWnd = new System.Windows.Forms.Button();
            this.btValueEdit = new System.Windows.Forms.Button();
            this.btDump = new System.Windows.Forms.Button();
            this.btAlarm = new YHMI.PlcButton();
            this.btIO = new System.Windows.Forms.Button();
            this.plcLabel1 = new YHMI.PlcLabel();
            this.plcGroupBox1 = new YHMI.PlcGroupBox();
            this.plcGroupBox2 = new YHMI.PlcGroupBox();
            this.plcGroupBox4 = new YHMI.PlcGroupBox();
            this.plcGroupBox5 = new YHMI.PlcGroupBox();
            this.plcButton2 = new YHMI.PlcButton();
            this.btDlg = new YHMI.PlcButton();
            this.plcButton1 = new YHMI.PlcButton();
            this.plcButton7 = new YHMI.PlcButton();
            this.plcButton6 = new YHMI.PlcButton();
            this.plcButton5 = new YHMI.PlcButton();
            this.plcMultiPanelController1 = new YHMI.PlcMultiPanelController();
            this.plcGroupBox3.SuspendLayout();
            this.plC_GroupBox2.SuspendLayout();
            this.plcGroupBox1.SuspendLayout();
            this.plcGroupBox2.SuspendLayout();
            this.plcGroupBox4.SuspendLayout();
            this.plcGroupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(85, 38);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(67, 24);
            this.btLogin.TabIndex = 61;
            this.btLogin.Text = "用户登录";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // btMG
            // 
            this.btMG.Location = new System.Drawing.Point(10, 38);
            this.btMG.Name = "btMG";
            this.btMG.Size = new System.Drawing.Size(67, 24);
            this.btMG.TabIndex = 60;
            this.btMG.Text = "用户管理";
            this.btMG.UseVisualStyleBackColor = true;
            this.btMG.Click += new System.EventHandler(this.btMG_Click);
            // 
            // plcGroupBox3
            // 
            this.plcGroupBox3.Controls.Add(this.plcLabelVaule7);
            this.plcGroupBox3.Location = new System.Drawing.Point(30, 82);
            this.plcGroupBox3.Name = "plcGroupBox3";
            this.plcGroupBox3.plcEnabled = null;
            this.plcGroupBox3.plcVisible = null;
            this.plcGroupBox3.Size = new System.Drawing.Size(109, 67);
            this.plcGroupBox3.TabIndex = 51;
            this.plcGroupBox3.TabStop = false;
            this.plcGroupBox3.Text = "登录级别";
            this.plcGroupBox3.UserLevel = 0;
            // 
            // plcLabelVaule7
            // 
            this.plcLabelVaule7.BackColor = System.Drawing.Color.White;
            this.plcLabelVaule7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plcLabelVaule7.DecimalPlaces = 0;
            this.plcLabelVaule7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plcLabelVaule7.Hexadecimal = false;
            this.plcLabelVaule7.Location = new System.Drawing.Point(16, 32);
            this.plcLabelVaule7.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.plcLabelVaule7.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.plcLabelVaule7.Name = "plcLabelVaule7";
            this.plcLabelVaule7.plcEnabled = null;
            this.plcLabelVaule7.plcValue = "1";
            this.plcLabelVaule7.plcVisible = null;
            this.plcLabelVaule7.Ratio = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.plcLabelVaule7.ReadOnly = true;
            this.plcLabelVaule7.ShowValueGTMin = false;
            this.plcLabelVaule7.Size = new System.Drawing.Size(79, 20);
            this.plcLabelVaule7.TabIndex = 75;
            this.plcLabelVaule7.Text = "0";
            this.plcLabelVaule7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.plcLabelVaule7.TimerAccMode = 0;
            this.plcLabelVaule7.UserLevel = 0;
            this.plcLabelVaule7.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.plcLabelVaule7.ValueType = YHMI.PlcValueTypeN.I4;
            // 
            // plC_GroupBox2
            // 
            this.plC_GroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.plC_GroupBox2.Controls.Add(this.plC_LampText7);
            this.plC_GroupBox2.Controls.Add(this.plC_LampText6);
            this.plC_GroupBox2.Controls.Add(this.plC_LampText5);
            this.plC_GroupBox2.Controls.Add(this.plC_LampText4);
            this.plC_GroupBox2.Controls.Add(this.plC_LampText3);
            this.plC_GroupBox2.Controls.Add(this.plC_LampText1);
            this.plC_GroupBox2.Location = new System.Drawing.Point(12, 554);
            this.plC_GroupBox2.Name = "plC_GroupBox2";
            this.plC_GroupBox2.plcEnabled = "100.02";
            this.plC_GroupBox2.plcVisible = "";
            this.plC_GroupBox2.Size = new System.Drawing.Size(480, 80);
            this.plC_GroupBox2.TabIndex = 37;
            this.plC_GroupBox2.TabStop = false;
            this.plC_GroupBox2.Text = "PLC系统脉冲";
            this.plC_GroupBox2.UserLevel = 0;
            // 
            // plC_LampText7
            // 
            this.plC_LampText7.ColorType = YHMI.PlcLamp.eColorType.Green;
            this.plC_LampText7.FillColorRST = System.Drawing.Color.Maroon;
            this.plC_LampText7.FillColorSET = System.Drawing.Color.Green;
            this.plC_LampText7.FillGradientColorRST = System.Drawing.Color.Red;
            this.plC_LampText7.FillGradientColorSET = System.Drawing.Color.Lime;
            this.plC_LampText7.GapWidth = 0;
            this.plC_LampText7.Location = new System.Drawing.Point(411, 25);
            this.plC_LampText7.Name = "plC_LampText7";
            this.plC_LampText7.plcEnabled = null;
            this.plC_LampText7.plcEvent = "";
            this.plC_LampText7.plcValue = "S_P_2";
            this.plC_LampText7.plcVisible = null;
            this.plC_LampText7.Size = new System.Drawing.Size(67, 46);
            this.plC_LampText7.TabIndex = 38;
            this.plC_LampText7.Text = "2秒";
            this.plC_LampText7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.plC_LampText7.TextFont = new System.Drawing.Font("宋体", 9F);
            this.plC_LampText7.TextStyle = YHMI.PlcLampText.PlcLampText_TextStyle.Bottom;
            this.plC_LampText7.Value = false;
            // 
            // plC_LampText6
            // 
            this.plC_LampText6.ColorType = YHMI.PlcLamp.eColorType.Green;
            this.plC_LampText6.FillColorRST = System.Drawing.Color.Maroon;
            this.plC_LampText6.FillColorSET = System.Drawing.Color.Green;
            this.plC_LampText6.FillGradientColorRST = System.Drawing.Color.Red;
            this.plC_LampText6.FillGradientColorSET = System.Drawing.Color.Lime;
            this.plC_LampText6.GapWidth = 0;
            this.plC_LampText6.Location = new System.Drawing.Point(330, 25);
            this.plC_LampText6.Name = "plC_LampText6";
            this.plC_LampText6.plcEnabled = null;
            this.plC_LampText6.plcEvent = "";
            this.plC_LampText6.plcValue = "S_P_1";
            this.plC_LampText6.plcVisible = null;
            this.plC_LampText6.Size = new System.Drawing.Size(67, 46);
            this.plC_LampText6.TabIndex = 37;
            this.plC_LampText6.Text = "1秒";
            this.plC_LampText6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.plC_LampText6.TextFont = new System.Drawing.Font("宋体", 9F);
            this.plC_LampText6.TextStyle = YHMI.PlcLampText.PlcLampText_TextStyle.Bottom;
            this.plC_LampText6.Value = false;
            // 
            // plC_LampText5
            // 
            this.plC_LampText5.ColorType = YHMI.PlcLamp.eColorType.Green;
            this.plC_LampText5.FillColorRST = System.Drawing.Color.Maroon;
            this.plC_LampText5.FillColorSET = System.Drawing.Color.Green;
            this.plC_LampText5.FillGradientColorRST = System.Drawing.Color.Red;
            this.plC_LampText5.FillGradientColorSET = System.Drawing.Color.Lime;
            this.plC_LampText5.GapWidth = 0;
            this.plC_LampText5.Location = new System.Drawing.Point(249, 25);
            this.plC_LampText5.Name = "plC_LampText5";
            this.plC_LampText5.plcEnabled = null;
            this.plC_LampText5.plcEvent = "";
            this.plC_LampText5.plcValue = "S_P_0_2";
            this.plC_LampText5.plcVisible = null;
            this.plC_LampText5.Size = new System.Drawing.Size(67, 46);
            this.plC_LampText5.TabIndex = 36;
            this.plC_LampText5.Text = "0.2秒";
            this.plC_LampText5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.plC_LampText5.TextFont = new System.Drawing.Font("宋体", 9F);
            this.plC_LampText5.TextStyle = YHMI.PlcLampText.PlcLampText_TextStyle.Bottom;
            this.plC_LampText5.Value = false;
            // 
            // plC_LampText4
            // 
            this.plC_LampText4.ColorType = YHMI.PlcLamp.eColorType.Green;
            this.plC_LampText4.FillColorRST = System.Drawing.Color.Maroon;
            this.plC_LampText4.FillColorSET = System.Drawing.Color.Green;
            this.plC_LampText4.FillGradientColorRST = System.Drawing.Color.Red;
            this.plC_LampText4.FillGradientColorSET = System.Drawing.Color.Lime;
            this.plC_LampText4.GapWidth = 0;
            this.plC_LampText4.Location = new System.Drawing.Point(168, 25);
            this.plC_LampText4.Name = "plC_LampText4";
            this.plC_LampText4.plcEnabled = null;
            this.plC_LampText4.plcEvent = "";
            this.plC_LampText4.plcValue = "S_P_0_1";
            this.plC_LampText4.plcVisible = null;
            this.plC_LampText4.Size = new System.Drawing.Size(67, 46);
            this.plC_LampText4.TabIndex = 35;
            this.plC_LampText4.Text = "0.1秒";
            this.plC_LampText4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.plC_LampText4.TextFont = new System.Drawing.Font("宋体", 9F);
            this.plC_LampText4.TextStyle = YHMI.PlcLampText.PlcLampText_TextStyle.Bottom;
            this.plC_LampText4.Value = false;
            // 
            // plC_LampText3
            // 
            this.plC_LampText3.ColorType = YHMI.PlcLamp.eColorType.Green;
            this.plC_LampText3.FillColorRST = System.Drawing.Color.Maroon;
            this.plC_LampText3.FillColorSET = System.Drawing.Color.Green;
            this.plC_LampText3.FillGradientColorRST = System.Drawing.Color.Red;
            this.plC_LampText3.FillGradientColorSET = System.Drawing.Color.Lime;
            this.plC_LampText3.GapWidth = 0;
            this.plC_LampText3.Location = new System.Drawing.Point(87, 25);
            this.plC_LampText3.Name = "plC_LampText3";
            this.plC_LampText3.plcEnabled = null;
            this.plC_LampText3.plcEvent = "";
            this.plC_LampText3.plcValue = "S_P_0_02";
            this.plC_LampText3.plcVisible = null;
            this.plC_LampText3.Size = new System.Drawing.Size(67, 46);
            this.plC_LampText3.TabIndex = 34;
            this.plC_LampText3.Text = "0.02秒";
            this.plC_LampText3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.plC_LampText3.TextFont = new System.Drawing.Font("宋体", 9F);
            this.plC_LampText3.TextStyle = YHMI.PlcLampText.PlcLampText_TextStyle.Bottom;
            this.plC_LampText3.Value = false;
            // 
            // plC_LampText1
            // 
            this.plC_LampText1.ColorType = YHMI.PlcLamp.eColorType.Green;
            this.plC_LampText1.FillColorRST = System.Drawing.Color.Maroon;
            this.plC_LampText1.FillColorSET = System.Drawing.Color.Green;
            this.plC_LampText1.FillGradientColorRST = System.Drawing.Color.Red;
            this.plC_LampText1.FillGradientColorSET = System.Drawing.Color.Lime;
            this.plC_LampText1.GapWidth = 0;
            this.plC_LampText1.Location = new System.Drawing.Point(6, 25);
            this.plC_LampText1.Name = "plC_LampText1";
            this.plC_LampText1.plcEnabled = null;
            this.plC_LampText1.plcEvent = "";
            this.plC_LampText1.plcValue = "S_P_0_01";
            this.plC_LampText1.plcVisible = null;
            this.plC_LampText1.Size = new System.Drawing.Size(67, 46);
            this.plC_LampText1.TabIndex = 33;
            this.plC_LampText1.Text = "0.01秒";
            this.plC_LampText1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.plC_LampText1.TextFont = new System.Drawing.Font("宋体", 9F);
            this.plC_LampText1.TextStyle = YHMI.PlcLampText.PlcLampText_TextStyle.Bottom;
            this.plC_LampText1.Value = false;
            // 
            // plcLabelVaule5
            // 
            this.plcLabelVaule5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.plcLabelVaule5.DecimalPlaces = 0;
            this.plcLabelVaule5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plcLabelVaule5.Hexadecimal = false;
            this.plcLabelVaule5.Location = new System.Drawing.Point(153, 48);
            this.plcLabelVaule5.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.plcLabelVaule5.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.plcLabelVaule5.Name = "plcLabelVaule5";
            this.plcLabelVaule5.plcEnabled = null;
            this.plcLabelVaule5.plcValue = "SD_RunTimeMS";
            this.plcLabelVaule5.plcVisible = null;
            this.plcLabelVaule5.Ratio = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.plcLabelVaule5.ReadOnly = true;
            this.plcLabelVaule5.ShowValueGTMin = false;
            this.plcLabelVaule5.Size = new System.Drawing.Size(100, 27);
            this.plcLabelVaule5.TabIndex = 51;
            this.plcLabelVaule5.Text = "0";
            this.plcLabelVaule5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.plcLabelVaule5.TimerAccMode = 0;
            this.plcLabelVaule5.UserLevel = 0;
            this.plcLabelVaule5.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.plcLabelVaule5.ValueType = YHMI.PlcValueTypeN.I8;
            // 
            // plcLabelVaule4
            // 
            this.plcLabelVaule4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.plcLabelVaule4.DecimalPlaces = 0;
            this.plcLabelVaule4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plcLabelVaule4.Hexadecimal = false;
            this.plcLabelVaule4.Location = new System.Drawing.Point(153, 18);
            this.plcLabelVaule4.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.plcLabelVaule4.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.plcLabelVaule4.Name = "plcLabelVaule4";
            this.plcLabelVaule4.plcEnabled = null;
            this.plcLabelVaule4.plcValue = "SD_RunTimeS";
            this.plcLabelVaule4.plcVisible = null;
            this.plcLabelVaule4.Ratio = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.plcLabelVaule4.ReadOnly = true;
            this.plcLabelVaule4.ShowValueGTMin = false;
            this.plcLabelVaule4.Size = new System.Drawing.Size(100, 27);
            this.plcLabelVaule4.TabIndex = 50;
            this.plcLabelVaule4.Text = "0";
            this.plcLabelVaule4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.plcLabelVaule4.TimerAccMode = 0;
            this.plcLabelVaule4.UserLevel = 0;
            this.plcLabelVaule4.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.plcLabelVaule4.ValueType = YHMI.PlcValueTypeN.I4;
            // 
            // plcLabelVaule3
            // 
            this.plcLabelVaule3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.plcLabelVaule3.DecimalPlaces = 0;
            this.plcLabelVaule3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plcLabelVaule3.Hexadecimal = false;
            this.plcLabelVaule3.Location = new System.Drawing.Point(17, 48);
            this.plcLabelVaule3.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.plcLabelVaule3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.plcLabelVaule3.Name = "plcLabelVaule3";
            this.plcLabelVaule3.plcEnabled = null;
            this.plcLabelVaule3.plcValue = "SD_TimerCycleTime";
            this.plcLabelVaule3.plcVisible = null;
            this.plcLabelVaule3.Ratio = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.plcLabelVaule3.ReadOnly = true;
            this.plcLabelVaule3.ShowValueGTMin = false;
            this.plcLabelVaule3.Size = new System.Drawing.Size(100, 27);
            this.plcLabelVaule3.TabIndex = 49;
            this.plcLabelVaule3.Text = "0";
            this.plcLabelVaule3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.plcLabelVaule3.TimerAccMode = 0;
            this.plcLabelVaule3.UserLevel = 0;
            this.plcLabelVaule3.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.plcLabelVaule3.ValueType = YHMI.PlcValueTypeN.I4;
            // 
            // plcLabelVaule2
            // 
            this.plcLabelVaule2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.plcLabelVaule2.DecimalPlaces = 5;
            this.plcLabelVaule2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plcLabelVaule2.Hexadecimal = false;
            this.plcLabelVaule2.Location = new System.Drawing.Point(17, 18);
            this.plcLabelVaule2.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.plcLabelVaule2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.plcLabelVaule2.Name = "plcLabelVaule2";
            this.plcLabelVaule2.plcEnabled = null;
            this.plcLabelVaule2.plcValue = "SD_ScanCycleTime";
            this.plcLabelVaule2.plcVisible = null;
            this.plcLabelVaule2.Ratio = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.plcLabelVaule2.ReadOnly = true;
            this.plcLabelVaule2.ShowValueGTMin = false;
            this.plcLabelVaule2.Size = new System.Drawing.Size(100, 27);
            this.plcLabelVaule2.TabIndex = 48;
            this.plcLabelVaule2.Text = "0.00000";
            this.plcLabelVaule2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.plcLabelVaule2.TimerAccMode = 0;
            this.plcLabelVaule2.UserLevel = 0;
            this.plcLabelVaule2.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.plcLabelVaule2.ValueType = YHMI.PlcValueTypeN.R4;
            // 
            // btPWnd
            // 
            this.btPWnd.Location = new System.Drawing.Point(43, 172);
            this.btPWnd.Name = "btPWnd";
            this.btPWnd.Size = new System.Drawing.Size(84, 29);
            this.btPWnd.TabIndex = 66;
            this.btPWnd.Text = "弹窗表编辑";
            this.btPWnd.UseVisualStyleBackColor = true;
            this.btPWnd.Click += new System.EventHandler(this.btPWnd_Click);
            // 
            // btValueEdit
            // 
            this.btValueEdit.Location = new System.Drawing.Point(43, 137);
            this.btValueEdit.Name = "btValueEdit";
            this.btValueEdit.Size = new System.Drawing.Size(84, 29);
            this.btValueEdit.TabIndex = 65;
            this.btValueEdit.Text = "变量表编辑";
            this.btValueEdit.UseVisualStyleBackColor = true;
            this.btValueEdit.Click += new System.EventHandler(this.btValueEdit_Click);
            // 
            // btDump
            // 
            this.btDump.Location = new System.Drawing.Point(43, 102);
            this.btDump.Name = "btDump";
            this.btDump.Size = new System.Drawing.Size(84, 29);
            this.btDump.TabIndex = 64;
            this.btDump.Text = "转储表编辑";
            this.btDump.UseVisualStyleBackColor = true;
            this.btDump.Click += new System.EventHandler(this.btDump_Click);
            // 
            // btAlarm
            // 
            this.btAlarm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btAlarm.ColorRST = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btAlarm.ColorSET = System.Drawing.Color.Red;
            this.btAlarm.ConstValue = null;
            this.btAlarm.DataType = YHMI.PlcValueTypeN.I4;
            this.btAlarm.Location = new System.Drawing.Point(43, 67);
            this.btAlarm.Name = "btAlarm";
            this.btAlarm.plcColor = "200.0";
            this.btAlarm.plcDataDst = null;
            this.btAlarm.plcDataSrc = null;
            this.btAlarm.plcEnabled = null;
            this.btAlarm.plcValue = null;
            this.btAlarm.plcVisible = null;
            this.btAlarm.Size = new System.Drawing.Size(84, 29);
            this.btAlarm.TabIndex = 63;
            this.btAlarm.Text = "报警表编辑";
            this.btAlarm.UserLevel = 0;
            this.btAlarm.UseVisualStyleBackColor = false;
            this.btAlarm.Click += new System.EventHandler(this.btAlarm_Click);
            // 
            // btIO
            // 
            this.btIO.Location = new System.Drawing.Point(43, 32);
            this.btIO.Name = "btIO";
            this.btIO.Size = new System.Drawing.Size(84, 29);
            this.btIO.TabIndex = 62;
            this.btIO.Text = "IO监控";
            this.btIO.UseVisualStyleBackColor = true;
            this.btIO.Click += new System.EventHandler(this.btIO_Click);
            // 
            // plcLabel1
            // 
            this.plcLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.plcLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plcLabel1.ColorRST = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.plcLabel1.ColorSET = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.plcLabel1.Location = new System.Drawing.Point(12, 9);
            this.plcLabel1.MouseClickRst = false;
            this.plcLabel1.Name = "plcLabel1";
            this.plcLabel1.plcEnabled = null;
            this.plcLabel1.plcValue = "S_Lic";
            this.plcLabel1.plcVisible = null;
            this.plcLabel1.Size = new System.Drawing.Size(86, 30);
            this.plcLabel1.TabIndex = 69;
            this.plcLabel1.Text = "Lic";
            this.plcLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.plcLabel1.TextRST = "Lic";
            this.plcLabel1.TextSET = "Lic";
            this.plcLabel1.UserLevel = 0;
            this.plcLabel1.Value = true;
            // 
            // plcGroupBox1
            // 
            this.plcGroupBox1.Controls.Add(this.btPWnd);
            this.plcGroupBox1.Controls.Add(this.btIO);
            this.plcGroupBox1.Controls.Add(this.btAlarm);
            this.plcGroupBox1.Controls.Add(this.btDump);
            this.plcGroupBox1.Controls.Add(this.btValueEdit);
            this.plcGroupBox1.Location = new System.Drawing.Point(14, 74);
            this.plcGroupBox1.Name = "plcGroupBox1";
            this.plcGroupBox1.plcEnabled = null;
            this.plcGroupBox1.plcVisible = null;
            this.plcGroupBox1.Size = new System.Drawing.Size(163, 224);
            this.plcGroupBox1.TabIndex = 70;
            this.plcGroupBox1.TabStop = false;
            this.plcGroupBox1.Text = "功能窗口";
            this.plcGroupBox1.UserLevel = 0;
            // 
            // plcGroupBox2
            // 
            this.plcGroupBox2.Controls.Add(this.btMG);
            this.plcGroupBox2.Controls.Add(this.btLogin);
            this.plcGroupBox2.Controls.Add(this.plcGroupBox3);
            this.plcGroupBox2.Location = new System.Drawing.Point(14, 304);
            this.plcGroupBox2.Name = "plcGroupBox2";
            this.plcGroupBox2.plcEnabled = null;
            this.plcGroupBox2.plcVisible = null;
            this.plcGroupBox2.Size = new System.Drawing.Size(163, 164);
            this.plcGroupBox2.TabIndex = 71;
            this.plcGroupBox2.TabStop = false;
            this.plcGroupBox2.Text = "用户管理";
            this.plcGroupBox2.UserLevel = 0;
            // 
            // plcGroupBox4
            // 
            this.plcGroupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.plcGroupBox4.Controls.Add(this.plcLabelVaule5);
            this.plcGroupBox4.Controls.Add(this.plcLabelVaule2);
            this.plcGroupBox4.Controls.Add(this.plcLabelVaule3);
            this.plcGroupBox4.Controls.Add(this.plcLabelVaule4);
            this.plcGroupBox4.Location = new System.Drawing.Point(501, 554);
            this.plcGroupBox4.Name = "plcGroupBox4";
            this.plcGroupBox4.plcEnabled = null;
            this.plcGroupBox4.plcVisible = null;
            this.plcGroupBox4.Size = new System.Drawing.Size(268, 80);
            this.plcGroupBox4.TabIndex = 72;
            this.plcGroupBox4.TabStop = false;
            this.plcGroupBox4.Text = "PLC系统数据区";
            this.plcGroupBox4.UserLevel = 0;
            // 
            // plcGroupBox5
            // 
            this.plcGroupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plcGroupBox5.Controls.Add(this.plcButton2);
            this.plcGroupBox5.Controls.Add(this.btDlg);
            this.plcGroupBox5.Controls.Add(this.plcButton1);
            this.plcGroupBox5.Controls.Add(this.plcButton7);
            this.plcGroupBox5.Controls.Add(this.plcButton6);
            this.plcGroupBox5.Controls.Add(this.plcButton5);
            this.plcGroupBox5.Controls.Add(this.plcMultiPanelController1);
            this.plcGroupBox5.Location = new System.Drawing.Point(191, 74);
            this.plcGroupBox5.Name = "plcGroupBox5";
            this.plcGroupBox5.plcEnabled = null;
            this.plcGroupBox5.plcVisible = null;
            this.plcGroupBox5.Size = new System.Drawing.Size(578, 471);
            this.plcGroupBox5.TabIndex = 73;
            this.plcGroupBox5.TabStop = false;
            this.plcGroupBox5.Text = "HMI测试窗口";
            this.plcGroupBox5.UserLevel = 0;
            // 
            // plcButton2
            // 
            this.plcButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.plcButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.plcButton2.ColorRST = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.plcButton2.ColorSET = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.plcButton2.ConstValue = "";
            this.plcButton2.DataType = YHMI.PlcValueTypeN.I4;
            this.plcButton2.Location = new System.Drawing.Point(289, 434);
            this.plcButton2.Name = "plcButton2";
            this.plcButton2.plcColor = "D0==4";
            this.plcButton2.plcDataDst = "0";
            this.plcButton2.plcDataSrc = "$4";
            this.plcButton2.plcEnabled = null;
            this.plcButton2.plcValue = "";
            this.plcButton2.plcVisible = null;
            this.plcButton2.Size = new System.Drawing.Size(63, 31);
            this.plcButton2.TabIndex = 68;
            this.plcButton2.Text = "IO监控";
            this.plcButton2.UserLevel = 0;
            this.plcButton2.UseVisualStyleBackColor = false;
            // 
            // btDlg
            // 
            this.btDlg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btDlg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btDlg.ColorRST = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btDlg.ColorSET = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btDlg.ConstValue = "";
            this.btDlg.DataType = YHMI.PlcValueTypeN.I4;
            this.btDlg.Location = new System.Drawing.Point(500, 434);
            this.btDlg.Name = "btDlg";
            this.btDlg.plcColor = "";
            this.btDlg.plcDataDst = "";
            this.btDlg.plcDataSrc = "";
            this.btDlg.plcEnabled = null;
            this.btDlg.plcValue = "";
            this.btDlg.plcVisible = null;
            this.btDlg.Size = new System.Drawing.Size(63, 31);
            this.btDlg.TabIndex = 67;
            this.btDlg.Text = "对话框";
            this.btDlg.UserLevel = 0;
            this.btDlg.UseVisualStyleBackColor = false;
            this.btDlg.Click += new System.EventHandler(this.btDlg_Click);
            // 
            // plcButton1
            // 
            this.plcButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.plcButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.plcButton1.ColorRST = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.plcButton1.ColorSET = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.plcButton1.ConstValue = "";
            this.plcButton1.DataType = YHMI.PlcValueTypeN.I4;
            this.plcButton1.Location = new System.Drawing.Point(220, 434);
            this.plcButton1.Name = "plcButton1";
            this.plcButton1.plcColor = "D0==3";
            this.plcButton1.plcDataDst = "0";
            this.plcButton1.plcDataSrc = "$3";
            this.plcButton1.plcEnabled = null;
            this.plcButton1.plcValue = "";
            this.plcButton1.plcVisible = null;
            this.plcButton1.Size = new System.Drawing.Size(63, 31);
            this.plcButton1.TabIndex = 64;
            this.plcButton1.Text = "逻辑功能";
            this.plcButton1.UserLevel = 0;
            this.plcButton1.UseVisualStyleBackColor = false;
            // 
            // plcButton7
            // 
            this.plcButton7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.plcButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.plcButton7.ColorRST = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.plcButton7.ColorSET = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.plcButton7.ConstValue = "";
            this.plcButton7.DataType = YHMI.PlcValueTypeN.I4;
            this.plcButton7.Location = new System.Drawing.Point(151, 434);
            this.plcButton7.Name = "plcButton7";
            this.plcButton7.plcColor = "D0==2";
            this.plcButton7.plcDataDst = "0";
            this.plcButton7.plcDataSrc = "$2";
            this.plcButton7.plcEnabled = null;
            this.plcButton7.plcValue = "";
            this.plcButton7.plcVisible = null;
            this.plcButton7.Size = new System.Drawing.Size(63, 31);
            this.plcButton7.TabIndex = 63;
            this.plcButton7.Text = "报警";
            this.plcButton7.UserLevel = 0;
            this.plcButton7.UseVisualStyleBackColor = false;
            // 
            // plcButton6
            // 
            this.plcButton6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.plcButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.plcButton6.ColorRST = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.plcButton6.ColorSET = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.plcButton6.ConstValue = "";
            this.plcButton6.DataType = YHMI.PlcValueTypeN.I4;
            this.plcButton6.Location = new System.Drawing.Point(82, 434);
            this.plcButton6.Name = "plcButton6";
            this.plcButton6.plcColor = "D0==1";
            this.plcButton6.plcDataDst = "0";
            this.plcButton6.plcDataSrc = "$1";
            this.plcButton6.plcEnabled = null;
            this.plcButton6.plcValue = "";
            this.plcButton6.plcVisible = null;
            this.plcButton6.Size = new System.Drawing.Size(63, 31);
            this.plcButton6.TabIndex = 62;
            this.plcButton6.Text = "按钮指示";
            this.plcButton6.UserLevel = 0;
            this.plcButton6.UseVisualStyleBackColor = false;
            // 
            // plcButton5
            // 
            this.plcButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.plcButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.plcButton5.ColorRST = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.plcButton5.ColorSET = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.plcButton5.ConstValue = "";
            this.plcButton5.DataType = YHMI.PlcValueTypeN.I4;
            this.plcButton5.Location = new System.Drawing.Point(13, 434);
            this.plcButton5.Name = "plcButton5";
            this.plcButton5.plcColor = "D0==0";
            this.plcButton5.plcDataDst = "0";
            this.plcButton5.plcDataSrc = "$0";
            this.plcButton5.plcEnabled = null;
            this.plcButton5.plcValue = "";
            this.plcButton5.plcVisible = null;
            this.plcButton5.Size = new System.Drawing.Size(63, 31);
            this.plcButton5.TabIndex = 61;
            this.plcButton5.Text = "数值显示";
            this.plcButton5.UserLevel = 0;
            this.plcButton5.UseVisualStyleBackColor = false;
            // 
            // plcMultiPanelController1
            // 
            this.plcMultiPanelController1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plcMultiPanelController1.Location = new System.Drawing.Point(13, 28);
            this.plcMultiPanelController1.Name = "plcMultiPanelController1";
            this.plcMultiPanelController1.plcEnabled = null;
            this.plcMultiPanelController1.plcValue = "0";
            this.plcMultiPanelController1.plcVisible = null;
            this.plcMultiPanelController1.Size = new System.Drawing.Size(550, 400);
            this.plcMultiPanelController1.TabIndex = 60;
            this.plcMultiPanelController1.UserLevel = 0;
            // 
            // MainWnd
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(781, 646);
            this.Controls.Add(this.plcGroupBox5);
            this.Controls.Add(this.plcGroupBox4);
            this.Controls.Add(this.plcGroupBox2);
            this.Controls.Add(this.plcGroupBox1);
            this.Controls.Add(this.plcLabel1);
            this.Controls.Add(this.plC_GroupBox2);
            this.Name = "MainWnd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YHMI DEMO";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HmiTest_FormClosing);
            this.Load += new System.EventHandler(this.HmiTest_Load);
            this.plcGroupBox3.ResumeLayout(false);
            this.plC_GroupBox2.ResumeLayout(false);
            this.plcGroupBox1.ResumeLayout(false);
            this.plcGroupBox2.ResumeLayout(false);
            this.plcGroupBox4.ResumeLayout(false);
            this.plcGroupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private YHMI.PlcGroupBox plC_GroupBox2;
        private YHMI.PlcLampText plC_LampText7;
        private YHMI.PlcLampText plC_LampText6;
        private YHMI.PlcLampText plC_LampText5;
        private YHMI.PlcLampText plC_LampText4;
        private YHMI.PlcLampText plC_LampText3;
        private YHMI.PlcLampText plC_LampText1;
        private YHMI.PlcLabelVaule plcLabelVaule5;
        private YHMI.PlcLabelVaule plcLabelVaule4;
        private YHMI.PlcLabelVaule plcLabelVaule3;
        private YHMI.PlcLabelVaule plcLabelVaule2;
		private YHMI.PlcGroupBox plcGroupBox3;
		private System.Windows.Forms.Button btLogin;
		private System.Windows.Forms.Button btMG;
		private System.Windows.Forms.Button btPWnd;
		private System.Windows.Forms.Button btValueEdit;
		private System.Windows.Forms.Button btDump;
		private YHMI.PlcButton btAlarm;
		private System.Windows.Forms.Button btIO;
		private YHMI.PlcLabel plcLabel1;
		private YHMI.PlcGroupBox plcGroupBox1;
		private YHMI.PlcGroupBox plcGroupBox2;
		private YHMI.PlcGroupBox plcGroupBox4;
		private YHMI.PlcGroupBox plcGroupBox5;
		private YHMI.PlcLabelVaule plcLabelVaule7;
		private YHMI.PlcButton plcButton7;
		private YHMI.PlcButton plcButton6;
		private YHMI.PlcButton plcButton5;
		private YHMI.PlcMultiPanelController plcMultiPanelController1;
		private YHMI.PlcButton plcButton1;
        private YHMI.PlcButton plcButton2;
        private YHMI.PlcButton btDlg;
    }
}