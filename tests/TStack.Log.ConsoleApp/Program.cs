using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using TStack.Proxy;

namespace TStack.Log.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person() { Name = "ferhat", Surname = "candas" };

            //while (true)
            //{
            //    BenchMark(person);
            //    BenchMark(person);
                BenchMark(person);
            //}
           

        }
        public static void BenchMark(Person person)
        {
            WithDI(person);
            //List<Thread> requests = new List<Thread>();
            //for (int i = 0; i < 5; i++)
            //{
            //    var thread = new Thread(() =>
            //    {
            //        WithDI(person);
            //    });
            //    thread.Start();
            //    requests.Add(thread);

            //    foreach (var tt in requests)
            //    {
            //        tt.Join();
            //    }
            //}
        }
        public static void WithDI(Person person)
        {
            var collections = new Startup().Init();
            var provider = collections.BuildServiceProvider();
            var service = provider.GetService<IPersonService>();
            service.AddPerson(person);
        }
        public static void WithOutDI(Person person)
        {
            var personService = TProxy<IPersonService, PersonService>.Create(new PersonService(new PersonDAL(),new CompanyDAL()));
            //personService.El(person);
        }
       
    }
}
