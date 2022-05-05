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
                // 敵のクリックイベント
                ((CEnemy)_enemies[i]).OnClick += new EventHandler(EnmOnClick);
                // ループの中でDoEventsを呼んでおく
                Application.DoEvents();
            }
            // タイマーのスタート
            T_Enemy.Enabled = true;
            T_Jikan.Enabled = true;
        }

        /// <summary>
        /// 敵を動かす
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void T_Enemy_Tick(object sender, EventArgs e)
        {
            // 敵の数だけループする
            for(int i = 0; i <= _enemies.Count - 1; i++)
            {
                // 敵の移動イベントを呼ぶ
                ((CEnemy)_enemies[i]).MvEnm();
                // ループの中でDoEventsを呼んでおく
                Application.DoEvents();
            }
        }

        /// <summary>
        /// 残り時間を計測
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void T_jikan_Tick(object sender, EventArgs e)
        {
            if ((PG_Jikan.Minimum) <= (PG_Jikan.Value - 1))
            {
                // プログレスバーを一つ下げる
                PG_Jikan.Value--;
            }
            else
            {
                // 終わり
                PG_Jikan.Value = PG_Jikan.Minimum;
                // タイマーを止める
                T_Enemy.Enabled = false;
                T_Jikan.Enabled = false;
                // メッセージを表示
                MessageBox.Show("終了です＼nあなたの得点は" + L_Sum.Text + "です");
                // メイン画面を閉じる
                Close();
            }
        }

        /// <summary>
        /// 敵クリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnmOnClick(object sender, EventArgs e)
        {
            // 得点の加算(それぞれの敵の得点を取得する。)
            L_Sum.Text = (Int32.Parse(L_Sum.Text) + ((CEnemy)sender).GetTokuten()).ToString();
            // 敵を倒したイベント(再度敵を出現させる)
            ((CEnemy)sender).EnemyDown();
        }
    }
}
