namespace airlinesbromo
{
    partial class MasterKodePromo
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.domainUpDown2 = new System.Windows.Forms.DomainUpDown();
            this.bromoAirlinesDataSet1 = new airlinesbromo.BromoAirlinesDataSet1();
            this.kodePromoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kodePromoTableAdapter = new airlinesbromo.BromoAirlinesDataSet1TableAdapters.KodePromoTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.persentaseDiskonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maksimumDiskonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.berlakuSampaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deskripsiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bromoAirlinesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kodePromoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Location = new System.Drawing.Point(147, 397);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(200, 22);
            this.domainUpDown1.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(459, 333);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.TabIndex = 38;
            this.label8.Text = "Deskripsi";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 333);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 22);
            this.textBox1.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 399);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 16);
            this.label6.TabIndex = 35;
            this.label6.Text = "Presentasi diskon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 34;
            this.label4.Text = "Berlaku sampai";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "Kode Promo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "Semua kode promo yang terdaftar akan muncul disini";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 29);
            this.label1.TabIndex = 31;
            this.label1.Text = "Master Kode Promo";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.kodeDataGridViewTextBoxColumn,
            this.persentaseDiskonDataGridViewTextBoxColumn,
            this.maksimumDiskonDataGridViewTextBoxColumn,
            this.berlakuSampaiDataGridViewTextBoxColumn,
            this.deskripsiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kodePromoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(30, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(798, 172);
            this.dataGridView1.TabIndex = 30;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(147, 365);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 433);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 16);
            this.label5.TabIndex = 41;
            this.label5.Text = "Maksimum diskon";
            // 
            // domainUpDown2
            // 
            this.domainUpDown2.Location = new System.Drawing.Point(147, 433);
            this.domainUpDown2.Name = "domainUpDown2";
            this.domainUpDown2.Size = new System.Drawing.Size(200, 22);
            this.domainUpDown2.TabIndex = 42;
            // 
            // bromoAirlinesDataSet1
            // 
            this.bromoAirlinesDataSet1.DataSetName = "BromoAirlinesDataSet1";
            this.bromoAirlinesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kodePromoBindingSource
            // 
            this.kodePromoBindingSource.DataMember = "KodePromo";
            this.kodePromoBindingSource.DataSource = this.bromoAirlinesDataSet1;
            // 
            // kodePromoTableAdapter
            // 
            this.kodePromoTableAdapter.ClearBeforeFill = true;
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
            // kodeDataGridViewTextBoxColumn
            // 
            this.kodeDataGridViewTextBoxColumn.DataPropertyName = "Kode";
            this.kodeDataGridViewTextBoxColumn.HeaderText = "Kode";
            this.kodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kodeDataGridViewTextBoxColumn.Name = "kodeDataGridViewTextBoxColumn";
            this.kodeDataGridViewTextBoxColumn.Width = 125;
            // 
            // persentaseDiskonDataGridViewTextBoxColumn
            // 
            this.persentaseDiskonDataGridViewTextBoxColumn.DataPropertyName = "PersentaseDiskon";
            this.persentaseDiskonDataGridViewTextBoxColumn.HeaderText = "PersentaseDiskon";
            this.persentaseDiskonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.persentaseDiskonDataGridViewTextBoxColumn.Name = "persentaseDiskonDataGridViewTextBoxColumn";
            this.persentaseDiskonDataGridViewTextBoxColumn.Width = 125;
            // 
            // maksimumDiskonDataGridViewTextBoxColumn
            // 
            this.maksimumDiskonDataGridViewTextBoxColumn.DataPropertyName = "MaksimumDiskon";
            this.maksimumDiskonDataGridViewTextBoxColumn.HeaderText = "MaksimumDiskon";
            this.maksimumDiskonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maksimumDiskonDataGridViewTextBoxColumn.Name = "maksimumDiskonDataGridViewTextBoxColumn";
            this.maksimumDiskonDataGridViewTextBoxColumn.Width = 125;
            // 
            // berlakuSampaiDataGridViewTextBoxColumn
            // 
            this.berlakuSampaiDataGridViewTextBoxColumn.DataPropertyName = "BerlakuSampai";
            this.berlakuSampaiDataGridViewTextBoxColumn.HeaderText = "BerlakuSampai";
            this.berlakuSampaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.berlakuSampaiDataGridViewTextBoxColumn.Name = "berlakuSampaiDataGridViewTextBoxColumn";
            this.berlakuSampaiDataGridViewTextBoxColumn.Width = 125;
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
            this.richTextBox1.Location = new System.Drawing.Point(547, 333);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(253, 125);
            this.richTextBox1.TabIndex = 43;
            this.richTextBox1.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(552, 488);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 45;
            this.button2.Text = "batal";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(633, 488);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 44;
            this.button1.Text = "simpan";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MasterKodePromo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 552);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.domainUpDown2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.domainUpDown1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MasterKodePromo";
            this.Text = "MasterKodePromo";
            this.Load += new System.EventHandler(this.MasterKodePromo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bromoAirlinesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kodePromoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DomainUpDown domainUpDown2;
        private BromoAirlinesDataSet1 bromoAirlinesDataSet1;
        private System.Windows.Forms.BindingSource kodePromoBindingSource;
        private BromoAirlinesDataSet1TableAdapters.KodePromoTableAdapter kodePromoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn persentaseDiskonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maksimumDiskonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn berlakuSampaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deskripsiDataGridViewTextBoxColumn;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}