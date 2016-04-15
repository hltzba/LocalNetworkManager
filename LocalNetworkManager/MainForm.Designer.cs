namespace LocalNetworkManager
{
    partial class MainForm
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpManagament = new System.Windows.Forms.TabPage();
            this.tpSetting = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbNetworkAdapter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSettingInfo = new System.Windows.Forms.ComboBox();
            this.tcMain.SuspendLayout();
            this.tpManagament.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpManagament);
            this.tcMain.Controls.Add(this.tpSetting);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.HotTrack = true;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(605, 356);
            this.tcMain.TabIndex = 0;
            // 
            // tpManagament
            // 
            this.tpManagament.Controls.Add(this.cmbSettingInfo);
            this.tpManagament.Controls.Add(this.label2);
            this.tpManagament.Controls.Add(this.cmbNetworkAdapter);
            this.tpManagament.Controls.Add(this.label1);
            this.tpManagament.Location = new System.Drawing.Point(4, 26);
            this.tpManagament.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpManagament.Name = "tpManagament";
            this.tpManagament.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpManagament.Size = new System.Drawing.Size(597, 326);
            this.tpManagament.TabIndex = 0;
            this.tpManagament.Text = "管理";
            this.tpManagament.UseVisualStyleBackColor = true;
            // 
            // tpSetting
            // 
            this.tpSetting.Location = new System.Drawing.Point(4, 22);
            this.tpSetting.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpSetting.Name = "tpSetting";
            this.tpSetting.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpSetting.Size = new System.Drawing.Size(759, 493);
            this.tpSetting.TabIndex = 1;
            this.tpSetting.Text = "配置";
            this.tpSetting.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "选择网络连接:";
            // 
            // cmbNetworkAdapter
            // 
            this.cmbNetworkAdapter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNetworkAdapter.FormattingEnabled = true;
            this.cmbNetworkAdapter.Location = new System.Drawing.Point(131, 26);
            this.cmbNetworkAdapter.Name = "cmbNetworkAdapter";
            this.cmbNetworkAdapter.Size = new System.Drawing.Size(277, 24);
            this.cmbNetworkAdapter.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "应用方案：";
            // 
            // cmbSettingInfo
            // 
            this.cmbSettingInfo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSettingInfo.FormattingEnabled = true;
            this.cmbSettingInfo.Location = new System.Drawing.Point(130, 75);
            this.cmbSettingInfo.Name = "cmbSettingInfo";
            this.cmbSettingInfo.Size = new System.Drawing.Size(278, 24);
            this.cmbSettingInfo.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 356);
            this.Controls.Add(this.tcMain);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "本地网络配置管理";
            this.tcMain.ResumeLayout(false);
            this.tpManagament.ResumeLayout(false);
            this.tpManagament.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpManagament;
        private System.Windows.Forms.ComboBox cmbNetworkAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tpSetting;
        private System.Windows.Forms.ComboBox cmbSettingInfo;
        private System.Windows.Forms.Label label2;
    }
}

