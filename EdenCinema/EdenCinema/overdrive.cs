﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EdenCinema
{
    public partial class overdrive : Form
    {
        public overdrive()
        {
            InitializeComponent();
            int left = 250;
            int top = 60;
            int count = 0;
            for (int i = 1; i <= 30; i++)
            {
                Button btn = new Button();
                btn.Name = "btn" + i;
                btn.Text = i + "";
                btn.Width = 50;
                btn.Height = 50;
                btn.Left = left;
                btn.Top = top;
                btn.BackColor = Color.White;
                Controls.Add(btn);
                left += btn.Width + 20;
                count++;
                if (count == 6)
                {
                    left = 250;
                    count = 0;
                    top += btn.Height + 20;
                }
                btn.Click += new EventHandler(btnEvent_click);
            }
        }       
        void btnEvent_click(object sender, EventArgs e)
            {
            Control ctrl = ((Control)sender);
            switch (ctrl.BackColor.Name)
            {
                 case "White":
                 ctrl.BackColor = Color.Red;
                 break;
                 case "Red":
                 ctrl.BackColor = Color.White;
                 break;
                 default:
                 ctrl.BackColor = Color.White;
                 break;
                }
            }
        private void overdrive_Load(object sender, EventArgs e)
        {
            ovrdrvr_cmbx.Items.Add("16:00");
            ovrdrvr_cmbx.Items.Add("21:00");
            for (int i = 1; i <= 30; i++)
            {
                ovrdrvPc_cmbx.Items.Add(i);
            }               
        }
        private void ovrdrvPc_cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sel_item = Convert.ToInt32(ovrdrvPc_cmbx.Text);
            price_label.Text = (sel_item * 5).ToString();
        }
        private void button32_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bought!");
        }
    }
}
