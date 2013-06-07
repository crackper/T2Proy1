using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAO.House
{
    public class ProductoRepository
    {
        public List<ProductoDTO> GetAllFromProducto()
        {
            var lista = new List<ProductoDTO>();

            var cnx = new SqlConnection();
            cnx.ConnectionString = "Data Source=(local);Initial Catalog=DBSystem;Integrated Security=True";

            cnx.Open();

            using (cnx)
            {
                var command = cnx.CreateCommand();
                command.CommandText = "GetAllFromProducto";
                command.CommandType = CommandType.StoredProcedure;

                using (var reader = command.ExecuteReader())
                {

                    if (reader.HasRows)
                    {
                        AutoMapper.Mapper.CreateMap<IDataReader, ProductoDTO>();
                        lista = AutoMapper.Mapper.Map<IDataReader, List<ProductoDTO>>(reader);
                    }
                    //while (reader.Read())
                    //{
                    //    var producto = new Producto()
                    //    {
                    //        Id=reader.GetInt32(reader.GetOrdinal("Id")),
                    //        CategoriaId = reader.GetInt32(reader.GetOrdinal("CategoriaId"))
                    //    };                        

                    //    lista.Add(producto);
                    //}
                }

            }

            return lista;
        }
    }
}
