using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduSop.Model.Models
{
    [Table("Error")]
    public class Error
    {
        [Key]
        public int ID { set; get; }

        public string Message { set; get; }
        public string StackTrace { set; get; }

        public DateTime CreatedDate { set; get; }
    }
}