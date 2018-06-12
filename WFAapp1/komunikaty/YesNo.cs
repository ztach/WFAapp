using System;
using System.Windows.Forms;

namespace WFAapp1.komunikaty
{
    public partial class YesNo : UserControl
    {
        public YesNo()
        {
            InitializeComponent();
        }
        public bool yesno;

        private void btnYes_Click(object sender, EventArgs e)
        {
            yesno = true;
        }

        private void bbtnNo_Click(object sender, EventArgs e)
        {
            yesno = false;
        }
    }
}
