namespace Socket_Client {
    partial class Form1 {
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
            if(disposing && (components != null))
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
            this.btnEnd = new System.Windows.Forms.Button();
            this.blueBtn = new System.Windows.Forms.Button();
            this.yellowBtn = new System.Windows.Forms.Button();
            this.redBtn = new System.Windows.Forms.Button();
            this.greenBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(501, 83);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(75, 23);
            this.btnEnd.TabIndex = 0;
            this.btnEnd.Text = "終了";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // blueBtn
            // 
            this.blueBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.blueBtn.Location = new System.Drawing.Point(160, 172);
            this.blueBtn.Name = "blueBtn";
            this.blueBtn.Size = new System.Drawing.Size(126, 53);
            this.blueBtn.TabIndex = 1;
            this.blueBtn.UseVisualStyleBackColor = false;
            this.blueBtn.Click += new System.EventHandler(this.blueBtn_Click);
            // 
            // yellowBtn
            // 
            this.yellowBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.yellowBtn.Location = new System.Drawing.Point(381, 300);
            this.yellowBtn.Name = "yellowBtn";
            this.yellowBtn.Size = new System.Drawing.Size(126, 53);
            this.yellowBtn.TabIndex = 2;
            this.yellowBtn.UseVisualStyleBackColor = false;
            this.yellowBtn.Click += new System.EventHandler(this.yellowBtn_Click);
            // 
            // redBtn
            // 
            this.redBtn.BackColor = System.Drawing.Color.Red;
            this.redBtn.Location = new System.Drawing.Point(381, 172);
            this.redBtn.Name = "redBtn";
            this.redBtn.Size = new System.Drawing.Size(126, 53);
            this.redBtn.TabIndex = 3;
            this.redBtn.UseVisualStyleBackColor = false;
            this.redBtn.Click += new System.EventHandler(this.redBtn_Click);
            // 
            // greenBtn
            // 
            this.greenBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.greenBtn.Location = new System.Drawing.Point(160, 300);
            this.greenBtn.Name = "greenBtn";
            this.greenBtn.Size = new System.Drawing.Size(126, 53);
            this.greenBtn.TabIndex = 4;
            this.greenBtn.UseVisualStyleBackColor = false;
            this.greenBtn.Click += new System.EventHandler(this.greenBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.greenBtn);
            this.Controls.Add(this.redBtn);
            this.Controls.Add(this.yellowBtn);
            this.Controls.Add(this.blueBtn);
            this.Controls.Add(this.btnEnd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button blueBtn;
        private System.Windows.Forms.Button yellowBtn;
        private System.Windows.Forms.Button redBtn;
        private System.Windows.Forms.Button greenBtn;
    }
}

