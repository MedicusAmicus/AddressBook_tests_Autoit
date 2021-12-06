using AutoItX3Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_tests_Autoit
{
    public class HelperBase
    {
        protected ApplicationManager manager;
        protected string WindowTitle;
        protected AutoItX3 aux;
        public HelperBase(ApplicationManager manager)
        {
            this.manager = manager;
            WindowTitle = ApplicationManager.WindowTitle;
            this.aux = manager.Aux;
        }
    }
}
