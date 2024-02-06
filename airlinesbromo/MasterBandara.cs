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
    public partial class MasterBandara : Form
    {
        public MasterBandara()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void MasterBandara_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bromoAirlinesDataSet1.Negara' table. You can move, or remove it, as needed.
            this.negaraTableAdapter.Fill(this.bromoAirlinesDataSet1.Negara);
            // TODO: This line of code loads data into the 'bromoAirlinesDataSet1.JadwalPenerbangan' table. You can move, or remove it, as needed.
            this.jadwalPenerbanganTableAdapter.Fill(this.bromoAirlinesDataSet1.JadwalPenerbangan);
            // TODO: This line of code loads data into the 'bromoAirlinesDataSet1.Bandara' table. You can move, or remove it, as needed.
            this.bandaraTableAdapter.Fill(this.bromoAirlinesDataSet1.Bandara);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
