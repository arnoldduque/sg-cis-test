using System.ComponentModel.DataAnnotations;

namespace DataSGCISTest.Model
{
    /// <summary>
    /// This class represents a Person Type
    /// </summary>
    public class PersonType
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
