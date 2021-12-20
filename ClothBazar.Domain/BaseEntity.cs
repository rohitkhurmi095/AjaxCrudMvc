using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothBazar.Domain
{
    //Commpon properties
    //-------------------
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Name can't be empty!")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Short Description is required!")]
        public string Description { get; set; }
    }
}
