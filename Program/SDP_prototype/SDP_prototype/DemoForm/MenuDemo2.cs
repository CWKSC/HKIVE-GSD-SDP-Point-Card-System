using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDP_prototype
{
    public partial class MenuDemo2 : Form
    {
        public MenuDemo2()
        {
            InitializeComponent();
        }

        
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }
        

        private void PlayerMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void EnquireGameDetail_Click(object sender, EventArgs e)
        {

        }

        private void ViewGamePromotion_Click(object sender, EventArgs e)
        {

        }

        private void EnquirePlayerInformation_Click(object sender, EventArgs e)
        {

        }

        private void TopUpBalanceByPointCard_Click(object sender, EventArgs e)
        {

        }
    }
}
