using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using TStack.Proxy;

namespace TStack.Log.ConsoleApp
{
    public class Startup
    {

        public IServiceCollection Init()
        {
            ServiceCollection collection = new ServiceCollection();
            //collection.AddScoped<IPersonDAL, PersonDAL>();
            collection.AddScopedProxy<ICompanyDAL, CompanyDAL>();
            collection.AddScopedProxy<IPersonDAL, PersonDAL>();
            collection.AddScopedProxy<IPersonService,PersonService>();
            
            return collection;
        }
      
    }
}
