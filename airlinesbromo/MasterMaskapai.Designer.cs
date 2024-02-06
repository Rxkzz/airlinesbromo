namespace airlinesbromo
{
    partial class MasterMaskapai
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
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bromoAirlinesDataSet1 = new airlinesbromo.BromoAirlinesDataSet1();
            this.maskapaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maskapaiTableAdapter = new airlinesbromo.BromoAirlinesDataSet1TableAdapters.MaskapaiTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perusahaanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlahKruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deskripsiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bromoAirlinesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maskapaiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Location = new System.Drawing.Point(114, 387);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(200, 22);
            this.domainUpDown1.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(454, 323);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.TabIndex = 28;
            this.label8.Text = "Deskripsi";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(114, 355);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(198, 22);
            this.textBox2.TabIndex = 25;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 323);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 22);
            this.textBox1.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 389);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Jumlah Kru";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Perusahaan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Semua maskapai yang terdaftar akan muncul disini";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 29);
            this.label1.TabIndex = 18;
            this.label1.Text = "Master Maskapai";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.namaDataGridViewTextBoxColumn,
            this.perusahaanDataGridViewTextBoxColumn,
            this.jumlahKruDataGridViewTextBoxColumn,
            this.deskripsiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.maskapaiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(25, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(798, 172);
            this.dataGridView1.TabIndex = 17;
            // 
            // bromoAirlinesDataSet1
            // 
            this.bromoAirlinesDataSet1.DataSetName = "BromoAirlinesDataSet1";
            this.bromoAirlinesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // maskapaiBindingSource
            // 
            this.maskapaiBindingSource.DataMember = "Maskapai";
            this.maskapaiBindingSource.DataSource = this.bromoAirlinesDataSet1;
            // 
            // maskapaiTableAdapter
            // 
            this.maskapaiTableAdapter.ClearBeforeFill = true;
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
            // perusahaanDataGridViewTextBoxColumn
            // 
            this.perusahaanDataGridViewTextBoxColumn.DataPropertyName = "Perusahaan";
            this.perusahaanDataGridViewTextBoxColumn.HeaderText = "Perusahaan";
            this.perusahaanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perusahaanDataGridViewTextBoxColumn.Name = "perusahaanDataGridViewTextBoxColumn";
            this.perusahaanDataGridViewTextBoxColumn.Width = 125;
            // 
            // jumlahKruDataGridViewTextBoxColumn
            // 
            this.jumlahKruDataGridViewTextBoxColumn.DataPropertyName = "JumlahKru";
            this.jumlahKruDataGridViewTextBoxColumn.HeaderText = "JumlahKru";
            this.jumlahKruDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jumlahKruDataGridViewTextBoxColumn.Name = "jumlahKruDataGridViewTextBoxColumn";
            this.jumlahKruDataGridViewTextBoxColumn.Width = 125;
            // 
            // deskripsiDataGridViewTextBoxColumn
            // 
            this.deskripsiDataGridViewTextBoxColumn.DataPropertyName = "Deskripsi";
            this.deskripsiDataGridViewTextBoxColumn.HeaderText = "Deskripsi";
            this.deskripsiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deskripsiDataGridViewTextBoxColumn.Name = "deskripsiDataGridViewTextBoxColumn";
            this.deskripsiDataGridViewTextBoxColumn.Width = 125;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(548, 320);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(236, 89);
            this.richTextBox1.TabIndex = 30;
            this.richTextBox1.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(552, 459);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 32;
            this.button2.Text = "batal";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(633, 459);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "simpan";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MasterMaskapai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 555);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.domainUpDown1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MasterMaskapai";
            this.Text = "MasterMaskapai";
            this.Load += new System.EventHandler(this.MasterMaskapai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bromoAirlinesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maskapaiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BromoAirlinesDataSet1 bromoAirlinesDataSet1;
        private System.Windows.Forms.BindingSource maskapaiBindingSource;
        private BromoAirlinesDataSet1TableAdapters.MaskapaiTableAdapter maskapaiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perusahaanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlahKruDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deskripsiDataGridViewTextBoxColumn;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}