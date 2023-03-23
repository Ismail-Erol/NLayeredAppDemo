using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.Business.DependencyResolves.Ninject;
using Northwind.Entities.Concrete;
using Nprthwind.DataAccess.Concrete.EntityFramework;
using Nprthwind.DataAccess.Concrete.NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WinFormsUI
{
    public partial class FrmProduct : Form
    {
        public FrmProduct()
        {
            InitializeComponent();
            _productService = InstanceFactory.GetInstance<IProductService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
        }

        private IProductService _productService;
        private ICategoryService _categoryService;
        private void Form1_Load(object sender, EventArgs e)
        {
            // burada yapılan ifade Producmanager klasına hangi data acces layer ile çalışacağımızı veriyoruz. 
            // bunlardan birisi EF (entityframework) diğeri Nh(nhibernate) DAL klaslarıdır. 
            // ProductManager productManager = new ProductManager(new NhProductDal()); 

            LoadProduct();
            LoadCategories();

        }

        private void LoadCategories()
        {
            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";

            cbxCategoryIdAdd.DataSource = _categoryService.GetAll();
            cbxCategoryIdAdd.DisplayMember = "CategoryName";
            cbxCategoryIdAdd.ValueMember = "CategoryId";

            cbxCategoryIdUpdate.DataSource = _categoryService.GetAll();
            cbxCategoryIdUpdate.DisplayMember = "CategoryName";
            cbxCategoryIdUpdate.ValueMember = "CategoryId";
        }

        private void LoadProduct()
        {
            dgwProduct.DataSource = _productService.GetAll();
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwProduct.DataSource = _productService.GetProductByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            catch
            {


            }

        }

        private void tbxProductNameSearch_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxProductNameSearch.Text))
            {
                dgwProduct.DataSource = _productService.GetProductByProductName(tbxProductNameSearch.Text);
            }
            else
            {
                LoadProduct();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Add(new Product
                {
                    CategoryID = Convert.ToInt32(cbxCategoryIdAdd.SelectedValue),
                    ProductName = tbxProductNameAdd.Text,
                    UnitPrice = Convert.ToDecimal(tbxUnitPriceAdd.Text),
                    UnitsInStock = Convert.ToInt16(tbxUnitInStockAdd.Text),
                    QuantityPerUnit = tbxQuantityPerUnitAdd.Text
                });
                LoadProduct();
                MessageBox.Show("Product Added");

            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgwProduct.CurrentRow != null)
            {
                try
                {
                    _productService.Update(new Product
                    {
                        ProductID = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                        CategoryID = Convert.ToInt32(cbxCategoryIdUpdate.SelectedValue),
                        ProductName = tbxProducNameUpdate.Text,
                        UnitPrice = Convert.ToDecimal(tbxUnitPriceUpdate.Text),
                        UnitsInStock = Convert.ToInt16(tbxUnitInStockUpdate.Text),
                        QuantityPerUnit = tbxQuantityPerUnitUpdate.Text
                    });
                    LoadProduct();
                    MessageBox.Show("Product Updated");
                }
                catch (Exception exception)
                {

                    MessageBox.Show(exception.Message);
                }

            }
        }

        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var rows = dgwProduct.CurrentRow;
            tbxProducNameUpdate.Text = rows.Cells[2].Value.ToString();
            cbxCategoryIdUpdate.SelectedValue = rows.Cells[1].Value;
            tbxUnitPriceUpdate.Text = rows.Cells[3].Value.ToString();
            tbxQuantityPerUnitUpdate.Text = rows.Cells[4].Value.ToString();
            tbxUnitInStockUpdate.Text = rows.Cells[5].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgwProduct.CurrentRow != null)
            {
                try
                {
                    _productService.Delete(new Product
                    {
                        ProductID = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                    });
                    LoadProduct();
                    MessageBox.Show("Product Deleted");
                }
                catch (Exception exception)
                {

                    MessageBox.Show(exception.Message);
                }

            }

        }
    }
}
