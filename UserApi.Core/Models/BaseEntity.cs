using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UserApi.Core.Models
{
   public class BaseEntity
    {
        [Required]
        public DateTime CreatedOn { get; set; }
        public  DateTime UpdatedOn { get; set; }
        public bool IsUpdated { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DeletedOn { get; set; }
      


    }
}
