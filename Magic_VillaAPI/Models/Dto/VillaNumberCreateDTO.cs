﻿using System.ComponentModel.DataAnnotations;

namespace Magic_VillaAPI.Models.Dto
{
    public class VillaNumberCreateDTO
    {

        [Required]
        public int VillaNo { get; set; }
        [Required]
        public int VillaID { get; set; }
        public string SpecialDetails { get; set; }
    }
}
