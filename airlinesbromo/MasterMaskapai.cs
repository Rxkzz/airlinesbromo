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
    public partial class MasterMaskapai : Form
    {
        public MasterMaskapai()
        {
            InitializeComponent();
        }

        private void MasterMaskapai_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bromoAirlinesDataSet1.Maskapai' table. You can move, or remove it, as needed.
            this.maskapaiTableAdapter.Fill(this.bromoAirlinesDataSet1.Maskapai);

        }
    }
}
