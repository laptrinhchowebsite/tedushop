﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduSop.Model.Models
{ 
    [Table("ApllicationGroups")]
    public class ApplicationGroup
    {
       [Key]
       [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [StringLength(250)]
        public string Name { set; get; }
        [StringLength(250)]
        public string Description { set; get; }
    }
}
