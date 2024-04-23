using AutoMapper;
using Mango.Services.RoomTypeAPI.Models;
using Mango.Services.RoomTypeAPI.Models.Dto;

namespace Mango.Services.RoomTypeAPI
{

    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<RoomTypeDto, RoomType>().ReverseMap();
                /*config.CreateMap<RoomType, RoomTypeDto>();*/
            });
            return mappingConfig;
        }

    }
}
