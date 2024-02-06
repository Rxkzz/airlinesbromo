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
    public partial class MasterJadwalPenerbangan : Form
    {
        public MasterJadwalPenerbangan()
        {
            InitializeComponent();
        }

        private void MasterJadwalPenerbangan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bromoAirlinesDataSet1.JadwalPenerbangan' table. You can move, or remove it, as needed.
            this.jadwalPenerbanganTableAdapter.Fill(this.bromoAirlinesDataSet1.JadwalPenerbangan);

        }
    }
}
