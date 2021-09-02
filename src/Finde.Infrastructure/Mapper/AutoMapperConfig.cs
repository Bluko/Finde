using AutoMapper;
using Finde.Core.Domain;
using Finde.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finde.Infrastructure.Mapper
{
    public class AutoMapperConfig
    {
        public static IMapper Initialize()
            => new MapperConfiguration(x =>
            {
                x.CreateMap<User, UserDTO>();
            })
            .CreateMapper();
    }
}
