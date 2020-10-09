using AutoMapper;
using DAOLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceHospitalApp.TransportObj
{
    public class GenericAutoMapper<T1, T2>
    {
        public T2 CreateMapping(T1 obj)
        {
            MapperConfiguration config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<T1, T2>();
            });

            IMapper iMapper = config.CreateMapper();
            T2 newObj = iMapper.Map<T1, T2>(obj);

            return newObj;
        }
    }
}