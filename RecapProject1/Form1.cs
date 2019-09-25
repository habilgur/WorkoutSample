using RecapProject1.DAL;
using RecapProject1.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RecapProject1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        IProductDal productDal = new ProductDal();

        private void Form1_Load(object sender, EventArgs e)
        {
            SetCmboxDisplayMembers();
            LoadDataToGridView();
            //helloo



        }

        private void SetCmboxDisplayMembers()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                cmbCategories.DisplayMember = "CategoryName";
                cmbCategories.ValueMember = "CategoryId";
                cmbCategories.DataSource = context.Categories.ToList();              
            }
        }

        private void LoadDataToGridView()
        {
            dgvProduct.DataSource = productDal.GetAllList();
        }

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            dgvProduct.DataSource = productDal.SearchByText(txbSearch.Text);
        }

        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvProduct.DataSource = productDal.SearchByCategoryId(Convert.ToInt32(cmbCategories.SelectedValue));
        }
    }
}
