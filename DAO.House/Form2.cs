using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DAO.House
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        public void EditProducto(Int32 id)
        {
            var productoRepository = new ProductoRepository();

            productoBindingSource.DataSource = productoRepository.GetFromProductoById(id);
        }
    }
}
