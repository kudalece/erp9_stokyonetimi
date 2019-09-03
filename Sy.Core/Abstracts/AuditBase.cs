using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sy.Core.Abstracts
{

  
   public abstract class AuditBase
    {

       


        [StringLength(50)]
        public string CreatedUser { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        [StringLength(50)]
        public string UpdateUser { get; set; }
        public DateTime? UpdatedDate { get; set; }

    }
}
