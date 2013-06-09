using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections.ObjectModel;

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

           // var lista2 = productoRepository.GetFromProductoById(id) as IEnumerable<ProductoDTO>;
            
            //ObservableCollection<ProductoDTO> lista = new ObservableCollection<ProductoDTO>(lista2);
            productoBindingSource.DataSource = productoRepository.GetFromProductoById(id);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var producto = productoBindingSource.Current as Producto;

            string message = "";

            if (!producto.Validate(out message))
            {
                MessageBox.Show(message);
            }
        }
    }
}
