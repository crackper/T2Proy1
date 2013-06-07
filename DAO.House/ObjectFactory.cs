using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAO.House
{
    public class ObjectFactory<DTO,Entity>:MasterDataAccess
    {
        protected List<DTO> GetListDTO(SqlCommand command) 
        {
            var lista = new List<DTO>();

            using (var reader = ExecuteReader(command) )
            {
                if (reader.HasRows)
                {
                    AutoMapper.Mapper.CreateMap<IDataReader, DTO>();
                    lista = AutoMapper.Mapper.Map<IDataReader, List<DTO>>(reader);
                }
            }

            return lista;
        }

        protected List<Entity> GetListEntity(SqlCommand command)
        {
            var lista = new List<Entity>();

            using (var reader = ExecuteReader(command))
            {
                if (reader.HasRows)
                {
                    AutoMapper.Mapper.CreateMap<IDataReader, Entity>();
                    lista = AutoMapper.Mapper.Map<IDataReader, List<Entity>>(reader);
                }
            }

            return lista;
        }
    }
}
