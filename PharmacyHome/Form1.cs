using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyHome
{
    public partial class Form1 : Form

    {
        private Pharmacy _pharmacy;
        private DataGridView dgv;
        

        public Form1()
        {
            InitializeComponent();
            
            Pharmacy Zeferan = new Pharmacy("Zeferan");
            _pharmacy = Zeferan;
            dgvList.DataSource = _pharmacy.GetMedicines();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string type = txttype.Text.Trim();
            string name = txtname.Text.Trim();
            string price = txtPrice.Text.Trim();
            if (type == "" || name == "" || price == "")
            {
                MessageBox.Show("Hamisini doldur", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Medicine medicine = new Medicine { Type = type, Name = name, Price = price + "  Azn" };
            _pharmacy.AddMedicine(medicine);
            dgvList.DataSource = null;
            dgvList.DataSource = _pharmacy.GetMedicines();
            txttype.Text = "";

            txtname.Text = "";
            txtPrice.Text = "";


        }
        private int ID = 0;

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete delete = new Delete(_pharmacy);
            delete.Show();
        }

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            update.Visible = false;
            create.Visible = true;

            int id =(int)dgvList.Rows[e.RowIndex].Cells[0].Value;
            ID = id;
            Medicine medicine = _pharmacy.GetMedicines(id) ;
            txttype.Text = medicine.Type;

            txtname.Text =medicine.Name;
            txtPrice.Text = medicine.Price;
        }

        private void update_Click(object sender, EventArgs e)
        {
           
            
            string type = txttype.Text.Trim();
            string name = txtname.Text.Trim();
            string price = txtPrice.Text.Trim();
            if (type == "" || name == "" || price == "")
            {
                MessageBox.Show("Hamisini doldur", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            _pharmacy.UpdateMedicine(ID, type, name, price);
            dgvList.DataSource = null;
            dgvList.DataSource = _pharmacy.GetMedicines();
            txtname.Text = "";
            txtPrice.Text = "";

        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            update.Visible = true;
            create.Visible = false;

        }
    }
}
