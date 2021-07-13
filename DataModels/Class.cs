using System;
using EFExample.Enums;
using System.ComponentModel.DataAnnotations;

namespace EFExample.DataModels
{
    public class Class
    {
        public int ClassId { get; set; }    
        [MaxLength(80)]
        public string ClassName { get; set; }
        [Required]      
        public int MaxClassSize { get; set; }   
        public Language ClassLanguage { get; set; }

    }
}
