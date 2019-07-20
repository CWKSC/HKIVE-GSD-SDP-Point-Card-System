using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDP_prototype.CSM
{
    public partial class CSMCreatePointCard : Form
    {
        public CSMCreatePointCard()
        {
            InitializeComponent();
        }

        #region it make Draggable
        // It use to make it draggable. //
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void CSMCreatePointCard_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(MdiParent.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        // It use to make it draggable. //
        #endregion



        public string CreatePassword(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }

        private void BtnQuantityEnter_Click(object sender, EventArgs e)
        {

            if(txtQuantity.Text == ""){
                MessageBox.Show("Quantity can not be empty.");return;
            }
            if(txtRetailValue.Text == ""){
                MessageBox.Show("Retail Value can not be empty");return;
            }

            int quantity;
            if (!int.TryParse(txtQuantity.Text, out quantity)) {
                MessageBox.Show("Quantity not a number.");return;
            }
            int retailValue;
            if (!int.TryParse(txtRetailValue.Text, out retailValue)){
                MessageBox.Show("Retail Value not a number.");return;
            }


            if(quantity < 0){
                MessageBox.Show("Quantity can not be negative");
                return;
            }
            if (retailValue < 0) {
                MessageBox.Show("RetailValue can not be negative");return;
            }


            if (quantity == 0){
                MessageBox.Show("Quantity can not be Zero"); return;
            }
            if (retailValue == 0){
                MessageBox.Show("RetailValue can not be Zero");return;
            }



            PointCardDataBaseControl.retailValue = retailValue;

            if(retailValue >= 200)
            {
                PointCardDataBaseControl.goldCoins = 800;
                PointCardDataBaseControl.remainLuckyDrawTimes = 2;
            }
            else if(retailValue >= 100)
            {
                PointCardDataBaseControl.goldCoins = 350;
                PointCardDataBaseControl.remainLuckyDrawTimes = 1;
            }
            else
            {
                PointCardDataBaseControl.goldCoins = 150;
                PointCardDataBaseControl.remainLuckyDrawTimes = 0;
            }

            PointCardDataBaseControl.status = "Inactive";
            PointCardDataBaseControl.generationDate = DateTime.Now.ToString("dd/MM/yyyy");

            for(int i = 0; i < quantity; i++)
            {
                PointCardDataBaseControl.pointCardID = "V" + (SystemDataBaseControl.Get_PointCardNum() + 1 + i).ToString().PadLeft(7, '0');
                PointCardDataBaseControl.activePwd = CreatePassword(8);
                PointCardDataBaseControl.Insert();
            }

            MessageBox.Show("Point Cards create success.");

            txtQuantity.Text = "";
            txtRetailValue.Text = "";

            MessageBox.Show("The Range of Point Card ID is " + "V" + (SystemDataBaseControl.Get_PointCardNum() + 1).ToString().PadLeft(7, '0') +
                " to " + "V" + (SystemDataBaseControl.Get_PointCardNum() + quantity).ToString().PadLeft(7, '0') );

            SystemDataBaseControl.Updata_PointCardNum(SystemDataBaseControl.Get_PointCardNum() + quantity);

        }
    }
}
