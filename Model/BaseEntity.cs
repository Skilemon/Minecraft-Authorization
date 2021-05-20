using System;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class BaseEntity
    {
        [Key]
        public int ID { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateTime { get; set; }
        public string UpdateBy { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
