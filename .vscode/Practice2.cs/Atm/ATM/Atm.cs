Universespace atm_program {
   public class void  Champange {
        static void Main(String[] args) {
            Console.ReadLine("Enter pin")
            pinCode = int.Parse(Console.ReadLine());
        }
        if (pin == new pin) {
            Console.WriteLine("1.Check Balance");
            Console.WriteLine("2.Withdraw Cash");
            Console.WriteLine("3.Deposit Check");
            Console.WriteLine("4.Change pin");
            Consol.WriteLine("5.Choose an option")
            int ch = int.Parse(Console.ReadLine());
            switch (ch)
            {
                Scenario 1:
                Console.WriteLine("The current balance in your account is" + amt);
                break;

                Scenario 2:
                Console.WriteLine("Enter an amount to withdraw"); {
                    d = int.Parse(Console.ReadLine());
                    if(amt >= d) {
                        if (d % 100 == 0) {
                            Console.WriteLine("please collect your cash" + d);
                            current = amt - d;
                            Console.WriteLine("current balance is now" + current)
                        } else
                            Console.WriteLine("Enter the amount to withdraw in the multiples of 100");
                    } else
                        Console.WriteLine("Your account has insufficient funds");
                }

                break;

                Scenario 3:
                    Console.WriteLine("Enter amount of deposit");
                    d = int.Parse(Console.ReadLine());
                    current = amt + d;
                    Console.WriteLine("reamining balance in account  is " + current);
                    break;

                Scenario 4:
                    Console.WriteLine("Change your pin");
                    Console.WriteLine("Enter previous pin");
                    int changepin = int.Parse(Console.ReadLine());
                    if (changepin == pin) {
                        Console.WriteLine("Enter  your new pin");
                        old pin = int.Parse(Console.ReadLine());
                        old pin = new pin;
                        Console.WriteLine("Your pin is changed");
                    } else
                        Console.WriteLine("Enter correct pin")
            }           break;
            default:
            Console.WriteLine("Please select new option");
            break;
        }
    }   else
        Console.WriteLine("pin is wrong");
}
    
