using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AddressBook_tests_Autoit
{
    public class TestBase
    {
        public ApplicationManager app;
       
        [OneTimeSetUp]
        public void InitApplication()
        {
            app = new ApplicationManager();
        }

        [OneTimeTearDown]
        public void StopApplication()
        {
            app.Stop();
        }
    }
}
