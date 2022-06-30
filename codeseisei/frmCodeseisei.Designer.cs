namespace codeseisei
{
    partial class frmCodeseisei
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
            this.txtBase = new System.Windows.Forms.TextBox();
            this.txtBefore = new System.Windows.Forms.TextBox();
            this.txtAfter = new System.Windows.Forms.TextBox();
            this.txtReplace = new System.Windows.Forms.TextBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.btnLeftDel = new System.Windows.Forms.Button();
            this.btnRightDel = new System.Windows.Forms.Button();
            this.btnColToRow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBase
            // 
            this.txtBase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBase.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtBase.Location = new System.Drawing.Point(21, 41);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(659, 20);
            this.txtBase.TabIndex = 0;
            // 
            // txtBefore
            // 
            this.txtBefore.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBefore.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtBefore.Location = new System.Drawing.Point(12, 124);
            this.txtBefore.Multiline = true;
            this.txtBefore.Name = "txtBefore";
            this.txtBefore.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBefore.Size = new System.Drawing.Size(378, 314);
            this.txtBefore.TabIndex = 1;
            // 
            // txtAfter
            // 
            this.txtAfter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAfter.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtAfter.Location = new System.Drawing.Point(410, 124);
            this.txtAfter.Multiline = true;
            this.txtAfter.Name = "txtAfter";
            this.txtAfter.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAfter.Size = new System.Drawing.Size(378, 314);
            this.txtAfter.TabIndex = 2;
            // 
            // txtReplace
            // 
            this.txtReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReplace.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtReplace.Location = new System.Drawing.Point(723, 41);
            this.txtReplace.Name = "txtReplace";
            this.txtReplace.Size = new System.Drawing.Size(65, 20);
            this.txtReplace.TabIndex = 3;
            this.txtReplace.Text = "\\";
            // 
            // btnExecute
            // 
            this.btnExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExecute.Location = new System.Drawing.Point(711, 78);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(77, 24);
            this.btnExecute.TabIndex = 4;
            this.btnExecute.Text = "実行";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // btnLeftDel
            // 
            this.btnLeftDel.Location = new System.Drawing.Point(12, 78);
            this.btnLeftDel.Name = "btnLeftDel";
            this.btnLeftDel.Size = new System.Drawing.Size(77, 24);
            this.btnLeftDel.TabIndex = 5;
            this.btnLeftDel.Text = "左削除";
            this.btnLeftDel.UseVisualStyleBackColor = true;
            this.btnLeftDel.Click += new System.EventHandler(this.btnLeftDel_Click);
            // 
            // btnRightDel
            // 
            this.btnRightDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRightDel.Location = new System.Drawing.Point(410, 78);
            this.btnRightDel.Name = "btnRightDel";
            this.btnRightDel.Size = new System.Drawing.Size(77, 24);
            this.btnRightDel.TabIndex = 6;
            this.btnRightDel.Text = "右削除";
            this.btnRightDel.UseVisualStyleBackColor = true;
            this.btnRightDel.Click += new System.EventHandler(this.btnRightDel_Click);
            // 
            // btnColToRow
            // 
            this.btnColToRow.Location = new System.Drawing.Point(130, 12);
            this.btnColToRow.Name = "btnColToRow";
            this.btnColToRow.Size = new System.Drawing.Size(77, 24);
            this.btnColToRow.TabIndex = 7;
            this.btnColToRow.Text = "列変換";
            this.btnColToRow.UseVisualStyleBackColor = true;
            this.btnColToRow.Click += new System.EventHandler(this.btnColToRow_Click);
            // 
            // frmCodeseisei
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnColToRow);
            this.Controls.Add(this.btnRightDel);
            this.Controls.Add(this.btnLeftDel);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.txtReplace);
            this.Controls.Add(this.txtAfter);
            this.Controls.Add(this.txtBefore);
            this.Controls.Add(this.txtBase);
            this.Name = "frmCodeseisei";
            this.Text = "codeseisei";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.TextBox txtBefore;
        private System.Windows.Forms.TextBox txtAfter;
        private System.Windows.Forms.TextBox txtReplace;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Button btnLeftDel;
        private System.Windows.Forms.Button btnRightDel;
        private System.Windows.Forms.Button btnColToRow;
    }
}

