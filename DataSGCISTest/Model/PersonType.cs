using System;
using System.ComponentModel.DataAnnotations;

namespace DataSGCISTest.Model
{
    public class PersonType
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
