using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudUKK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appBarang.Barang' table. You can move, or remove it, as needed.
            this.barangTableAdapter.Fill(this.appBarang.Barang);
            barangBindingSource.DataSource = this.appBarang.Barang;

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TxtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==(char)13)
            {
                if (string.IsNullOrEmpty(txtSearch.Text))
                    dataGridView.DataSource = barangBindingSource;
                else
                {
                    var query = from o in this.appBarang.Barang
                                where o.NamaBarang.Contains(txtNamaBarang.Text) || o.KodeBarang == txtKodeBarang.Text || o.JumlahBarang == txtJumlahBarang.Text || o.SatuanBarang.Contains(txtSatuanBarang.Text)
                                select 0;
                    dataGridView.DataSource = query.ToList();
                }
            }
        }

        private void DataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Delete)
            {
                if (MessageBox.Show("Want To Delete This Record ?", "Message" ,MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    barangBindingSource.RemoveCurrent();
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            try
            {
                panel.Enabled = true;
                txtNamaBarang.Focus();
                this.appBarang.Barang.AddBarangRow(this.appBarang.Barang.NewBarangRow());
                barangBindingSource.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                barangBindingSource.ResetBindings(false);
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            panel.Enabled = true;
            txtNamaBarang.Focus();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                barangBindingSource.EndEdit();
                barangTableAdapter.Update(this.appBarang.Barang);
                panel.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                barangBindingSource.ResetBindings(false);
            }
        }
    }
}
