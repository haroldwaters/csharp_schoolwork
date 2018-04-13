using System; using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.ComponentModel.Design;

namespace Program_6
{
    class Program
    {
        static int reqCount = 0;
        static List<Phone> phoneList = new List<Phone>();
        static List<Account> accountList = new List<Account>();

        static void Main(string[] args)
        {
            requirementText();
            Console.Title = "Program-6";
            Console.WriteLine("This is Progam-6");


            requirementText();
            makePhones();

            requirementText();
            Console.WriteLine("Class Account has been created");
            requirementText();
            Console.WriteLine("Interface IAccountUpdate has been created");

            requirementText();
            String choice;
            do
            {
                Console.WriteLine("\t1) Make phones");
                Console.WriteLine("\t2) Make accounts");
                Console.WriteLine("\t3) Calculate charges");
                Console.WriteLine("\t4) Adjust minutes");

                Console.Write("Enter selection: ");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        phoneList.AddRange(makePhones());
                        break;
                    case "2":
                        accountList.AddRange(makeAccounts());
                        break;
                    case "3":
                        calculateCharges();
                        break;
                    case "4":
                        adjustMinutes();
                        break;

                }
            } while (choice.ToLower() != "q");

            requirementText();
            Console.WriteLine("Thank you for running Program-6");
            Console.ReadKey(true);
        }

        struct Phone
        {
            public string PhoneNumber;
            public string Manufacturer;
            public string Model;
            public string OperatingSystem;
            public string DiagonalScreenSize;

            public Phone(string phoneNumber, string manufacturer, string model,
                          string operatingSystem, string diagonalScreenSize)
            {
                this.PhoneNumber = phoneNumber;
                this.Manufacturer = manufacturer;
                this.Model = model;
                this.OperatingSystem = operatingSystem;
                this.DiagonalScreenSize = diagonalScreenSize;

            }
        }

        static void requirementText()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Requirement " + (++reqCount));
            Console.ResetColor();
        }

        static Phone[] makePhones()
        {
            Console.WriteLine("Making Phones!");
            Console.Write("Number of phones to create: ");
            int numPhone = int.Parse(Console.ReadLine());

            Phone[] phoneArr = new Phone[numPhone];
            FieldInfo[] phoneFields = typeof(Phone).GetFields();

            for (int i = 0; i < numPhone; ++i)
            {
                phoneArr[i] = new Phone();

                foreach (FieldInfo f in phoneFields)
                {
                    Console.Write("{0}: ", f.Name);
                    f.SetValueDirect(__makeref(phoneArr[i]), Console.ReadLine());
                }
                Console.WriteLine("============================");
            }

            Console.WriteLine("{0} phones created!", numPhone);
            Console.WriteLine();

            return phoneArr;
        }
        static Account[] makeAccounts()
        {
            Console.WriteLine("Making Accounts!");
            Console.Write("Number of accounts to create: ");
            int numAccounts = int.Parse(Console.ReadLine());

            Account[] accountArr = new Account[numAccounts];
            PropertyInfo[] accountFields = typeof(Account).GetProperties();

            for (int i = 0; i < numAccounts; ++i)
            {
                accountArr[i] = new Account();

                foreach (PropertyInfo f in accountFields)
                {
                    Console.Write("{0}: ", f.Name);
                    f.SetValue(accountArr[i], Convert.ChangeType(Console.ReadLine(), f.PropertyType));
                }
                Console.WriteLine();
            }

            Console.WriteLine("{0} accounts created!", numAccounts);
            Console.WriteLine();

            return accountArr;
        }

        static void calculateCharges()
        {
            Console.WriteLine("Calucating Charges!");
            if (accountList.Count > 0)
            {
                for (int i = 0; i < accountList.Count; ++i)
                {
                    Console.WriteLine("{0}) {1}: \t {2}", i, accountList[i].CustomerName, accountList[i].CalculateCharge());
                }
            }
            else
            {
                Console.WriteLine("No accounts!");
            }
        }

        static void adjustMinutes()
        {
            Console.WriteLine("Adjusting Minutes!");

            if (accountList.Count > 0)
            {
                for (int i = 0; i < accountList.Count; ++i)
                {
                    Console.WriteLine("{0}) {1}: \t {2}", i+1, accountList[i].CustomerName, accountList[i].MinutesUsed);
                }
                Console.WriteLine("Select Account to adjust or 0 to quit");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 0)
                {
                    Console.WriteLine("Goodbye!");

                }
                else if (choice <= accountList.Count)
                {
                    Console.WriteLine("You have selected {0}, please enter new minutes balance", accountList[choice - 1]);
                    Console.Write("New Minutes: ");
                    accountList[choice - 1].MinutesUsed = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Invalid Selection!");
                }
            }
            else
            {
                Console.WriteLine("No accounts!");
            }
            
        }
    }
}
