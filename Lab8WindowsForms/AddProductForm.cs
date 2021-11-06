using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8WindowsForms
{
    public partial class AddProductForm : Form
    {
        lesyukEntities _context = new lesyukEntities();
        public AddProductForm()
        {
            InitializeComponent();
            productBindingSource.DataSource = new Product();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            productBindingSource.EndEdit();
            productBindingSource.EndEdit();
            Product product = productBindingSource.Current as Product;
            Manager manager = (Manager)manager_idComboBox.SelectedItem;
            

            if (product != null)
            {
                product.Manager_id = manager.Id;
                ValidationContext context = new ValidationContext(product, null, null);
                IList<ValidationResult> errors = new List<ValidationResult>();
                
                if (!Validator.TryValidateObject(product, context, errors, true))
                {
                    foreach (ValidationResult result in errors)
                    {
                        MessageBox.Show(result.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                
                _context.Product.Add(product);
                _context.SaveChanges();
            }
            Close();
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            List<Manager> managers =  _context.Manager.ToList();
            manager_idComboBox.Items.Clear();
            foreach(Manager manager in managers)
            {
                manager_idComboBox.Items.Add(manager);
            }
            manager_idComboBox.DisplayMember = "PIB";
        }
    }
}
