using DataSGCISTest.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace DataSGCISTest.Context
{
    public class SGCISTestContext : DbContext
    {
        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<PersonType> PersonTypes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public SGCISTestContext() : base("name = SGCISModel") { }        
    }
}
