namespace HostEdit
{
    partial class HostMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HostMain));
            this.btnZhiruo = new System.Windows.Forms.Button();
            this.btnDodox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnZhiruo
            // 
            this.btnZhiruo.BackColor = System.Drawing.SystemColors.Control;
            this.btnZhiruo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnZhiruo.ForeColor = System.Drawing.Color.DarkRed;
            this.btnZhiruo.Location = new System.Drawing.Point(57, 101);
            this.btnZhiruo.Name = "btnZhiruo";
            this.btnZhiruo.Size = new System.Drawing.Size(125, 33);
            this.btnZhiruo.TabIndex = 0;
            this.btnZhiruo.Text = "Host到芷若";
            this.btnZhiruo.UseVisualStyleBackColor = false;
            this.btnZhiruo.Click += new System.EventHandler(this.btnZhiruo_Click);
            // 
            // btnDodox
            // 
            this.btnDodox.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDodox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnDodox.Location = new System.Drawing.Point(57, 164);
            this.btnDodox.Name = "btnDodox";
            this.btnDodox.Size = new System.Drawing.Size(125, 32);
            this.btnDodox.TabIndex = 1;
            this.btnDodox.Text = "Host到DoDox";
            this.btnDodox.UseVisualStyleBackColor = true;
            this.btnDodox.Click += new System.EventHandler(this.btnDodox_Click);
            // 
            // HostMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HostEdit.Properties.Resources.zhiruo;
            this.ClientSize = new System.Drawing.Size(259, 309);
            this.Controls.Add(this.btnDodox);
            this.Controls.Add(this.btnZhiruo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HostMain";
            this.Text = "Host Update";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnZhiruo;
        private System.Windows.Forms.Button btnDodox;
    }
}

