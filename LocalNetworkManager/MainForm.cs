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
            List<NetworkAdapterInfo> adapterInfos = NetworkSetting.GetLocalNetworkAdapters();
            cmbNetworkAdapter.DataSource = adapterInfos;
            cmbNetworkAdapter.DisplayMember = "NetConnectionID";
            cmbNetworkAdapter.ValueMember = "NetConnectionID";
        }

        public void InitNetworkInfoDatas()
        {
            XDocument xdoc = XDocument.Load("NetWorkInfoDatas.xml");
        }
    }
}