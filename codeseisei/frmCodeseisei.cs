using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace codeseisei
{
    public partial class frmCodeseisei : Form
    {
        public frmCodeseisei()
        {
            InitializeComponent();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            string moto = txtBase.Text;
            string mark = txtReplace.Text;

            var items = txtBefore.Text.Replace("\r", "").Split('\n');
            StringBuilder sb = new StringBuilder();
            foreach (var item in items)
            {
                if (!string.IsNullOrEmpty(item)) sb.AppendLine(moto.Replace(mark, item));
            }
            txtAfter.Text = sb.ToString();
            txtAfter.SelectAll();
        }

        private void btnLeftDel_Click(object sender, EventArgs e)
        {
            txtBefore.Clear();
        }

        private void btnRightDel_Click(object sender, EventArgs e)
        {
            txtAfter.Clear();
        }

        private void btnColToRow_Click(object sender, EventArgs e)
        {
            txtBefore.Text = txtBefore.Text.Replace(",", "\r\n");
        }
    }
}
