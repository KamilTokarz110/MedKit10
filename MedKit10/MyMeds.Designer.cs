namespace MedKit10
{
    partial class MyMeds
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
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilośćDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zażywanieDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pozostałoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicamentsBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.medkitDBDataSet3 = new MedKit10.MedkitDBDataSet3();
            this.medicamentsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.medkitDBDataSet = new MedKit10.MedkitDBDataSet();
            this.medicamentsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.medkitDBDataSet2 = new MedKit10.MedkitDBDataSet2();
            this.medicamentsTableAdapter = new MedKit10.MedkitDBDataSetTableAdapters.MedicamentsTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.medicamentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.medkitDBDataSet1 = new MedKit10.MedkitDBDataSet1();
            this.medicamentsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.medicamentsTableAdapter1 = new MedKit10.MedkitDBDataSet1TableAdapters.MedicamentsTableAdapter();
            this.medicamentsTableAdapter2 = new MedKit10.MedkitDBDataSet2TableAdapters.MedicamentsTableAdapter();
            this.medicamentsTableAdapter3 = new MedKit10.MedkitDBDataSet3TableAdapters.MedicamentsTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentsBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medkitDBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medkitDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentsBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medkitDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medkitDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentsBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nazwaDataGridViewTextBoxColumn,
            this.ilośćDataGridViewTextBoxColumn,
            this.zażywanieDataGridViewCheckBoxColumn,
            this.pozostałoDataGridViewTextBoxColumn,
            this.cenaDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.medicamentsBindingSource4;
            this.dataGridView1.Location = new System.Drawing.Point(12, 215);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(754, 223);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazwaDataGridViewTextBoxColumn
            // 
            this.nazwaDataGridViewTextBoxColumn.DataPropertyName = "Nazwa";
            this.nazwaDataGridViewTextBoxColumn.HeaderText = "Nazwa";
            this.nazwaDataGridViewTextBoxColumn.Name = "nazwaDataGridViewTextBoxColumn";
            this.nazwaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ilośćDataGridViewTextBoxColumn
            // 
            this.ilośćDataGridViewTextBoxColumn.DataPropertyName = "Ilość";
            this.ilośćDataGridViewTextBoxColumn.HeaderText = "Ilość";
            this.ilośćDataGridViewTextBoxColumn.Name = "ilośćDataGridViewTextBoxColumn";
            this.ilośćDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zażywanieDataGridViewCheckBoxColumn
            // 
            this.zażywanieDataGridViewCheckBoxColumn.DataPropertyName = "Zażywanie";
            this.zażywanieDataGridViewCheckBoxColumn.HeaderText = "Zażywanie";
            this.zażywanieDataGridViewCheckBoxColumn.Name = "zażywanieDataGridViewCheckBoxColumn";
            this.zażywanieDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // pozostałoDataGridViewTextBoxColumn
            // 
            this.pozostałoDataGridViewTextBoxColumn.DataPropertyName = "Pozostało";
            this.pozostałoDataGridViewTextBoxColumn.HeaderText = "Pozostało";
            this.pozostałoDataGridViewTextBoxColumn.Name = "pozostałoDataGridViewTextBoxColumn";
            this.pozostałoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cenaDataGridViewTextBoxColumn
            // 
            this.cenaDataGridViewTextBoxColumn.DataPropertyName = "Cena";
            this.cenaDataGridViewTextBoxColumn.HeaderText = "Cena";
            this.cenaDataGridViewTextBoxColumn.Name = "cenaDataGridViewTextBoxColumn";
            this.cenaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "Opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            this.opisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // medicamentsBindingSource4
            // 
            this.medicamentsBindingSource4.DataMember = "Medicaments";
            this.medicamentsBindingSource4.DataSource = this.medkitDBDataSet3;
            // 
            // medkitDBDataSet3
            // 
            this.medkitDBDataSet3.DataSetName = "MedkitDBDataSet3";
            this.medkitDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicamentsBindingSource1
            // 
            this.medicamentsBindingSource1.DataMember = "Medicaments";
            this.medicamentsBindingSource1.DataSource = this.medkitDBDataSet;
            // 
            // medkitDBDataSet
            // 
            this.medkitDBDataSet.DataSetName = "MedkitDBDataSet";
            this.medkitDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicamentsBindingSource3
            // 
            this.medicamentsBindingSource3.DataMember = "Medicaments";
            this.medicamentsBindingSource3.DataSource = this.medkitDBDataSet2;
            // 
            // medkitDBDataSet2
            // 
            this.medkitDBDataSet2.DataSetName = "MedkitDBDataSet2";
            this.medkitDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicamentsTableAdapter
            // 
            this.medicamentsTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(138, 106);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(482, 40);
            this.button3.TabIndex = 3;
            this.button3.Text = "Ustaw Przypomnienie";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(138, 178);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(482, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // medicamentsBindingSource
            // 
            this.medicamentsBindingSource.DataSource = typeof(MedKit10.Medicaments);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(138, 55);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(299, 55);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.medicamentsBindingSource4, "Zażywanie", true));
            this.comboBox1.DataSource = this.medicamentsBindingSource4;
            this.comboBox1.DisplayMember = "Zażywanie";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(499, 55);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.ValueMember = "Zażywanie";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(349, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Wyszukaj leku";
            // 
            // medkitDBDataSet1
            // 
            this.medkitDBDataSet1.DataSetName = "MedkitDBDataSet1";
            this.medkitDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicamentsBindingSource2
            // 
            this.medicamentsBindingSource2.DataMember = "Medicaments";
            this.medicamentsBindingSource2.DataSource = this.medkitDBDataSet1;
            // 
            // medicamentsTableAdapter1
            // 
            this.medicamentsTableAdapter1.ClearBeforeFill = true;
            // 
            // medicamentsTableAdapter2
            // 
            this.medicamentsTableAdapter2.ClearBeforeFill = true;
            // 
            // medicamentsTableAdapter3
            // 
            this.medicamentsTableAdapter3.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nazwa";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Lek na :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(496, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Zażywam";
            // 
            // MyMeds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MyMeds";
            this.Text = "MyMeds";
            this.Load += new System.EventHandler(this.MyMeds_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentsBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medkitDBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medkitDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentsBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medkitDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medkitDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentsBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource medicamentsBindingSource;
        private MedkitDBDataSet medkitDBDataSet;
        private System.Windows.Forms.BindingSource medicamentsBindingSource1;
        private MedkitDBDataSetTableAdapters.MedicamentsTableAdapter medicamentsTableAdapter;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private MedkitDBDataSet1 medkitDBDataSet1;
        private System.Windows.Forms.BindingSource medicamentsBindingSource2;
        private MedkitDBDataSet1TableAdapters.MedicamentsTableAdapter medicamentsTableAdapter1;
        private MedkitDBDataSet2 medkitDBDataSet2;
        private System.Windows.Forms.BindingSource medicamentsBindingSource3;
        private MedkitDBDataSet2TableAdapters.MedicamentsTableAdapter medicamentsTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilośćDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn zażywanieDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pozostałoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private MedkitDBDataSet3 medkitDBDataSet3;
        private System.Windows.Forms.BindingSource medicamentsBindingSource4;
        private MedkitDBDataSet3TableAdapters.MedicamentsTableAdapter medicamentsTableAdapter3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}