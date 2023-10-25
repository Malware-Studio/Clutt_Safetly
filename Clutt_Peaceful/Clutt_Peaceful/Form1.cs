using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clutt_Peaceful
{
    public partial class Virus : Form
    {
        public Virus()
        {
            InitializeComponent();
            this.TransparencyKey = this.BackColor;
            TopMost = true;
        }

        private void Virus_Load(object sender, EventArgs e)
        {
            if (MessageBox.Show("你即將運行一個安全版本的Clutt,請注意它雖然沒有任何破壞力,不過它包含閃光和音效,如果你有光刺激會引發癲癇症的情況,請勿嘗試!.如果你願意承擔後果,請按{是}來運行. Github:Malware-Studio", "Clutt警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                this.Close();
                Application.Exit();
            }
            else
            {
                Last_Warning();
            }
        }
        public void Last_Warning()
        {
            if (MessageBox.Show("最後警告!你真的確定要運行嗎?", "最後的警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                this.Close();
                Application.Exit();
            }
            else
            {
                go_to_payload();
            }
        }

        public void go_to_payload()
        {
            this.Hide();
            var NewForm = new gdi();
            NewForm.ShowDialog();
            this.Close();
        }
    }
}
