using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace DatosPcDreams
{

    public partial class Form1 : Form
    {
        Commands c = new Commands();
        public Form1()
        {
            InitializeComponent();
        }
        private void btn_Red_Click_1(object sender, EventArgs e)
        {
            string route = "c:/Users/frbw/red.txt";
            c.ExecuteCommand("ipconfig /all > " + route);
            System.Diagnostics.Process.Start(route);
        }

        private void btn_Datos_Click(object sender, EventArgs e)
        {
            string route = "c:/Users/frbw/systeminfo.txt";
            c.ExecuteCommand("systeminfo > " + route);
            System.Diagnostics.Process.Start(route);
        }

        private void btn_Ping_Click(object sender, EventArgs e)
        {
            string ip = this.txt_Ping.Text;
            string route = "c:/Users/frbw/ping.txt";
            c.ExecuteCommand("ping " + ip + "> " + route);
            System.Diagnostics.Process.Start(route);
        }

        private void btn_newWndsPrntScrn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            f2.Activate();
            //this.WindowState = FormWindowState.Minimized;
           // if (f2.isDeactivate() == true && f2.WindowState == FormWindowState.Normal)
            //{
               //MessageBox.Show(f2.is+"");
            //}
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Icon = DatosPcDreams.Properties.Resources.IconoDreams;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
