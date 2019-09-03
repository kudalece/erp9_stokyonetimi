using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sy.Core.Abstracts
{
    public abstract class BaseEntity<TKey> : AuditBase, IEntity<TKey>
    {
        [Key]
        public TKey Id { get; set; }


    }
}
