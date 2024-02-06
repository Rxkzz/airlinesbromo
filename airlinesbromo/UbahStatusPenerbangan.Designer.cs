namespace airlinesbromo
{
    partial class UbahStatusPenerbangan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bromoAirlinesDataSet1 = new airlinesbromo.BromoAirlinesDataSet1();
            this.perubahanStatusJadwalPenerbanganBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.perubahanStatusJadwalPenerbanganTableAdapter = new airlinesbromo.BromoAirlinesDataSet1TableAdapters.PerubahanStatusJadwalPenerbanganTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jadwalPenerbanganIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusPenerbanganIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waktuPerubahanTerjadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perkiraanDurasiDelayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bromoAirlinesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perubahanStatusJadwalPenerbanganBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "Anda bisa mengubah semua status penerbangan disini";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 29);
            this.label1.TabIndex = 34;
            this.label1.Text = "Ubah status penerbangan";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.jadwalPenerbanganIDDataGridViewTextBoxColumn,
            this.statusPenerbanganIDDataGridViewTextBoxColumn,
            this.waktuPerubahanTerjadiDataGridViewTextBoxColumn,
            this.perkiraanDurasiDelayDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.perubahanStatusJadwalPenerbanganBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(53, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(770, 398);
            this.dataGridView1.TabIndex = 33;
            // 
            // bromoAirlinesDataSet1
            // 
            this.bromoAirlinesDataSet1.DataSetName = "BromoAirlinesDataSet1";
            this.bromoAirlinesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // perubahanStatusJadwalPenerbanganBindingSource
            // 
            this.perubahanStatusJadwalPenerbanganBindingSource.DataMember = "PerubahanStatusJadwalPenerbangan";
            this.perubahanStatusJadwalPenerbanganBindingSource.DataSource = this.bromoAirlinesDataSet1;
            // 
            // perubahanStatusJadwalPenerbanganTableAdapter
            // 
            this.perubahanStatusJadwalPenerbanganTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // jadwalPenerbanganIDDataGridViewTextBoxColumn
            // 
            this.jadwalPenerbanganIDDataGridViewTextBoxColumn.DataPropertyName = "JadwalPenerbanganID";
            this.jadwalPenerbanganIDDataGridViewTextBoxColumn.HeaderText = "JadwalPenerbanganID";
            this.jadwalPenerbanganIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jadwalPenerbanganIDDataGridViewTextBoxColumn.Name = "jadwalPenerbanganIDDataGridViewTextBoxColumn";
            this.jadwalPenerbanganIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusPenerbanganIDDataGridViewTextBoxColumn
            // 
            this.statusPenerbanganIDDataGridViewTextBoxColumn.DataPropertyName = "StatusPenerbanganID";
            this.statusPenerbanganIDDataGridViewTextBoxColumn.HeaderText = "StatusPenerbanganID";
            this.statusPenerbanganIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusPenerbanganIDDataGridViewTextBoxColumn.Name = "statusPenerbanganIDDataGridViewTextBoxColumn";
            this.statusPenerbanganIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // waktuPerubahanTerjadiDataGridViewTextBoxColumn
            // 
            this.waktuPerubahanTerjadiDataGridViewTextBoxColumn.DataPropertyName = "WaktuPerubahanTerjadi";
            this.waktuPerubahanTerjadiDataGridViewTextBoxColumn.HeaderText = "WaktuPerubahanTerjadi";
            this.waktuPerubahanTerjadiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.waktuPerubahanTerjadiDataGridViewTextBoxColumn.Name = "waktuPerubahanTerjadiDataGridViewTextBoxColumn";
            this.waktuPerubahanTerjadiDataGridViewTextBoxColumn.Width = 125;
            // 
            // perkiraanDurasiDelayDataGridViewTextBoxColumn
            // 
            this.perkiraanDurasiDelayDataGridViewTextBoxColumn.DataPropertyName = "PerkiraanDurasiDelay";
            this.perkiraanDurasiDelayDataGridViewTextBoxColumn.HeaderText = "PerkiraanDurasiDelay";
            this.perkiraanDurasiDelayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perkiraanDurasiDelayDataGridViewTextBoxColumn.Name = "perkiraanDurasiDelayDataGridViewTextBoxColumn";
            this.perkiraanDurasiDelayDataGridViewTextBoxColumn.Width = 125;
            // 
            // UbahStatusPenerbangan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 528);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UbahStatusPenerbangan";
            this.Text = "UbahStatusPenerbangan";
            this.Load += new System.EventHandler(this.UbahStatusPenerbangan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bromoAirlinesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perubahanStatusJadwalPenerbanganBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BromoAirlinesDataSet1 bromoAirlinesDataSet1;
        private System.Windows.Forms.BindingSource perubahanStatusJadwalPenerbanganBindingSource;
        private BromoAirlinesDataSet1TableAdapters.PerubahanStatusJadwalPenerbanganTableAdapter perubahanStatusJadwalPenerbanganTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jadwalPenerbanganIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusPenerbanganIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn waktuPerubahanTerjadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perkiraanDurasiDelayDataGridViewTextBoxColumn;
    }
}