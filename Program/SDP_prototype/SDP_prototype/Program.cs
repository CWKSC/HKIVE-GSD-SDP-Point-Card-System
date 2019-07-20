using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDP_prototype
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Player.PlayerPointCard_LuckyDraw());

            
            UserLogin userLogin;
            while (true)
            {
                userLogin = new UserLogin();
                userLogin.ShowDialog();
                if (userLogin.IsDisposed) return;

                switch (userLogin.user)
                {

                    case UserLogin.User.Player:
                        PlayerMenu playerMenu;
                        playerMenu = new PlayerMenu(userLogin.userAccountName, userLogin.userEmail, 
                            userLogin.isItSignUp, userLogin.useUserNameToLogin);
                        playerMenu.ShowDialog();
                        if (playerMenu.IsDisposed) return;
                        break;

                    case UserLogin.User.Staff:
                        StaffMenu staffManu = new StaffMenu(userLogin.userAccountName, userLogin.userEmail, 
                            userLogin.useUserNameToLogin);
                        staffManu.ShowDialog();
                        if (staffManu.IsDisposed) return;
                        break;

                    case UserLogin.User.CustomerServiceManager:
                        CSMMenu cSMManu = new CSMMenu(userLogin.userAccountName, userLogin.userEmail,
                            userLogin.useUserNameToLogin);
                        cSMManu.ShowDialog();
                        if (cSMManu.IsDisposed) return;
                        break;

                    default:
                        MessageBox.Show("Unexpect switch flow.");
                        break;
                }
            }

        }
    }
}
