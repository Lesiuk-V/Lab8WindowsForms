using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8WindowsForms
{
    public partial class Form1 : Form
    {
        lesyukEntities _context = new lesyukEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            AddProductForm addProduct = new AddProductForm();
            addProduct.Show();
        }

        private void getProducts_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _context.Product.ToList();
            dataGridView1.Refresh();
        }

        private void getReportButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _context.P_SelectCustomersReport3();
            dataGridView1.Refresh();
        }
    }
}
