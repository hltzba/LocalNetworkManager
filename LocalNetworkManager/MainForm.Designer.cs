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
            this.components = new System.ComponentModel.Container();
            this.cmbNetworkAdapter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUseProgramme = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labNetCardName = new System.Windows.Forms.Label();
            this.dgvProgramme = new System.Windows.Forms.DataGridView();
            this.colProgrammeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIPAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubnetMask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDefaultGetway = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDefaultDNS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReserveDNS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEnableDHCP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.ProgrammeContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsiAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiDel = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgramme)).BeginInit();
            this.ProgrammeContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbNetworkAdapter
            // 
            this.cmbNetworkAdapter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNetworkAdapter.FormattingEnabled = true;
            this.cmbNetworkAdapter.Location = new System.Drawing.Point(135, 22);
            this.cmbNetworkAdapter.Name = "cmbNetworkAdapter";
            this.cmbNetworkAdapter.Size = new System.Drawing.Size(277, 24);
            this.cmbNetworkAdapter.TabIndex = 5;
            this.cmbNetworkAdapter.SelectedIndexChanged += new System.EventHandler(this.cmbNetworkAdapter_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "选择网络连接:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dgvProgramme);
            this.groupBox1.Controls.Add(this.labNetCardName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnUseProgramme);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbNetworkAdapter);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(605, 283);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "应用";
            // 
            // btnUseProgramme
            // 
            this.btnUseProgramme.Location = new System.Drawing.Point(252, 235);
            this.btnUseProgramme.Name = "btnUseProgramme";
            this.btnUseProgramme.Size = new System.Drawing.Size(99, 33);
            this.btnUseProgramme.TabIndex = 8;
            this.btnUseProgramme.Text = "应用方案";
            this.btnUseProgramme.UseVisualStyleBackColor = true;
            this.btnUseProgramme.Click += new System.EventHandler(this.btnUseProgramme_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "所属网卡：";
            // 
            // labNetCardName
            // 
            this.labNetCardName.AutoSize = true;
            this.labNetCardName.Location = new System.Drawing.Point(135, 53);
            this.labNetCardName.Name = "labNetCardName";
            this.labNetCardName.Size = new System.Drawing.Size(72, 16);
            this.labNetCardName.TabIndex = 10;
            this.labNetCardName.Text = "未知网卡";
            // 
            // dgvProgramme
            // 
            this.dgvProgramme.AllowUserToAddRows = false;
            this.dgvProgramme.AllowUserToDeleteRows = false;
            this.dgvProgramme.AllowUserToOrderColumns = true;
            this.dgvProgramme.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProgramme.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvProgramme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProgramme.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProgrammeName,
            this.colIPAddress,
            this.colSubnetMask,
            this.colDefaultGetway,
            this.colDefaultDNS,
            this.colReserveDNS,
            this.colEnableDHCP});
            this.dgvProgramme.ContextMenuStrip = this.ProgrammeContextMenuStrip;
            this.dgvProgramme.Location = new System.Drawing.Point(12, 101);
            this.dgvProgramme.Name = "dgvProgramme";
            this.dgvProgramme.ReadOnly = true;
            this.dgvProgramme.RowTemplate.Height = 23;
            this.dgvProgramme.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProgramme.Size = new System.Drawing.Size(581, 118);
            this.dgvProgramme.TabIndex = 11;
            this.dgvProgramme.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvProgramme_CellFormatting);
            // 
            // colProgrammeName
            // 
            this.colProgrammeName.DataPropertyName = "ProgrammeName";
            this.colProgrammeName.HeaderText = "方案名称";
            this.colProgrammeName.Name = "colProgrammeName";
            this.colProgrammeName.ReadOnly = true;
            this.colProgrammeName.Width = 97;
            // 
            // colIPAddress
            // 
            this.colIPAddress.DataPropertyName = "IPAddress";
            this.colIPAddress.HeaderText = "IP地址";
            this.colIPAddress.Name = "colIPAddress";
            this.colIPAddress.ReadOnly = true;
            this.colIPAddress.Width = 81;
            // 
            // colSubnetMask
            // 
            this.colSubnetMask.DataPropertyName = "SubnetMask";
            this.colSubnetMask.HeaderText = "子网掩码";
            this.colSubnetMask.Name = "colSubnetMask";
            this.colSubnetMask.ReadOnly = true;
            this.colSubnetMask.Width = 97;
            // 
            // colDefaultGetway
            // 
            this.colDefaultGetway.DataPropertyName = "DefaultGetway";
            this.colDefaultGetway.HeaderText = "默认网关";
            this.colDefaultGetway.Name = "colDefaultGetway";
            this.colDefaultGetway.ReadOnly = true;
            this.colDefaultGetway.Width = 97;
            // 
            // colDefaultDNS
            // 
            this.colDefaultDNS.DataPropertyName = "DefaultDNS";
            this.colDefaultDNS.HeaderText = "首选DNS";
            this.colDefaultDNS.Name = "colDefaultDNS";
            this.colDefaultDNS.ReadOnly = true;
            this.colDefaultDNS.Width = 89;
            // 
            // colReserveDNS
            // 
            this.colReserveDNS.DataPropertyName = "ReserveDNS";
            this.colReserveDNS.HeaderText = "备用DNS";
            this.colReserveDNS.Name = "colReserveDNS";
            this.colReserveDNS.ReadOnly = true;
            this.colReserveDNS.Width = 89;
            // 
            // colEnableDHCP
            // 
            this.colEnableDHCP.DataPropertyName = "EnableDHCP";
            this.colEnableDHCP.HeaderText = "自动获取";
            this.colEnableDHCP.Name = "colEnableDHCP";
            this.colEnableDHCP.ReadOnly = true;
            this.colEnableDHCP.Width = 97;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "选择应用方案：";
            // 
            // ProgrammeContextMenuStrip
            // 
            this.ProgrammeContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiAdd,
            this.tsiEdit,
            this.tsiDel});
            this.ProgrammeContextMenuStrip.Name = "ProgrammeContextMenuStrip";
            this.ProgrammeContextMenuStrip.Size = new System.Drawing.Size(125, 70);
            this.ProgrammeContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.ProgrammeContextMenuStrip_Opening);
            this.ProgrammeContextMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ProgrammeContextMenuStrip_ItemClicked);
            // 
            // tsiAdd
            // 
            this.tsiAdd.Name = "tsiAdd";
            this.tsiAdd.Size = new System.Drawing.Size(124, 22);
            this.tsiAdd.Text = "新增方案";
            // 
            // tsiEdit
            // 
            this.tsiEdit.Name = "tsiEdit";
            this.tsiEdit.Size = new System.Drawing.Size(124, 22);
            this.tsiEdit.Text = "编辑方案";
            // 
            // tsiDel
            // 
            this.tsiDel.Name = "tsiDel";
            this.tsiDel.Size = new System.Drawing.Size(124, 22);
            this.tsiDel.Text = "删除方案";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 293);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "本地网络配置管理";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgramme)).EndInit();
            this.ProgrammeContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbNetworkAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUseProgramme;
        private System.Windows.Forms.Label labNetCardName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvProgramme;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProgrammeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIPAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubnetMask;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDefaultGetway;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDefaultDNS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReserveDNS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEnableDHCP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip ProgrammeContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsiAdd;
        private System.Windows.Forms.ToolStripMenuItem tsiEdit;
        private System.Windows.Forms.ToolStripMenuItem tsiDel;

    }
}

