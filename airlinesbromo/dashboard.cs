using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace airlinesbromo
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }
        public void loadform(object panel)
        {
            if (this.panel3.Controls.Count > 0)
            {
                this.panel3.Controls.RemoveAt(0);
            }
            Form frm = panel as Form;
            frm.TopLevel = false;
            panel3.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dashboard_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 sForm = new Form1();
            sForm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            loadform(new MasterBandara());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadform(new MasterMaskapai());
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadform(new MasterJadwalPenerbangan());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loadform(new MasterKodePromo());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            loadform(new UbahStatusPenerbangan());
        }
    }
}
