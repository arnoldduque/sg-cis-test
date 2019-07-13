using DataSGCISTest.Model;
using System.Data.Entity;

namespace DataSGCISTest.Context
{
    /// <summary>
    /// This class is used by the EF to generate de Data Base Context in wich
    /// the data of the aplication will be stored.
    /// </summary>
    public class SGCISTestContext : DbContext
    {
        /// <summary>
        /// Data Base Set for Persons
        /// </summary>
        public virtual DbSet<Person> Persons { get; set; }

        /// <summary>
        /// Data Base Set for Types of Persons
        /// </summary>
        public virtual DbSet<PersonType> PersonTypes { get; set; }

        /// <summary>
        /// Constructor of the class, with the base Conection String
        /// </summary>
        public SGCISTestContext() : base("name = SGCISModel") { }        
    }
}
