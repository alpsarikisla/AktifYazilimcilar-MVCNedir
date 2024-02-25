using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCNedir.Models
{
    public class Category
    {
        public int ID { get; set; }

        [Display(Name="Kategori Adı")]
        [Required(ErrorMessage = "Kategori Adı zorunludur")]
        [StringLength(maximumLength: 50,ErrorMessage ="50 karakterden fazla olamaz")]
        public string Name { get; set; }

        [Display(Name="Açıklama")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }


        public bool IsActive { get; set; }
    }
}