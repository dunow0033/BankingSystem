using Banking_System_Application.com.bank.view;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Banking_System_Application.com.bank.controller
{
    public class BankApplication
    {
        private bool state;
        
        public BankApplication()
        {
            state = true;
        }

        public void Run()
        {
            do
            {
                BankApplicationView.displayMainWindow();
                takeMainWindowOption();
            } while (state);
        }

        private void takeMainWindowOption()
        {
            String option = "";
            do
            {
                option = BankApplicationView.takeOption();
            } while (!Regex.IsMatch(option, "^[1-3]$"));

            runMainWindowOption(int.Parse(option));
        }

        private void runMainWindowOption(int option)
        {
            switch(option)
            {
                case 1:
                    Console.Clear();
                    BankLogin.Run();
                    break;
                case 2:
                    Console.Clear();
                    BankRegistration.Run();
                    break;
                case 3:
                    state = false;
                    break;
            }
        }
    }
}
