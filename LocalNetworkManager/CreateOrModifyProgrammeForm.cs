using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocalNetworkManager
{
    public partial class CreateOrModifyProgrammeForm : Form
    {
        public CreateOrModifyProgrammeForm()
        {
            InitializeComponent();
        }

        private bool CheckValue()
        {
            if (string.IsNullOrEmpty(txtProgrammeName.Text))
            {
                MessageBox.Show("方案名不可为空");
                return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}