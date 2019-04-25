using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeAnHQTCSDL_qlthuvien
{
    public partial class FormMain : Form
    {
        public static int ghichu = 0;
        public FormMain()
        {
            InitializeComponent();
        }
        UserControlQLNhanVien userCtlQLNhanVien = new UserControlQLNhanVien();
        private void MouseDetect_Tick(object sender, EventArgs e)
        {
            if (panelMainMenu.ClientRectangle.Contains(PointToClient(Control.MousePosition)))
            {
                panelMainMenu.Width = 267;
                pictureBox1.Width = 70;
                pictureBox1.Height = 80;
                pictureBox1.Location = new Point(95,20);
            }
            else
            {
                panelMainMenu.Width = 39;
                pictureBox1.Width = 40;
                pictureBox1.Height = 50;
                pictureBox1.Location = new Point(1,32);
            }
            if (ghichu == 11)
            {
                panelExMid.Controls.Clear();
                panelExMid.Controls.Add(userCtlQLNhanVien);
                ghichu = 0;
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
       
        }
        UserControlQTHT userCtlQTHT = new UserControlQTHT();
        private void BtnQuanTriHeThong_Click(object sender, EventArgs e)
        {
            this.panelExMain.Controls.Clear();
            this.panelExMain.Controls.Add(userCtlQTHT); 
            

        }
        UserControlQLNV userCtlQLNV = new UserControlQLNV();
        private void BtnQuanLyNghiepVu_Click(object sender, EventArgs e)
        {
            this.panelExMain.Controls.Clear();
            this.panelExMain.Controls.Add(userCtlQLNV);
        }
        UserControlDangXuat userCtlDangXuat = new UserControlDangXuat();
        private void BtnDangXuat_Click(object sender, EventArgs e)
        {
            this.panelExMain.Controls.Clear();
            this.panelExMain.Controls.Add(userCtlDangXuat);
        }
        UserControlTroGiup userCtlTroGiup = new UserControlTroGiup();
        private void BtnTroGiup_Click(object sender, EventArgs e)
        {
            this.panelExMain.Controls.Clear();
            this.panelExMain.Controls.Add(userCtlTroGiup);
        }

        
    }
}
