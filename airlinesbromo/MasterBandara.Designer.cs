namespace airlinesbromo
{
    partial class MasterBandara
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodeIATADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.negaraIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlahTerminalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bandaraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bromoAirlinesDataSet1 = new airlinesbromo.BromoAirlinesDataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bandaraTableAdapter = new airlinesbromo.BromoAirlinesDataSet1TableAdapters.BandaraTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fKBandaraTujuanIDJadwalPenerbanganBandaraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jadwalPenerbanganTableAdapter = new airlinesbromo.BromoAirlinesDataSet1TableAdapters.JadwalPenerbanganTableAdapter();
            this.negaraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.negaraTableAdapter = new airlinesbromo.BromoAirlinesDataSet1TableAdapters.NegaraTableAdapter();
            this.fKNegaraIDBandaraNegaraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.negaraBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandaraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bromoAirlinesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKBandaraTujuanIDJadwalPenerbanganBandaraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.negaraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKNegaraIDBandaraNegaraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.negaraBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.namaDataGridViewTextBoxColumn,
            this.kodeIATADataGridViewTextBoxColumn,
            this.kotaDataGridViewTextBoxColumn,
            this.negaraIDDataGridViewTextBoxColumn,
            this.jumlahTerminalDataGridViewTextBoxColumn,
            this.alamatDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bandaraBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(39, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(798, 172);
            this.dataGridView1.TabIndex = 1;
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
            // namaDataGridViewTextBoxColumn
            // 
            this.namaDataGridViewTextBoxColumn.DataPropertyName = "Nama";
            this.namaDataGridViewTextBoxColumn.HeaderText = "Nama";
            this.namaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namaDataGridViewTextBoxColumn.Name = "namaDataGridViewTextBoxColumn";
            this.namaDataGridViewTextBoxColumn.Width = 125;
            // 
            // kodeIATADataGridViewTextBoxColumn
            // 
            this.kodeIATADataGridViewTextBoxColumn.DataPropertyName = "KodeIATA";
            this.kodeIATADataGridViewTextBoxColumn.HeaderText = "KodeIATA";
            this.kodeIATADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kodeIATADataGridViewTextBoxColumn.Name = "kodeIATADataGridViewTextBoxColumn";
            this.kodeIATADataGridViewTextBoxColumn.Width = 125;
            // 
            // kotaDataGridViewTextBoxColumn
            // 
            this.kotaDataGridViewTextBoxColumn.DataPropertyName = "Kota";
            this.kotaDataGridViewTextBoxColumn.HeaderText = "Kota";
            this.kotaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kotaDataGridViewTextBoxColumn.Name = "kotaDataGridViewTextBoxColumn";
            this.kotaDataGridViewTextBoxColumn.Width = 125;
            // 
            // negaraIDDataGridViewTextBoxColumn
            // 
            this.negaraIDDataGridViewTextBoxColumn.DataPropertyName = "NegaraID";
            this.negaraIDDataGridViewTextBoxColumn.HeaderText = "NegaraID";
            this.negaraIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.negaraIDDataGridViewTextBoxColumn.Name = "negaraIDDataGridViewTextBoxColumn";
            this.negaraIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // jumlahTerminalDataGridViewTextBoxColumn
            // 
            this.jumlahTerminalDataGridViewTextBoxColumn.DataPropertyName = "JumlahTerminal";
            this.jumlahTerminalDataGridViewTextBoxColumn.HeaderText = "JumlahTerminal";
            this.jumlahTerminalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jumlahTerminalDataGridViewTextBoxColumn.Name = "jumlahTerminalDataGridViewTextBoxColumn";
            this.jumlahTerminalDataGridViewTextBoxColumn.Width = 125;
            // 
            // alamatDataGridViewTextBoxColumn
            // 
            this.alamatDataGridViewTextBoxColumn.DataPropertyName = "Alamat";
            this.alamatDataGridViewTextBoxColumn.HeaderText = "Alamat";
            this.alamatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.alamatDataGridViewTextBoxColumn.Name = "alamatDataGridViewTextBoxColumn";
            this.alamatDataGridViewTextBoxColumn.Width = 125;
            // 
            // bandaraBindingSource
            // 
            this.bandaraBindingSource.DataMember = "Bandara";
            this.bandaraBindingSource.DataSource = this.bromoAirlinesDataSet1;
            // 
            // bromoAirlinesDataSet1
            // 
            this.bromoAirlinesDataSet1.DataSetName = "BromoAirlinesDataSet1";
            this.bromoAirlinesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Master Bandara";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Semua bandara yang terdaftar akan muncul disini";
            // 
            // bandaraTableAdapter
            // 
            this.bandaraTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nama";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kode IATA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 401);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Kota";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 433);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Negara";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(137, 335);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 22);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(137, 367);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(198, 22);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(137, 401);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(198, 22);
            this.textBox3.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(483, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Jumlah Terminal";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(483, 367);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Alamat";
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Location = new System.Drawing.Point(595, 335);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(242, 22);
            this.domainUpDown1.TabIndex = 13;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // fKBandaraTujuanIDJadwalPenerbanganBandaraBindingSource
            // 
            this.fKBandaraTujuanIDJadwalPenerbanganBandaraBindingSource.DataMember = "FK_BandaraTujuanID_JadwalPenerbangan_Bandara";
            this.fKBandaraTujuanIDJadwalPenerbanganBandaraBindingSource.DataSource = this.bandaraBindingSource;
            // 
            // jadwalPenerbanganTableAdapter
            // 
            this.jadwalPenerbanganTableAdapter.ClearBeforeFill = true;
            // 
            // negaraBindingSource
            // 
            this.negaraBindingSource.DataMember = "Negara";
            this.negaraBindingSource.DataSource = this.bromoAirlinesDataSet1;
            // 
            // negaraTableAdapter
            // 
            this.negaraTableAdapter.ClearBeforeFill = true;
            // 
            // fKNegaraIDBandaraNegaraBindingSource
            // 
            this.fKNegaraIDBandaraNegaraBindingSource.DataMember = "FK_NegaraID_Bandara_Negara";
            this.fKNegaraIDBandaraNegaraBindingSource.DataSource = this.negaraBindingSource;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.negaraBindingSource1;
            this.comboBox1.DisplayMember = "IbukotaNegara";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(137, 433);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(198, 24);
            this.comboBox1.TabIndex = 16;
            // 
            // negaraBindingSource1
            // 
            this.negaraBindingSource1.DataMember = "Negara";
            this.negaraBindingSource1.DataSource = this.bromoAirlinesDataSet1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(595, 367);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(242, 90);
            this.richTextBox1.TabIndex = 17;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(687, 476);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "simpan";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(606, 476);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "batal";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // MasterBandara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(871, 524);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.domainUpDown1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MasterBandara";
            this.Text = "MasterBandara";
            this.Load += new System.EventHandler(this.MasterBandara_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandaraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bromoAirlinesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKBandaraTujuanIDJadwalPenerbanganBandaraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.negaraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKNegaraIDBandaraNegaraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.negaraBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private BromoAirlinesDataSet1 bromoAirlinesDataSet1;
        private System.Windows.Forms.BindingSource bandaraBindingSource;
        private BromoAirlinesDataSet1TableAdapters.BandaraTableAdapter bandaraTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeIATADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn negaraIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlahTerminalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.BindingSource fKBandaraTujuanIDJadwalPenerbanganBandaraBindingSource;
        private BromoAirlinesDataSet1TableAdapters.JadwalPenerbanganTableAdapter jadwalPenerbanganTableAdapter;
        private System.Windows.Forms.BindingSource negaraBindingSource;
        private BromoAirlinesDataSet1TableAdapters.NegaraTableAdapter negaraTableAdapter;
        private System.Windows.Forms.BindingSource fKNegaraIDBandaraNegaraBindingSource;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource negaraBindingSource1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}