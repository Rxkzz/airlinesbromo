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
    public partial class UbahStatusPenerbangan : Form
    {
        public UbahStatusPenerbangan()
        {
            InitializeComponent();
        }

        private void UbahStatusPenerbangan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bromoAirlinesDataSet1.PerubahanStatusJadwalPenerbangan' table. You can move, or remove it, as needed.
            this.perubahanStatusJadwalPenerbanganTableAdapter.Fill(this.bromoAirlinesDataSet1.PerubahanStatusJadwalPenerbangan);

        }
    }
}
