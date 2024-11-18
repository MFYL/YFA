namespace LocalApp
{
	partial class FormChild报警
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
            this.plcAlarmBox1 = new YHMI.PlcAlarmBox();
            this.plcAlarmRecordView1 = new YHMI.PlcAlarmRecordView();
            this.plcGroupBox2 = new YHMI.PlcGroupBox();
            this.plcCheckBox4 = new YHMI.PlcCheckBox();
            this.plcCheckBox3 = new YHMI.PlcCheckBox();
            this.plcCheckBox2 = new YHMI.PlcCheckBox();
            this.plcCheckBox1 = new YHMI.PlcCheckBox();
            this.plcButton4 = new YHMI.PlcButton();
            this.plcButton3 = new YHMI.PlcButton();
            this.plcButton2 = new YHMI.PlcButton();
            this.plcButton1 = new YHMI.PlcButton();
            this.plcGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // plcAlarmBox1
            // 
            this.plcAlarmBox1.ID = -1;
            this.plcAlarmBox1.Location = new System.Drawing.Point(12, 128);
            this.plcAlarmBox1.Name = "plcAlarmBox1";
            this.plcAlarmBox1.Size = new System.Drawing.Size(526, 102);
            this.plcAlarmBox1.TabIndex = 54;
            // 
            // plcAlarmRecordView1
            // 
            this.plcAlarmRecordView1.BackColor = System.Drawing.SystemColors.Window;
            this.plcAlarmRecordView1.FullRowSelect = true;
            this.plcAlarmRecordView1.GridLines = true;
            this.plcAlarmRecordView1.HideSelection = false;
            this.plcAlarmRecordView1.ID = -1;
            this.plcAlarmRecordView1.Location = new System.Drawing.Point(12, 12);
            this.plcAlarmRecordView1.MultiSelect = false;
            this.plcAlarmRecordView1.Name = "plcAlarmRecordView1";
            this.plcAlarmRecordView1.ShowPlcID = true;
            this.plcAlarmRecordView1.Size = new System.Drawing.Size(526, 101);
            this.plcAlarmRecordView1.TabIndex = 53;
            this.plcAlarmRecordView1.UseCompatibleStateImageBehavior = false;
            this.plcAlarmRecordView1.View = System.Windows.Forms.View.Details;
            // 
            // plcGroupBox2
            // 
            this.plcGroupBox2.Controls.Add(this.plcCheckBox4);
            this.plcGroupBox2.Controls.Add(this.plcCheckBox3);
            this.plcGroupBox2.Controls.Add(this.plcCheckBox2);
            this.plcGroupBox2.Controls.Add(this.plcCheckBox1);
            this.plcGroupBox2.Controls.Add(this.plcButton4);
            this.plcGroupBox2.Controls.Add(this.plcButton3);
            this.plcGroupBox2.Controls.Add(this.plcButton2);
            this.plcGroupBox2.Controls.Add(this.plcButton1);
            this.plcGroupBox2.Location = new System.Drawing.Point(132, 260);
            this.plcGroupBox2.Name = "plcGroupBox2";
            this.plcGroupBox2.plcEnabled = null;
            this.plcGroupBox2.plcVisible = null;
            this.plcGroupBox2.Size = new System.Drawing.Size(301, 100);
            this.plcGroupBox2.TabIndex = 55;
            this.plcGroupBox2.TabStop = false;
            this.plcGroupBox2.Text = "报警测试 - 地址:500";
            this.plcGroupBox2.UserLevel = 0;
            // 
            // plcCheckBox4
            // 
            this.plcCheckBox4.Appearance = System.Windows.Forms.Appearance.Button;
            this.plcCheckBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.plcCheckBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plcCheckBox4.ColorRST = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.plcCheckBox4.ColorSET = System.Drawing.Color.Lime;
            this.plcCheckBox4.ImageRST = null;
            this.plcCheckBox4.ImageSET = null;
            this.plcCheckBox4.Location = new System.Drawing.Point(232, 57);
            this.plcCheckBox4.Name = "plcCheckBox4";
            this.plcCheckBox4.plcColor = "B12000.4";
            this.plcCheckBox4.plcEnabled = null;
            this.plcCheckBox4.plcValue = "B12000.4";
            this.plcCheckBox4.plcVisible = null;
            this.plcCheckBox4.Size = new System.Drawing.Size(51, 39);
            this.plcCheckBox4.TabIndex = 27;
            this.plcCheckBox4.Text = "RST";
            this.plcCheckBox4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.plcCheckBox4.TextRST = "RST";
            this.plcCheckBox4.TextSET = "SET";
            this.plcCheckBox4.UserLevel = 0;
            this.plcCheckBox4.UseVisualStyleBackColor = false;
            // 
            // plcCheckBox3
            // 
            this.plcCheckBox3.Appearance = System.Windows.Forms.Appearance.Button;
            this.plcCheckBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.plcCheckBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plcCheckBox3.ColorRST = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.plcCheckBox3.ColorSET = System.Drawing.Color.Lime;
            this.plcCheckBox3.ImageRST = null;
            this.plcCheckBox3.ImageSET = null;
            this.plcCheckBox3.Location = new System.Drawing.Point(155, 57);
            this.plcCheckBox3.Name = "plcCheckBox3";
            this.plcCheckBox3.plcColor = "B2000.3";
            this.plcCheckBox3.plcEnabled = null;
            this.plcCheckBox3.plcValue = "B2000.3";
            this.plcCheckBox3.plcVisible = null;
            this.plcCheckBox3.Size = new System.Drawing.Size(51, 39);
            this.plcCheckBox3.TabIndex = 26;
            this.plcCheckBox3.Text = "RST";
            this.plcCheckBox3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.plcCheckBox3.TextRST = "RST";
            this.plcCheckBox3.TextSET = "SET";
            this.plcCheckBox3.UserLevel = 0;
            this.plcCheckBox3.UseVisualStyleBackColor = false;
            // 
            // plcCheckBox2
            // 
            this.plcCheckBox2.Appearance = System.Windows.Forms.Appearance.Button;
            this.plcCheckBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.plcCheckBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plcCheckBox2.ColorRST = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.plcCheckBox2.ColorSET = System.Drawing.Color.Lime;
            this.plcCheckBox2.ImageRST = null;
            this.plcCheckBox2.ImageSET = null;
            this.plcCheckBox2.Location = new System.Drawing.Point(86, 57);
            this.plcCheckBox2.Name = "plcCheckBox2";
            this.plcCheckBox2.plcColor = "B2000.2";
            this.plcCheckBox2.plcEnabled = null;
            this.plcCheckBox2.plcValue = "B2000.2";
            this.plcCheckBox2.plcVisible = null;
            this.plcCheckBox2.Size = new System.Drawing.Size(51, 39);
            this.plcCheckBox2.TabIndex = 25;
            this.plcCheckBox2.Text = "RST";
            this.plcCheckBox2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.plcCheckBox2.TextRST = "RST";
            this.plcCheckBox2.TextSET = "SET";
            this.plcCheckBox2.UserLevel = 0;
            this.plcCheckBox2.UseVisualStyleBackColor = false;
            // 
            // plcCheckBox1
            // 
            this.plcCheckBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.plcCheckBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.plcCheckBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plcCheckBox1.ColorRST = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.plcCheckBox1.ColorSET = System.Drawing.Color.Lime;
            this.plcCheckBox1.ImageRST = null;
            this.plcCheckBox1.ImageSET = null;
            this.plcCheckBox1.Location = new System.Drawing.Point(17, 57);
            this.plcCheckBox1.Name = "plcCheckBox1";
            this.plcCheckBox1.plcColor = "B2000.1";
            this.plcCheckBox1.plcEnabled = null;
            this.plcCheckBox1.plcValue = "B2000.1";
            this.plcCheckBox1.plcVisible = null;
            this.plcCheckBox1.Size = new System.Drawing.Size(51, 39);
            this.plcCheckBox1.TabIndex = 24;
            this.plcCheckBox1.Text = "RST";
            this.plcCheckBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.plcCheckBox1.TextRST = "RST";
            this.plcCheckBox1.TextSET = "SET";
            this.plcCheckBox1.UserLevel = 0;
            this.plcCheckBox1.UseVisualStyleBackColor = false;
            // 
            // plcButton4
            // 
            this.plcButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.plcButton4.ColorRST = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.plcButton4.ColorSET = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.plcButton4.ConstValue = null;
            this.plcButton4.DataType = YHMI.PlcValueTypeN.I4;
            this.plcButton4.Location = new System.Drawing.Point(232, 20);
            this.plcButton4.Name = "plcButton4";
            this.plcButton4.plcColor = "B12000.4";
            this.plcButton4.plcDataDst = null;
            this.plcButton4.plcDataSrc = null;
            this.plcButton4.plcEnabled = null;
            this.plcButton4.plcValue = "B12000.4";
            this.plcButton4.plcVisible = null;
            this.plcButton4.Size = new System.Drawing.Size(63, 31);
            this.plcButton4.TabIndex = 22;
            this.plcButton4.Text = "B12000.4";
            this.plcButton4.UserLevel = 0;
            this.plcButton4.UseVisualStyleBackColor = false;
            // 
            // plcButton3
            // 
            this.plcButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.plcButton3.ColorRST = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.plcButton3.ColorSET = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.plcButton3.ConstValue = null;
            this.plcButton3.DataType = YHMI.PlcValueTypeN.I4;
            this.plcButton3.Location = new System.Drawing.Point(155, 20);
            this.plcButton3.Name = "plcButton3";
            this.plcButton3.plcColor = "B2000.3";
            this.plcButton3.plcDataDst = null;
            this.plcButton3.plcDataSrc = null;
            this.plcButton3.plcEnabled = null;
            this.plcButton3.plcValue = "B2000.3";
            this.plcButton3.plcVisible = null;
            this.plcButton3.Size = new System.Drawing.Size(63, 31);
            this.plcButton3.TabIndex = 21;
            this.plcButton3.Text = "B2000.3";
            this.plcButton3.UserLevel = 0;
            this.plcButton3.UseVisualStyleBackColor = false;
            // 
            // plcButton2
            // 
            this.plcButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.plcButton2.ColorRST = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.plcButton2.ColorSET = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.plcButton2.ConstValue = null;
            this.plcButton2.DataType = YHMI.PlcValueTypeN.I4;
            this.plcButton2.Location = new System.Drawing.Point(86, 20);
            this.plcButton2.Name = "plcButton2";
            this.plcButton2.plcColor = "B2000.2";
            this.plcButton2.plcDataDst = null;
            this.plcButton2.plcDataSrc = null;
            this.plcButton2.plcEnabled = null;
            this.plcButton2.plcValue = "B2000.2";
            this.plcButton2.plcVisible = null;
            this.plcButton2.Size = new System.Drawing.Size(63, 31);
            this.plcButton2.TabIndex = 20;
            this.plcButton2.Text = "B2000.2";
            this.plcButton2.UserLevel = 0;
            this.plcButton2.UseVisualStyleBackColor = false;
            // 
            // plcButton1
            // 
            this.plcButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.plcButton1.ColorRST = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.plcButton1.ColorSET = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.plcButton1.ConstValue = null;
            this.plcButton1.DataType = YHMI.PlcValueTypeN.I4;
            this.plcButton1.Location = new System.Drawing.Point(17, 20);
            this.plcButton1.Name = "plcButton1";
            this.plcButton1.plcColor = "B2000.1";
            this.plcButton1.plcDataDst = null;
            this.plcButton1.plcDataSrc = null;
            this.plcButton1.plcEnabled = null;
            this.plcButton1.plcValue = "B2000.1";
            this.plcButton1.plcVisible = null;
            this.plcButton1.Size = new System.Drawing.Size(63, 31);
            this.plcButton1.TabIndex = 19;
            this.plcButton1.Text = "B2000.1";
            this.plcButton1.UserLevel = 0;
            this.plcButton1.UseVisualStyleBackColor = false;
            // 
            // FormChild报警
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 400);
            this.Controls.Add(this.plcGroupBox2);
            this.Controls.Add(this.plcAlarmBox1);
            this.Controls.Add(this.plcAlarmRecordView1);
            this.Name = "FormChild报警";
            this.Text = "HmiTest";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormChild报警_MouseDown);
            this.plcGroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private YHMI.PlcAlarmBox plcAlarmBox1;
		private YHMI.PlcAlarmRecordView plcAlarmRecordView1;
		private YHMI.PlcGroupBox plcGroupBox2;
		private YHMI.PlcCheckBox plcCheckBox4;
		private YHMI.PlcCheckBox plcCheckBox3;
		private YHMI.PlcCheckBox plcCheckBox2;
		private YHMI.PlcCheckBox plcCheckBox1;
		private YHMI.PlcButton plcButton4;
		private YHMI.PlcButton plcButton3;
		private YHMI.PlcButton plcButton2;
		private YHMI.PlcButton plcButton1;
	}
}