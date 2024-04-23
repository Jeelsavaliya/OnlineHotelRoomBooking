using Mango.Web.Models;
using Mango.Web.Service.IService;
using Mango.Web.Utility;
using Web.Service.IService;

namespace Web.Service
{
    public class RoomTypeService : IRoomTypeService
    {
        private readonly IBaseService _baseService;

        public RoomTypeService(IBaseService baseService)
        {
            _baseService = baseService;
        }

        public async Task<ResponseDto?> CreateRoomTypesAsync(RoomTypeDto productDto)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.POST,
                Data = productDto,
                Url = SD.RoomTypeAPIBase + "/api/roomtype",
                ContentType = SD.ContentType.MultipartFormData
            });
        }

        public async Task<ResponseDto?> DeleteRoomTypesAsync(int id)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.DELETE,
                Url = SD.RoomTypeAPIBase + "/api/roomtype/" + id
            });
        }

        public async Task<ResponseDto?> GetAllRoomTypesAsync()
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.RoomTypeAPIBase + "/api/roomtype"
            });
        }

        public async Task<ResponseDto?> GetRoomTypeByIdAsync(int id)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.RoomTypeAPIBase + "/api/roomtype/" + id
            });
        }

        public async Task<ResponseDto?> UpdateRoomTypesAsync(RoomTypeDto productDto)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.PUT,
                Data = productDto,
                Url = SD.RoomTypeAPIBase + "/api/roomtype",
                ContentType = SD.ContentType.MultipartFormData
            });
        }
    }
}
