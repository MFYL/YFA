using PLC;
using System;
using System.Windows.Forms;
using YHMI;

namespace LocalApp
{
    public partial class MainWnd : PlcForm
    {
        YPLC _plc;

        public MainWnd()
        {
            InitializeComponent();
        }

        private void HmiTest_Load(object sender, EventArgs e)
        {
            _plc = new YPLC(/*仿真标志*/ true);
            var ret = _plc.Init("mem.bin", 1, BackcallScan, "io.x", "mc.x");
            if (ret != 0)
            {
                throw new Exception("逻辑配置初始化失败!");
            }

            InitFB();

            var pm = _plc.GetPLCScan();
            if (pm.SR.ERR_FBClear)
            {
                MessageBox.Show("功能块数据有清零,说明功能块位置有变动或者新加!");
            }
            _plc.Run();

            HMI.SetPLC(0, _plc.MemPtr);
            HMI.SetPLC(1, _plc.MemPtr, 10000);

            InitDemoWnd();
        }

        void InitFB()
		{
            var fb = _plc;
            // 功能块测试
            fb.AddFB(new UserFB(), null, 9000);

            fb.AddFB("RunStop", null, 10000);
            fb.AddFB("ThreeLamp", null, 10100);
            fb.AddFB("StatsKI", null, 10200);
            fb.AddFB("StatsKI2", null, 10500);

            fb.AddFB("Timer32", null, 11000);
            fb.AddFB("Timer64", null, 11010);
            fb.AddFB("TimerAccS", null, 11020);
            fb.AddFB("TimerAccMS", null, 11030);
            fb.AddFB("DelayOnOff", null, 11100);
            fb.AddFB("DelayMinOut", null, 11200);
            fb.AddFB("CTUD", null, 11300);

            fb.AddFB("SV", null, 12000);
            fb.AddFB("SV_SXZK", null, 12100);

            fb.AddFB("Motor", null, 13000);
            fb.AddFB("Camera", null, 13100);
            fb.AddFB("AxisMotion", null, 15000);

            // 对应界面两定时器
            for (int i = 0; i < 2; i++)
            {
                fb.AddFB("Timer64", $"定时器{i + 1}", 20000 + i * 10);
            }
        }

        void InitDemoWnd()
		{
            plcMultiPanelController1.Add(new FormChild数值());
            plcMultiPanelController1.Add(new FormChild按钮());
            plcMultiPanelController1.Add(new FormChild报警());
            plcMultiPanelController1.Add(new FormChildPLC());
            plcMultiPanelController1.Add(_plc.GetMonitorWnd());
        }

        void BackcallScan(IPM pm)
        {
            pm.W(1, HMI.UserLevel);
        }

        private void HmiTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            HMI.Dispose();
            YPLC.DisposeAll();
        }

        private void btMG_Click(object sender, EventArgs e)
		{
            HMI.ShowUserManageDialoag("", true);
        }

        private void btLogin_Click(object sender, EventArgs e)
		{
            HMI.ShowLoginDialoag();
        }

		private void btIO_Click(object sender, EventArgs e)
		{
            _plc.ShowMonitorIoDlg();
        }

        private void btAlarm_Click(object sender, EventArgs e)
		{
            HMI.ShowAlarmEditDlg();
        }

        private void btDump_Click(object sender, EventArgs e)
		{
            HMI.ShowDumpEditDlg();
        }

        private void btValueEdit_Click(object sender, EventArgs e)
		{
            HMI.ShowNameAddrEditDlg();
        }

        private void btPWnd_Click(object sender, EventArgs e)
		{
            HMI.ShowPopupWndEditDlg();
        }

        private void btDlg_Click(object sender, EventArgs e)
        {
            HMI.ShowDialog<FormDlg>();
        }
    }
}
