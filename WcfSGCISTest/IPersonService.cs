using DataSGCISTest.Model;
using System.Collections.Generic;
using System.ServiceModel;

namespace WcfSGCISTest
{
    [ServiceContract]
    public interface IPersonService
    {
        [OperationContract]
        List<Person> GetPersons();

        [OperationContract]
        void DeletePerson(int id);

        [OperationContract]
        bool UpdatePerson(int id, string name, int age, int personType);

        [OperationContract]
        int CreatePerson(string name, int age, int personType);

        [OperationContract]
        List<PersonType> GetPersonTypes();

        [OperationContract]
        void InitializeData();
    }    
}
