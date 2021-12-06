using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoItX3Lib;

namespace AddressBook_tests_Autoit
{
    public class ApplicationManager
    {
        public static string WindowTitle = "Free Address Book";
        private static string Path = @"C:\Users\User\Desktop\C# for tosters\FreeAddressBookPortable\AddressBook.exe";
        private AutoItX3 aux;
        private  GroupHelper groupHelper;

        public ApplicationManager()
        {
            aux = new AutoItX3();
            aux.Run(Path, "", aux.SW_SHOW);
            aux.WinWait(WindowTitle);
            aux.WinActivate(WindowTitle);
            aux.WinWaitActive(WindowTitle);
            groupHelper = new GroupHelper(this);
        }
                

        public void Stop()
        {
            aux.ControlClick(WindowTitle, "", "WindowsForms10.BUTTON.app.0.2c908d510");
        }

        public GroupHelper Groups
        {
            get
            {
                return groupHelper;
            }
        }

        public AutoItX3 Aux
        {
            get
            {
                return aux;
            }
        }
    }
}
