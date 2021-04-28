namespace CrudUKK
{
    partial class Form1
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSatuanBarang = new System.Windows.Forms.TextBox();
            this.txtJumlahBarang = new System.Windows.Forms.TextBox();
            this.txtKodeBarang = new System.Windows.Forms.TextBox();
            this.txtNamaBarang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.appBarang = new CrudUKK.AppBarang();
            this.barangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barangTableAdapter = new CrudUKK.AppBarangTableAdapters.BarangTableAdapter();
            this.barangIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodeBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlahBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satuanBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appBarang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barangIDDataGridViewTextBoxColumn,
            this.namaBarangDataGridViewTextBoxColumn,
            this.kodeBarangDataGridViewTextBoxColumn,
            this.jumlahBarangDataGridViewTextBoxColumn,
            this.satuanBarangDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.barangBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(12, 200);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(563, 190);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            this.dataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGridView_KeyDown);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(59, 174);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(516, 20);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSearch_KeyPress);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(500, 396);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.txtSatuanBarang);
            this.panel.Controls.Add(this.txtJumlahBarang);
            this.panel.Controls.Add(this.txtKodeBarang);
            this.panel.Controls.Add(this.txtNamaBarang);
            this.panel.Enabled = false;
            this.panel.Location = new System.Drawing.Point(12, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(563, 156);
            this.panel.TabIndex = 3;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Satuan Barang";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Jumlah Barang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kode Barang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "NamaBarang";
            // 
            // txtSatuanBarang
            // 
            this.txtSatuanBarang.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barangBindingSource, "SatuanBarang", true));
            this.txtSatuanBarang.Location = new System.Drawing.Point(105, 83);
            this.txtSatuanBarang.Name = "txtSatuanBarang";
            this.txtSatuanBarang.Size = new System.Drawing.Size(100, 20);
            this.txtSatuanBarang.TabIndex = 1;
            // 
            // txtJumlahBarang
            // 
            this.txtJumlahBarang.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barangBindingSource, "JumlahBarang", true));
            this.txtJumlahBarang.Location = new System.Drawing.Point(105, 57);
            this.txtJumlahBarang.Name = "txtJumlahBarang";
            this.txtJumlahBarang.Size = new System.Drawing.Size(100, 20);
            this.txtJumlahBarang.TabIndex = 1;
            // 
            // txtKodeBarang
            // 
            this.txtKodeBarang.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barangBindingSource, "KodeBarang", true));
            this.txtKodeBarang.Location = new System.Drawing.Point(105, 31);
            this.txtKodeBarang.Name = "txtKodeBarang";
            this.txtKodeBarang.Size = new System.Drawing.Size(373, 20);
            this.txtKodeBarang.TabIndex = 1;
            // 
            // txtNamaBarang
            // 
            this.txtNamaBarang.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barangBindingSource, "NamaBarang", true));
            this.txtNamaBarang.Location = new System.Drawing.Point(105, 5);
            this.txtNamaBarang.Name = "txtNamaBarang";
            this.txtNamaBarang.Size = new System.Drawing.Size(373, 20);
            this.txtNamaBarang.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(419, 396);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(338, 396);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // appBarang
            // 
            this.appBarang.DataSetName = "AppBarang";
            this.appBarang.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // barangBindingSource
            // 
            this.barangBindingSource.DataMember = "Barang";
            this.barangBindingSource.DataSource = this.appBarang;
            // 
            // barangTableAdapter
            // 
            this.barangTableAdapter.ClearBeforeFill = true;
            // 
            // barangIDDataGridViewTextBoxColumn
            // 
            this.barangIDDataGridViewTextBoxColumn.DataPropertyName = "BarangID";
            this.barangIDDataGridViewTextBoxColumn.HeaderText = "BarangID";
            this.barangIDDataGridViewTextBoxColumn.Name = "barangIDDataGridViewTextBoxColumn";
            // 
            // namaBarangDataGridViewTextBoxColumn
            // 
            this.namaBarangDataGridViewTextBoxColumn.DataPropertyName = "NamaBarang";
            this.namaBarangDataGridViewTextBoxColumn.HeaderText = "NamaBarang";
            this.namaBarangDataGridViewTextBoxColumn.Name = "namaBarangDataGridViewTextBoxColumn";
            this.namaBarangDataGridViewTextBoxColumn.Width = 120;
            // 
            // kodeBarangDataGridViewTextBoxColumn
            // 
            this.kodeBarangDataGridViewTextBoxColumn.DataPropertyName = "KodeBarang";
            this.kodeBarangDataGridViewTextBoxColumn.HeaderText = "KodeBarang";
            this.kodeBarangDataGridViewTextBoxColumn.Name = "kodeBarangDataGridViewTextBoxColumn";
            // 
            // jumlahBarangDataGridViewTextBoxColumn
            // 
            this.jumlahBarangDataGridViewTextBoxColumn.DataPropertyName = "JumlahBarang";
            this.jumlahBarangDataGridViewTextBoxColumn.HeaderText = "JumlahBarang";
            this.jumlahBarangDataGridViewTextBoxColumn.Name = "jumlahBarangDataGridViewTextBoxColumn";
            // 
            // satuanBarangDataGridViewTextBoxColumn
            // 
            this.satuanBarangDataGridViewTextBoxColumn.DataPropertyName = "SatuanBarang";
            this.satuanBarangDataGridViewTextBoxColumn.HeaderText = "SatuanBarang";
            this.satuanBarangDataGridViewTextBoxColumn.Name = "satuanBarangDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 425);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UKK";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appBarang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSatuanBarang;
        private System.Windows.Forms.TextBox txtJumlahBarang;
        private System.Windows.Forms.TextBox txtKodeBarang;
        private System.Windows.Forms.TextBox txtNamaBarang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNew;
        private AppBarang appBarang;
        private System.Windows.Forms.BindingSource barangBindingSource;
        private AppBarangTableAdapters.BarangTableAdapter barangTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn barangIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlahBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satuanBarangDataGridViewTextBoxColumn;
    }
}

