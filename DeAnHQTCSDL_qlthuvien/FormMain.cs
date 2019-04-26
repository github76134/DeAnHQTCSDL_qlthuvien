﻿using System;
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
        UserControlQLS userCtlQLS = new UserControlQLS();
        UserControlTLS userCtlTLS = new UserControlTLS();
        UserControlTG userCtlTG = new UserControlTG();
        UserControlNXB userCtlNXB = new UserControlNXB();
        UserControlKH userCtlKH = new UserControlKH();
        UserControlTK userCtlTK = new UserControlTK();
        UserControlKho userCtlKho = new UserControlKho();
        UserControlBC userCtlBC = new UserControlBC();

        UserControlLHD userCtlLHD = new UserControlLHD();
        UserControlTruyXuatKH userCtlTruyXuatKH = new UserControlTruyXuatKH();

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
            else
                if (ghichu == 12)
                {
                panelExMid.Controls.Clear();
                panelExMid.Controls.Add(userCtlQLS);
                ghichu = 0;
                }
                else
                    if (ghichu == 13)
                    {
                    panelExMid.Controls.Clear();
                    panelExMid.Controls.Add(userCtlTLS);
                    ghichu = 0;
                    }
                    else
                        if (ghichu == 14)
                        {
                        panelExMid.Controls.Clear();
                        panelExMid.Controls.Add(userCtlTG);
                        ghichu = 0;
                        }
                        else
                            if (ghichu == 15)
                            {
                            panelExMid.Controls.Clear();
                            panelExMid.Controls.Add(userCtlNXB);
                            ghichu = 0;
                            }
                            else
                                if (ghichu == 16)
                                {
                                panelExMid.Controls.Clear();
                                panelExMid.Controls.Add(userCtlKH);
                                ghichu = 0;
                                }
                                else
                                    if (ghichu == 17)
                                    {
                                    panelExMid.Controls.Clear();
                                    panelExMid.Controls.Add(userCtlTK);
                                    ghichu = 0;
                                    }
                                    else
                                        if (ghichu == 18)
                                        {
                                            panelExMid.Controls.Clear();
                                            panelExMid.Controls.Add(userCtlKho);
                                            ghichu = 0;
                                        }
                                        else
                                            if (ghichu == 19)
                                            {
                                                panelExMid.Controls.Clear();
                                                panelExMid.Controls.Add(userCtlBC);
                                                ghichu = 0;
                                            }
            if (ghichu == 21)
            {
                panelExMid.Controls.Clear();
                panelExMid.Controls.Add(userCtlLHD);
                ghichu = 0;
            }
            else
                if (ghichu == 22)
                {
                    panelExMid.Controls.Clear();
                    panelExMid.Controls.Add(userCtlTruyXuatKH);
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
