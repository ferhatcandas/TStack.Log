using System;
using System.Collections.Generic;
using System.Text;
using TStack.Log.ConsoleApp.Logger;

namespace TStack.Log.ConsoleApp
{
    public class PersonDAL : IPersonDAL
    {
        [TimeLog]
        [ExLogger]
        public void Add(Person person)
        {

        }
    }
}
