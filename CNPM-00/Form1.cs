using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class Form1 : Form
    {
        bool sidebarExpand = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Home_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click_2(object sender, EventArgs e)
        {

        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 40;
                if (sidebar.Width <= sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    avatarUser.Visible = false;
                    userName.Visible = false;
                    roleName.Visible = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 40;
                if (sidebar.Width >= sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    avatarUser.Visible = true;
                    userName.Visible = true;
                    roleName.Visible = true;
                    sidebarTimer.Stop();
                }
            } 
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMenu_Tick(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void btnHome_Click(object sender, MouseEventArgs e)
        {
            //btnHome.BackColor = Color.Gainsboro;
            //btnHome.ForeColor = Color.FromArgb(8, 77, 88);
            //btnHome.IconColor = Color.FromArgb(8, 77, 88);
        }
    }
}
