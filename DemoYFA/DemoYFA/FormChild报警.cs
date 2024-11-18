using System.Linq;
using YHMI;

namespace LocalApp
{
    public partial class FormChild报警 : PlcFormChild
	{
		public FormChild报警()
		{
			InitializeComponent();
		}

        private void FormChild报警_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
			for (int i = 0; i < 1000; i++)
			{
				HMI.GetAlarmStatus(0, out var haveErr, out var haveInfo, out bool infoAlarm);
			}

			for (int i = 0; i < 1000; i++)
			{
				var d = HMI.GetAlarmItems(-1);
				var list = (from o in d select o.alarmText).ToList();
			}
		}
    }
}
