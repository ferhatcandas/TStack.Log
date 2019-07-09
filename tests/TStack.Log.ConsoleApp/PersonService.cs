using System;
using System.Collections.Generic;
using System.Text;
using TStack.Log.ConsoleApp.Logger;

namespace TStack.Log.ConsoleApp
{
    public class PersonService : IPersonService
    {
        private readonly IPersonDAL _personDAL;
        private readonly ICompanyDAL _companyDAL;
        public PersonService(IPersonDAL personDAL, ICompanyDAL companyDAL)
        {
            _personDAL = personDAL;
            _companyDAL = companyDAL;
        }
        //[TimeLog]
        [GlobalLoogger]
        [ExLogger]
        public void AddPerson(Person person)
        {
            _personDAL.Add(person);
            _companyDAL.AddCompany("test");
        }
        //[ExLogger]
        [AnyLogger]
        [AnyLogger]
        [GlobalLoogger]
        public void EklemeYap()
        {

        }
    }
}
