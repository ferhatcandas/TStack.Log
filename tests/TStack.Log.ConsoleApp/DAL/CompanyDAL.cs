using System;
using System.Collections.Generic;
using System.Text;
using TStack.Log.ConsoleApp.Logger;

namespace TStack.Log.ConsoleApp
{
    public class CompanyDAL : ICompanyDAL
    {
        [TimeLog]
        public void AddCompany(string company)
        {
            
        }
    }
}
