using DependencyInjection.WinForm.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DependencyInjection.WinForm
{
    public partial class Form1 : Form
    {
        private IProduct _product = Factories.CreateProduct();

        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = _product.GetData();
        }
    }
}
