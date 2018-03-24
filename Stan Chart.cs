using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking

{
    // Object creation of client Kudakwashe Clinton Nyamhuka who stays in Chitungwiza.
    // This is done by the attending Bank Teller
    class AddUser
    {

        private string name;
        private string location;

        private string email;


        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;

            }
        }

        public string Location
        {
            get
            {
                return this.location;
            }
            set
            {
                this.location = value;
            }
        }
        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }




        public AddUser()
        {
        }

        static void Main()
        {
            AddUser NewUser1 = new AddUser();
            NewUser1.Name = "Kudakwashe Clinton Nyamhuka";
            NewUser1.location = "Chitungwiza";
            NewUser1.email = "klintnyamhuka@gmail.com";

            Console.WriteLine("Name: " + NewUser1.Name);
            Console.WriteLine("email: " + NewUser1.Email);
            Console.WriteLine("location: " + NewUser1.Location);


            Console.WriteLine("Registration to Standard Chartered Mobile Bank successful enter sent one time password to continue");


            RandomPassword();











        }


        public static void RandomPassword()
        {
            Random Password = new Random();


            int a = Password.Next(1878) + 1;
            int b = Password.Next(1234) + 1;
            int c = Password.Next(4352) + 1;

            int OneTimePassword = a + b + c;

            Console.WriteLine("Your One Time Password is: " + OneTimePassword);
            Console.WriteLine("Enter One Time Password: ");
            try
            {
                int Access = int.Parse(Console.ReadLine());

                bool AllowAccess = (Access == OneTimePassword);


                if (AllowAccess)
                {
                    Console.WriteLine(
                    "Welcome to Standard Chartered Mobile Banking you can reset your" +
                        " password at the User Profile Section");

                    Console.WriteLine(" Account Balance is: ");
                    AccountBalance();

                    Console.WriteLine("Do you want to perform a transaction");
                    string Response = Console.ReadLine();

                    // Client Kudakwashe Clinton Nyamhuka choosing whether to perform a transaction after
                    // being notified of successful registration.



                    string AllowedResponse1 = "yes";
                    string AllowedResponse2 = "no";

                    bool Agree = (Response == AllowedResponse1);

                    if (Agree)
                    {


                        Transaction();


                    }

                    else if (Response == AllowedResponse2)
                    {
                        Console.WriteLine("Thank you for using our service visit again soon");
                    }


                }




                else if (!AllowAccess)
                {
                    Console.WriteLine("Wrong Password please reload page and retry");
                }





            }

            catch (FormatException)
            {
                Console.WriteLine("Wrong Password Input please reload page and retry");
            }


        }


        public static void AccountBalance()
        {
            double NetSalary = 892.67;
            double InterestOnSavingsAccount = 0.01 * 100;

            Console.WriteLine((NetSalary + InterestOnSavingsAccount));



        }

        // Perform a Transaction
        public static void Transaction()
        {
            Console.WriteLine("Enter Amount: ");


            double transactionAmount = double.Parse(Console.ReadLine());
            Console.WriteLine("You have made a transaction worth {0} on your account", transactionAmount);

            // BankCharges
            // 0.025 percent charged on amounts less than $100.00 and a flat fee of $2.50 on amounts above $100.00

            double maxTransactionInterestChargeable = 100d;

            bool Transaction = (transactionAmount < maxTransactionInterestChargeable);

            bool MaxAllowedTransaction = (transactionAmount < 892.67);

            // if client enters amount over his account balance


            if (MaxAllowedTransaction)
            {


                if (Transaction)
                {
                    double bankCharge = 0.025 * transactionAmount;
                    Console.WriteLine("Bank Charge is: {0}", bankCharge);

                }
                else
                {
                    double bankCharge = 2.50d;
                    Console.WriteLine("Bank Charge is: {0}", bankCharge);
                }

            }
            else
            {
                Console.WriteLine("Insufficient Balance : transaction will not be processed");
            }

           


        }
    }








}


















