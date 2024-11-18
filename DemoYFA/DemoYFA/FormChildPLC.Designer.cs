namespace LocalApp
{
	partial class FormChildPLC
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
			this.plcGroupBox1 = new YHMI.PlcGroupBox();
			this.plcButton2 = new YHMI.PlcButton();
			this.plcLamp2 = new YHMI.PlcLamp();
			this.plcLabelVauleEx1 = new YHMI.PlcLabelVauleEx();
			this.plcTextBox5 = new YHMI.PlcTextBox();
			this.plcTextBox6 = new YHMI.PlcTextBox();
			this.plcLamp1 = new YHMI.PlcLamp();
			this.plcButton1 = new YHMI.PlcButton();
			this.plcVauleBox1 = new YHMI.PlcLabelVauleEx();
			this.plcTextBox3 = new YHMI.PlcTextBox();
			this.plcTextBox4 = new YHMI.PlcTextBox();
			this.plcGroupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// plcGroupBox1
			// 
			this.plcGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.plcGroupBox1.Controls.Add(this.plcButton2);
			this.plcGroupBox1.Controls.Add(this.plcLamp2);
			this.plcGroupBox1.Controls.Add(this.plcLabelVauleEx1);
			this.plcGroupBox1.Controls.Add(this.plcTextBox5);
			this.plcGroupBox1.Controls.Add(this.plcTextBox6);
			this.plcGroupBox1.Controls.Add(this.plcLamp1);
			this.plcGroupBox1.Controls.Add(this.plcButton1);
			this.plcGroupBox1.Controls.Add(this.plcVauleBox1);
			this.plcGroupBox1.Controls.Add(this.plcTextBox3);
			this.plcGroupBox1.Controls.Add(this.plcTextBox4);
			this.plcGroupBox1.Location = new System.Drawing.Point(12, 12);
			this.plcGroupBox1.Name = "plcGroupBox1";
			this.plcGroupBox1.plcEnabled = null;
			this.plcGroupBox1.plcVisible = null;
			this.plcGroupBox1.Size = new System.Drawing.Size(238, 209);
			this.plcGroupBox1.TabIndex = 65;
			this.plcGroupBox1.TabStop = false;
			this.plcGroupBox1.Text = "定时器测试";
			this.plcGroupBox1.UserLevel = 0;
			// 
			// plcButton2
			// 
			this.plcButton2.ColorRST = System.Drawing.Color.Empty;
			this.plcButton2.ColorSET = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.plcButton2.ConstValue = null;
			this.plcButton2.DataType = YHMI.PlcValueTypeN.I4;
			this.plcButton2.Location = new System.Drawing.Point(131, 171);
			this.plcButton2.Name = "plcButton2";
			this.plcButton2.plcColor = "20010.16";
			this.plcButton2.plcDataDst = null;
			this.plcButton2.plcDataSrc = null;
			this.plcButton2.plcEnabled = null;
			this.plcButton2.plcValue = "20010.00";
			this.plcButton2.plcVisible = null;
			this.plcButton2.Size = new System.Drawing.Size(86, 32);
			this.plcButton2.TabIndex = 60;
			this.plcButton2.Text = "开始计时";
			this.plcButton2.UserLevel = 0;
			this.plcButton2.UseVisualStyleBackColor = false;
			// 
			// plcLamp2
			// 
			this.plcLamp2.ColorType = YHMI.PlcLamp.eColorType.Green;
			this.plcLamp2.FillColorRST = System.Drawing.Color.Empty;
			this.plcLamp2.FillColorSET = System.Drawing.Color.Empty;
			this.plcLamp2.FillGradientColorRST = System.Drawing.Color.Empty;
			this.plcLamp2.FillGradientColorSET = System.Drawing.Color.Empty;
			this.plcLamp2.Location = new System.Drawing.Point(152, 29);
			this.plcLamp2.Name = "plcLamp2";
			this.plcLamp2.plcEnabled = null;
			this.plcLamp2.plcEvent = null;
			this.plcLamp2.plcValue = "20010.16";
			this.plcLamp2.plcVisible = null;
			this.plcLamp2.Size = new System.Drawing.Size(40, 37);
			this.plcLamp2.Stretch = false;
			this.plcLamp2.TabIndex = 59;
			this.plcLamp2.Value = false;
			// 
			// plcLabelVauleEx1
			// 
			this.plcLabelVauleEx1.DecimalPlaces = 0;
			this.plcLabelVauleEx1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.plcLabelVauleEx1.Hexadecimal = false;
			this.plcLabelVauleEx1.Location = new System.Drawing.Point(131, 72);
			this.plcLabelVauleEx1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.plcLabelVauleEx1.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.plcLabelVauleEx1.Name = "plcLabelVauleEx1";
			this.plcLabelVauleEx1.plcEnabled = null;
			this.plcLabelVauleEx1.plcValue = "20012";
			this.plcLabelVauleEx1.plcVisible = null;
			this.plcLabelVauleEx1.Ratio = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.plcLabelVauleEx1.ReadOnly = false;
			this.plcLabelVauleEx1.ShowEditBT = true;
			this.plcLabelVauleEx1.ShowValueGTMin = false;
			this.plcLabelVauleEx1.Size = new System.Drawing.Size(86, 23);
			this.plcLabelVauleEx1.TabIndex = 58;
			this.plcLabelVauleEx1.UserLevel = 0;
			this.plcLabelVauleEx1.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.plcLabelVauleEx1.ValueType = YHMI.PlcValueTypeN.UI4;
			// 
			// plcTextBox5
			// 
			this.plcTextBox5.DecimalPlaces = 0;
			this.plcTextBox5.Hexadecimal = false;
			this.plcTextBox5.Location = new System.Drawing.Point(131, 98);
			this.plcTextBox5.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.plcTextBox5.MaxLength = 30;
			this.plcTextBox5.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.plcTextBox5.Name = "plcTextBox5";
			this.plcTextBox5.plcEnabled = "";
			this.plcTextBox5.plcValue = "20014";
			this.plcTextBox5.plcVisible = null;
			this.plcTextBox5.Size = new System.Drawing.Size(86, 21);
			this.plcTextBox5.TabIndex = 56;
			this.plcTextBox5.UserLevel = 0;
			this.plcTextBox5.ValueType = YHMI.PlcValueTypeNS.UI8;
			// 
			// plcTextBox6
			// 
			this.plcTextBox6.DecimalPlaces = 0;
			this.plcTextBox6.Hexadecimal = false;
			this.plcTextBox6.Location = new System.Drawing.Point(131, 125);
			this.plcTextBox6.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.plcTextBox6.MaxLength = 30;
			this.plcTextBox6.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.plcTextBox6.Name = "plcTextBox6";
			this.plcTextBox6.plcEnabled = "";
			this.plcTextBox6.plcValue = "20016";
			this.plcTextBox6.plcVisible = null;
			this.plcTextBox6.Size = new System.Drawing.Size(86, 21);
			this.plcTextBox6.TabIndex = 57;
			this.plcTextBox6.UserLevel = 0;
			this.plcTextBox6.ValueType = YHMI.PlcValueTypeNS.UI8;
			// 
			// plcLamp1
			// 
			this.plcLamp1.ColorType = YHMI.PlcLamp.eColorType.Green;
			this.plcLamp1.FillColorRST = System.Drawing.Color.Empty;
			this.plcLamp1.FillColorSET = System.Drawing.Color.Empty;
			this.plcLamp1.FillGradientColorRST = System.Drawing.Color.Empty;
			this.plcLamp1.FillGradientColorSET = System.Drawing.Color.Empty;
			this.plcLamp1.Location = new System.Drawing.Point(38, 29);
			this.plcLamp1.Name = "plcLamp1";
			this.plcLamp1.plcEnabled = null;
			this.plcLamp1.plcEvent = null;
			this.plcLamp1.plcValue = "B20000.02";
			this.plcLamp1.plcVisible = null;
			this.plcLamp1.Size = new System.Drawing.Size(40, 37);
			this.plcLamp1.Stretch = false;
			this.plcLamp1.TabIndex = 55;
			this.plcLamp1.Value = false;
			// 
			// plcButton1
			// 
			this.plcButton1.ColorRST = System.Drawing.Color.Empty;
			this.plcButton1.ColorSET = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.plcButton1.ConstValue = null;
			this.plcButton1.DataType = YHMI.PlcValueTypeN.I4;
			this.plcButton1.Location = new System.Drawing.Point(17, 171);
			this.plcButton1.Name = "plcButton1";
			this.plcButton1.plcColor = "B20000.02";
			this.plcButton1.plcDataDst = null;
			this.plcButton1.plcDataSrc = null;
			this.plcButton1.plcEnabled = null;
			this.plcButton1.plcValue = "B20000.00";
			this.plcButton1.plcVisible = null;
			this.plcButton1.Size = new System.Drawing.Size(86, 32);
			this.plcButton1.TabIndex = 8;
			this.plcButton1.Text = "开始计时";
			this.plcButton1.UserLevel = 0;
			this.plcButton1.UseVisualStyleBackColor = false;
			// 
			// plcVauleBox1
			// 
			this.plcVauleBox1.DecimalPlaces = 0;
			this.plcVauleBox1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.plcVauleBox1.Hexadecimal = false;
			this.plcVauleBox1.Location = new System.Drawing.Point(17, 72);
			this.plcVauleBox1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.plcVauleBox1.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.plcVauleBox1.Name = "plcVauleBox1";
			this.plcVauleBox1.plcEnabled = null;
			this.plcVauleBox1.plcValue = "20002";
			this.plcVauleBox1.plcVisible = null;
			this.plcVauleBox1.Ratio = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.plcVauleBox1.ReadOnly = false;
			this.plcVauleBox1.ShowEditBT = true;
			this.plcVauleBox1.ShowValueGTMin = false;
			this.plcVauleBox1.Size = new System.Drawing.Size(86, 23);
			this.plcVauleBox1.TabIndex = 54;
			this.plcVauleBox1.UserLevel = 0;
			this.plcVauleBox1.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.plcVauleBox1.ValueType = YHMI.PlcValueTypeN.UI4;
			// 
			// plcTextBox3
			// 
			this.plcTextBox3.DecimalPlaces = 0;
			this.plcTextBox3.Hexadecimal = false;
			this.plcTextBox3.Location = new System.Drawing.Point(17, 98);
			this.plcTextBox3.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.plcTextBox3.MaxLength = 30;
			this.plcTextBox3.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.plcTextBox3.Name = "plcTextBox3";
			this.plcTextBox3.plcEnabled = "";
			this.plcTextBox3.plcValue = "20004";
			this.plcTextBox3.plcVisible = null;
			this.plcTextBox3.Size = new System.Drawing.Size(86, 21);
			this.plcTextBox3.TabIndex = 51;
			this.plcTextBox3.UserLevel = 0;
			this.plcTextBox3.ValueType = YHMI.PlcValueTypeNS.UI8;
			// 
			// plcTextBox4
			// 
			this.plcTextBox4.DecimalPlaces = 0;
			this.plcTextBox4.Hexadecimal = false;
			this.plcTextBox4.Location = new System.Drawing.Point(17, 125);
			this.plcTextBox4.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.plcTextBox4.MaxLength = 30;
			this.plcTextBox4.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.plcTextBox4.Name = "plcTextBox4";
			this.plcTextBox4.plcEnabled = "";
			this.plcTextBox4.plcValue = "20006";
			this.plcTextBox4.plcVisible = null;
			this.plcTextBox4.Size = new System.Drawing.Size(86, 21);
			this.plcTextBox4.TabIndex = 52;
			this.plcTextBox4.UserLevel = 0;
			this.plcTextBox4.ValueType = YHMI.PlcValueTypeNS.UI8;
			// 
			// FormChildPLC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(550, 400);
			this.Controls.Add(this.plcGroupBox1);
			this.Name = "FormChildPLC";
			this.Text = "HmiTest";
			this.plcGroupBox1.ResumeLayout(false);
			this.plcGroupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private YHMI.PlcGroupBox plcGroupBox1;
		private YHMI.PlcButton plcButton2;
		private YHMI.PlcLamp plcLamp2;
		private YHMI.PlcLabelVauleEx plcLabelVauleEx1;
		private YHMI.PlcTextBox plcTextBox5;
		private YHMI.PlcTextBox plcTextBox6;
		private YHMI.PlcLamp plcLamp1;
		private YHMI.PlcButton plcButton1;
		private YHMI.PlcLabelVauleEx plcVauleBox1;
		private YHMI.PlcTextBox plcTextBox3;
		private YHMI.PlcTextBox plcTextBox4;
	}
}