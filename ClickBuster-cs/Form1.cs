using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickBuster_cs
{
    public partial class F_Menu : Form
    {
        public F_Menu()
        {
            InitializeComponent();
        }

        private void B_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void B_Syokyu_Click(object sender, EventArgs e)
        {
            // メイン画面の表示
            F_Main fMain = new F_Main();
            fMain.Show(this);
            // メニュー画面を隠す
            Hide();
        }
    }
}
