﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataSGCISTest.Model
{
    /// <summary>
    /// This class represents a Person
    /// </summary>
    public class Person
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        [ForeignKey("PersonType")]
        public int PersonTypeId { get; set; }
        public PersonType PersonType { get; set; }
    }
}
