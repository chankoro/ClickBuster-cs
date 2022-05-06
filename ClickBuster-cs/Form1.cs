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

        /// <summary>
        /// 初級ボタンクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void B_Syokyu_Click(object sender, EventArgs e)
        {
            F_Main fMain = new F_Main
            {
                // フォームの高さ
                Height = 400,
                // フォームの幅
                Width = 400,
                // 敵の動く速度
                EnmTim = 1000,
                // 敵の数
                Enms = 20,
                // 制限時間
                GmTim = 10000
            };

            // 難易度初期化
            fMain.FrmIni();

            fMain.Show(this);
            Hide();
        }

        /// <summary>
        /// 中級ボタンクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void B_Chukyu_Click(object sender, EventArgs e)
        {
            F_Main fMain = new F_Main
            {
                // フォームの高さ
                Height = 500,
                // フォームの幅
                Width = 700,
                // 敵の動く速度
                EnmTim = 800,
                // 敵の数
                Enms = 30,
                // 制限時間
                GmTim = 15000
            };

            // 難易度初期化
            fMain.FrmIni();

            // thisを指定することにより、子フォームに親フォームを設定
            fMain.Show(this);
            Hide();
        }

        /// <summary>
        /// 上級ボタンクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void B_Jyoukyu_Click(object sender, EventArgs e)
        {
            F_Main fMain = new F_Main
            {
                // フォームの高さ
                Height = 600,
                // フォームの幅
                Width = 800,
                // 敵の動く速度
                EnmTim = 300,
                // 敵の数
                Enms = 40,
                // 制限時間
                GmTim = 20000
            };

            // 難易度初期化
            fMain.FrmIni();

            // thisを指定することにより、子フォームに親フォームを設定
            fMain.Show(this);
            Hide();
        }
    }
}
