namespace wechat
{
    partial class wechats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wechats));
            this.btn_qd = new System.Windows.Forms.Button();
            this.txt_path = new System.Windows.Forms.TextBox();
            this.cbox_num = new System.Windows.Forms.ComboBox();
            this.label_tips = new System.Windows.Forms.Label();
            this.eventLog1 = new System.Diagnostics.EventLog();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_qd
            // 
            this.btn_qd.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_qd.Location = new System.Drawing.Point(58, 80);
            this.btn_qd.Name = "btn_qd";
            this.btn_qd.Size = new System.Drawing.Size(100, 29);
            this.btn_qd.TabIndex = 0;
            this.btn_qd.Text = "启动";
            this.btn_qd.UseVisualStyleBackColor = true;
            this.btn_qd.Click += new System.EventHandler(this.btn_qd_Click);
            // 
            // txt_path
            // 
            this.txt_path.BackColor = System.Drawing.Color.White;
            this.txt_path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_path.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_path.Location = new System.Drawing.Point(10, 50);
            this.txt_path.Name = "txt_path";
            this.txt_path.Size = new System.Drawing.Size(194, 21);
            this.txt_path.TabIndex = 1;
            this.txt_path.DoubleClick += new System.EventHandler(this.txt_path_DoubleClick);
            // 
            // cbox_num
            // 
            this.cbox_num.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_num.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbox_num.FormattingEnabled = true;
            this.cbox_num.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cbox_num.Location = new System.Drawing.Point(126, 19);
            this.cbox_num.Name = "cbox_num";
            this.cbox_num.Size = new System.Drawing.Size(47, 20);
            this.cbox_num.TabIndex = 4;
            // 
            // label_tips
            // 
            this.label_tips.AutoSize = true;
            this.label_tips.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_tips.Location = new System.Drawing.Point(43, 22);
            this.label_tips.Name = "label_tips";
            this.label_tips.Size = new System.Drawing.Size(77, 12);
            this.label_tips.TabIndex = 5;
            this.label_tips.Text = "打开的个数:";
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // wechat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(216, 123);
            this.Controls.Add(this.label_tips);
            this.Controls.Add(this.cbox_num);
            this.Controls.Add(this.txt_path);
            this.Controls.Add(this.btn_qd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wechat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "微信多开";
            this.Load += new System.EventHandler(this.Wechat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_qd;
        private System.Windows.Forms.TextBox txt_path;
        private System.Windows.Forms.ComboBox cbox_num;
        private System.Windows.Forms.Label label_tips;
        private System.Diagnostics.EventLog eventLog1;
    }
}

