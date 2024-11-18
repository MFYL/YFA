namespace LocalApp
{
	partial class FormDlg
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
			this.plC_Button1 = new YHMI.PlcButton();
			this.SuspendLayout();
			// 
			// plC_Button1
			// 
			this.plC_Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.plC_Button1.ColorRST = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.plC_Button1.ColorSET = System.Drawing.Color.Blue;
			this.plC_Button1.ConstValue = null;
			this.plC_Button1.DataType = YHMI.PlcValueTypeN.I4;
			this.plC_Button1.Location = new System.Drawing.Point(204, 40);
			this.plC_Button1.Name = "plC_Button1";
			this.plC_Button1.plcColor = "B21000.0";
			this.plC_Button1.plcDataDst = "";
			this.plC_Button1.plcDataSrc = "";
			this.plC_Button1.plcEnabled = null;
			this.plC_Button1.plcValue = "B21000.0";
			this.plC_Button1.plcVisible = null;
			this.plC_Button1.Size = new System.Drawing.Size(109, 37);
			this.plC_Button1.TabIndex = 57;
			this.plC_Button1.Text = "关闭对话框";
			this.plC_Button1.UserLevel = 0;
			this.plC_Button1.UseVisualStyleBackColor = false;
			// 
			// FormDlg
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(550, 400);
			this.Controls.Add(this.plC_Button1);
			this.Name = "FormDlg";
			this.plcClose = "B21000.0";
			this.Text = "对话框测试";
			this.ResumeLayout(false);

		}

		#endregion
		private YHMI.PlcButton plC_Button1;
	}
}