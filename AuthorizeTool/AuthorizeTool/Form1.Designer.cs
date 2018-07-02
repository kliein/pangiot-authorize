namespace AuthorizeTool
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAuthorize = new System.Windows.Forms.Label();
            this.btnGet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAuthorize
            // 
            this.lblAuthorize.AutoSize = true;
            this.lblAuthorize.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAuthorize.Location = new System.Drawing.Point(39, 28);
            this.lblAuthorize.Name = "lblAuthorize";
            this.lblAuthorize.Size = new System.Drawing.Size(50, 17);
            this.lblAuthorize.TabIndex = 0;
            this.lblAuthorize.Text = "000000";
            // 
            // btnGet
            // 
            this.btnGet.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGet.Location = new System.Drawing.Point(134, 21);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(94, 31);
            this.btnGet.TabIndex = 1;
            this.btnGet.Text = "获取授权码";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 87);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.lblAuthorize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.ShowIcon = false;
            this.Text = "授权码获取工具";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAuthorize;
        private System.Windows.Forms.Button btnGet;
    }
}

