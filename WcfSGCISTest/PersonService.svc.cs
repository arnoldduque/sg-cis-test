using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DataSGCISTest.Model;
using DataSGCISTest.Context;

namespace WcfSGCISTest
{
    public class PersonService : IPersonService
    {
        List<Person> IPersonService.GetPersons()
        {
            SGCISTestContext context = new SGCISTestContext();
            List<Person> persons = new List<Person>();

            var personEntityList = context.Persons;
            foreach (Person pe in personEntityList)
            {
                persons.Add(pe);
            }

            return personEntityList != null
                && personEntityList.Count() > 0
                ? persons
                : throw new Exception("There are no persons in the DataBase.");
        }

        public void DeletePerson(int id)
        {
            SGCISTestContext context = new SGCISTestContext();
            Person personEntity = new Person
            {
                Id = id
            };

            context.Persons.Attach(personEntity);
            context.Persons.Remove(personEntity);
            context.SaveChanges();
        }

        public bool UpdatePerson(int id, string name, int age, int personType)
        {
            try
            {
                SGCISTestContext context = new SGCISTestContext();
                Person personEntity = new Person
                {
                    Id = id,
                    Name = name,
                    Age = age,
                    PersonTypeId = personType
                };
                context.Persons.Add(personEntity);
                context.Entry(personEntity).State = EntityState.Modified;
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<PersonType> GetPersonTypes()
        {
            SGCISTestContext context = new SGCISTestContext();
            List<PersonType> personTypes = new List<PersonType>();

            var personEntityList = context.PersonTypes;
            foreach (PersonType pte in personEntityList)
            {
                personTypes.Add(pte);
            }

            return personEntityList != null
                && personEntityList.Count() > 0
                ? personTypes
                : throw new Exception("There are no persons types in the DataBase.");
        }

        public int CreatePerson(string name, int age, int personType)
        {
            try
            {
                SGCISTestContext context = new SGCISTestContext();
                Person personEntity = new Person
                {
                    Name = name,
                    Age = age,
                    PersonTypeId = personType
                };
                context.Persons.Add(personEntity);
                context.Entry(personEntity).State = EntityState.Added;
                context.SaveChanges();

                return personEntity.Id;
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// This method adds some data to the DataBase, for Testing purposes.
        /// </summary>        
        public void InitializeData()
        {
            SGCISTestContext context = new SGCISTestContext();

            var personType1 = new PersonType
            {
                Description = "Teacher"
            };

            var personType2 = new PersonType
            {
                Description = "Student"
            };

            context.PersonTypes.Add(personType1);
            context.PersonTypes.Add(personType2);

            var person1 = new Person
            {
                Age = 15,
                Name = "Andrew Thomas",
                PersonType = personType2,
                PersonTypeId = personType2.Id
            };

            var person2 = new Person
            {
                Age = 45,
                Name = "John Smith",
                PersonType = personType1,
                PersonTypeId = personType1.Id
            };

            context.Persons.Add(person1);
            context.Persons.Add(person2);

            context.SaveChanges();
        }
    }
}
