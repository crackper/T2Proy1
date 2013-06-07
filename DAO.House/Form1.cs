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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var productoRepository = new ProductoRepository();

            var lista = productoRepository.GetAllFromProducto();

            productoDTOBindingSource.DataSource = lista;
            //foreach (var item in lista)
            //{
            //    ListViewItem lvitem = new ListViewItem(item.Id.ToString(),0);
            //    lvitem.SubItems.Add(item.Codigo.ToString());
            //    lvitem.SubItems.Add(item.Descripcion);
            //    lvitem.SubItems.Add(item.Categoria);

            //    listView1.Items.Add(lvitem);
            //}
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            //MessageBox.Show(listView1.SelectedItems[0].Index.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var producto = productoDTOBindingSource.Current as ProductoDTO;

            var frmprod = new Form2();
            frmprod.EditProducto(producto.Id);
            frmprod.ShowDialog();
        }

    }
}
