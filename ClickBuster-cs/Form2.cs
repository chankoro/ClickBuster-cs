using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ClickBuster_cs
{
    public partial class F_Main : Form
    {
        // ランダム変数
        private Random _rnd = new Random();

        // 複数の敵を格納する変数
        private ArrayList _enemies = new ArrayList();
        public F_Main()
        {
            InitializeComponent();
        }

        private void F_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            // メニュー画面の表示
            Owner.Show();
        }

        /// <summary>
        /// スタートボタンクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void B_Start_Click(object sender, EventArgs e)
        {
            // スタートボタンを使えなくする
            B_Start.Enabled = false;

            // 敵を作る
            for(int i = 0; i <= 9; i++)
            {
                // 配列時に敵classを生成。その際にオーナーのパネルとランダム変数を渡しす。
                _enemies.Add(new CEnemy(P_Enemy, _rnd));
                // ループの中でDoEventsを呼んでおく
                Application.DoEvents();
            }
        }
    }
}
