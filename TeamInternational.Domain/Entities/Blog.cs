using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TeamInternational.Domain.Entities
{
    [Table("Blog", Schema = "dbo")]
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        public string BlogName { get; set; }
    }
}
