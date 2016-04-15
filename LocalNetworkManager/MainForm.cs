using DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Util;

namespace LocalNetworkManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.system_network;
            dgvProgramme.AutoGenerateColumns = false;
            List<NetworkAdapterInfo> adapterInfos = NetworkSetting.GetLocalNetworkAdapters();
            cmbNetworkAdapter.DataSource = adapterInfos;
            cmbNetworkAdapter.DisplayMember = "NetConnectionID";
            cmbNetworkAdapter.ValueMember = "NetConnectionID";
            InitNetworkInfoDatas();
        }

        public void InitNetworkInfoDatas()
        {
            try
            {
                XDocument xdoc = XDocument.Load("NetWorkInfoDatas.xml");
                XElement[] root = XDocument.Parse(xdoc.ToString().Trim().Replace(" ", "").Replace("\r\n", "")).Element("Datas").Elements().ToArray();
                foreach (XElement element in root)
                {
                    InterV4NetworkInfo info = XML2Entity.GetEntityFromXElement<InterV4NetworkInfo>(element);
                    Program.ProgrammeCache.Add(info);
                }

                dgvProgramme.DataSource = Program.ProgrammeCache;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUseProgramme_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbNetworkAdapter.SelectedItem == null)
                {
                    MessageBox.Show("未能找到有效的网络连接");
                    return;
                }
                NetworkAdapterInfo adapter = cmbNetworkAdapter.SelectedItem as NetworkAdapterInfo;
                if (Program.ProgrammeCache == null || Program.ProgrammeCache.Count == 0)
                {
                    MessageBox.Show("未能找到有效的应用方案");
                    return;
                }
                //if (cmbSettingInfo.SelectedItem == null)
                //{
                //    MessageBox.Show("请选择一个要使用的方案");
                //    return;
                //}
                if (dgvProgramme.Rows.Count <= 0 || dgvProgramme.SelectedRows.Count <= 0)
                {
                    MessageBox.Show("请选择一个要使用的方案");
                }
                InterV4NetworkInfo info = dgvProgramme.SelectedRows[0].DataBoundItem as InterV4NetworkInfo;
                //InterV4NetworkInfo info = cmbSettingInfo.SelectedItem as InterV4NetworkInfo;
                if (info.EnableDHCP == 1)
                {
                    NetworkSetting.EnableDHCP();
                    return;
                }
                List<string> dns = new List<string>();
                if (!string.IsNullOrEmpty(info.DefaultDNS))
                {
                    dns.Add(info.DefaultDNS);
                }
                if (!string.IsNullOrEmpty(info.ReserveDNS))
                {
                    dns.Add(info.ReserveDNS);
                }
                NetworkSetting.SetIPAddress(adapter.Caption, info.IPAddress, info.SubnetMask, info.DefaultGetway);

                if (dns != null && dns.Count > 0)
                {
                    NetworkSetting.SetDNS(adapter.Caption, dns.ToArray());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("应用方案时发生错误：" + ex.Message);
            }
        }

        private void cmbNetworkAdapter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNetworkAdapter.SelectedItem == null)
            {
                labNetCardName.Text = "未知网卡";
                return;
            }

            NetworkAdapterInfo info = cmbNetworkAdapter.SelectedItem as NetworkAdapterInfo;
            labNetCardName.Text = info.Description;
        }

        private void dgvProgramme_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                switch (dgvProgramme.Columns[e.ColumnIndex].Name)
                {
                    case "colEnableDHCP":
                        {
                            string displayname = e.Value.ToString();
                            if (e.Value.ToString() == "1")
                            {
                                displayname = "开启";
                            }
                            else if (e.Value.ToString() == "2")
                            {
                                displayname = "关闭";
                            }
                            e.Value = displayname;
                        } break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ProgrammeContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            if (dgvProgramme.SelectedRows.Count <= 0)
            {
                tsiEdit.Visible = false;
                tsiDel.Visible = false;
            }
            else
            {
                tsiEdit.Visible = true;
                tsiDel.Visible = true;
            }
        }

        private void ProgrammeContextMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "tsiAdd":
                    { } break;
                case "tsiEdit":
                    { } break;
                case "tsiDel":
                    { } break;
            }
        }
    }
}