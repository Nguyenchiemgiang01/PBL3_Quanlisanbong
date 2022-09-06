﻿using Do_An_PLB03.BUS;
using Do_An_PLB03.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_An_PLB03.GUI
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }
        DTONguoiDung user = new DTONguoiDung();
        private void txtUser_Leave(object sender, EventArgs e)
        {
            txtUser.ForeColor = Color.MidnightBlue;
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            txtPassword.ForeColor = Color.MidnightBlue;
        }

        private void txtUser_MouseClick(object sender, MouseEventArgs e)
        {
            txtUser.ForeColor = Color.DarkTurquoise;
        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            txtPassword.ForeColor = Color.DarkTurquoise;
        }

        private void iptDisEye_MouseDown(object sender, MouseEventArgs e)
        {
            iptDisEye.IconChar = FontAwesome.Sharp.IconChar.Eye;
            txtPassword.PasswordChar = '\0';
        }

        private void iptDisEye_MouseUp(object sender, MouseEventArgs e)
        {
            iptDisEye.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            txtPassword.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            user.TenDangNhap = txtUser.Text;
            user.MatKhau = txtPassword.Text;
            if (BUSDangNhap.DangNhap(user))
            {
                this.Hide();
                FormChinh frm = new FormChinh(user);
                frm.ShowDialog();
                this.Close();
            }
            else
            {
                lblHopLe.Visible = true;
            }
        }
    }
}
