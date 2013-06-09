using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAO.House
{
    public class ObjectFactory<DTO,Entity> :MasterDataAccess
        where DTO:class 
        where Entity :class
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

        protected DTO GetDTO(SqlCommand command)
        {
            DTO dto = null;

            var lista = GetListDTO(command);

            if (lista.Count > 0)
            {
                dto = lista.FirstOrDefault();
            }

            return dto;
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

        protected Entity GetEntity(SqlCommand command)
        {
            Entity entity = null;

            var lista = GetListEntity(command);

            if (lista.Count > 0)
            {
                entity = lista.FirstOrDefault();
            }

            return entity;
        }
    }
}
