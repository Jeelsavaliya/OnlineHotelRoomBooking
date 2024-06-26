﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Mango.Services.RoomTypeAPI.Models.Dto
{
    public class RoomTypeDto
    {
        public int RoomTypeID { get; set; }
        public string Name { get; set; }
        public IFormFile File { get; set; }
        public string Photo { get; set; }
        public string Discription { get; set; }
        public string Services { get; set; }
        public decimal Size { get; set; }
        public int Capacity { get; set; }

    }
}
