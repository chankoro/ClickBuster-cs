namespace ClickBuster_cs
{
    partial class F_Menu
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.B_Syokyu = new System.Windows.Forms.Button();
            this.B_Chukyu = new System.Windows.Forms.Button();
            this.B_jyokyu = new System.Windows.Forms.Button();
            this.B_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // B_Syokyu
            // 
            this.B_Syokyu.Location = new System.Drawing.Point(12, 12);
            this.B_Syokyu.Name = "B_Syokyu";
            this.B_Syokyu.Size = new System.Drawing.Size(260, 74);
            this.B_Syokyu.TabIndex = 0;
            this.B_Syokyu.Text = "初級";
            this.B_Syokyu.UseVisualStyleBackColor = true;
            this.B_Syokyu.Click += new System.EventHandler(this.B_Syokyu_Click);
            // 
            // B_Chukyu
            // 
            this.B_Chukyu.Location = new System.Drawing.Point(12, 92);
            this.B_Chukyu.Name = "B_Chukyu";
            this.B_Chukyu.Size = new System.Drawing.Size(260, 74);
            this.B_Chukyu.TabIndex = 1;
            this.B_Chukyu.Text = "中級";
            this.B_Chukyu.UseVisualStyleBackColor = true;
            // 
            // B_jyokyu
            // 
            this.B_jyokyu.Location = new System.Drawing.Point(12, 172);
            this.B_jyokyu.Name = "B_jyokyu";
            this.B_jyokyu.Size = new System.Drawing.Size(260, 74);
            this.B_jyokyu.TabIndex = 2;
            this.B_jyokyu.Text = "上級";
            this.B_jyokyu.UseVisualStyleBackColor = true;
            // 
            // B_Close
            // 
            this.B_Close.Location = new System.Drawing.Point(12, 275);
            this.B_Close.Name = "B_Close";
            this.B_Close.Size = new System.Drawing.Size(260, 74);
            this.B_Close.TabIndex = 3;
            this.B_Close.Text = "終了";
            this.B_Close.UseVisualStyleBackColor = true;
            this.B_Close.Click += new System.EventHandler(this.B_Close_Click);
            // 
            // F_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.B_Close);
            this.Controls.Add(this.B_jyokyu);
            this.Controls.Add(this.B_Chukyu);
            this.Controls.Add(this.B_Syokyu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "F_Menu";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClickBuster";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button B_Syokyu;
        private System.Windows.Forms.Button B_Chukyu;
        private System.Windows.Forms.Button B_jyokyu;
        private System.Windows.Forms.Button B_Close;
    }
}

