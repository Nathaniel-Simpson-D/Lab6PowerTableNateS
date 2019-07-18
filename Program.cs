using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab6PowerChartNateS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Learn your power!");
            bool rep = true;
            while (rep)
            {
                int reps = GetIntUser("What interger would you like us to repeat to?");
                
                bool con = true;
                con = EvalYN("Are you ready?");
                if(con)
                {
                    PrintHeader();

                    for (int i = 1; i <= reps; i++)
                    {


                        PrintTable(i);

                    }
                    
                }
                rep = EvalYN("Would you like another chart?");
            }
            Console.WriteLine("Goodbye, press any key to exit.");
            Console.ReadKey();
        }
        public static string GetUserInp(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine().ToLower();
            return input;
        }
        public static int GetIntUser(string message)
        {
            string input = GetUserInp(message);
            int num;
            if (int.TryParse(input, out num))
            {
                return num;
            }
            else
            {
                return GetIntUser("Please input a CORRECT number!");
            }
        }
        public static bool EvalYN(string messege)
        {
            bool eval = true;
            Console.WriteLine($"{messege}(Y/N)");
            string res = Console.ReadLine().ToLower();
            if (res == "n" || res == "no")
            {
                eval = false;
            }
            return eval;
        }
        
        public static double CalcPwr2(int i)
        {
            double C = i * i;

            return C;
        }
        public static double CalcPwr3(int i)
        {
            double C = i * i *i;

            return C;
        }
        public static void PrintTable(int i)
        {
            double i2 = CalcPwr2(i);
            double i3 = CalcPwr3(i);

            string istr = i.ToString();
            string i3s = i3.ToString();
            string i2s = i2.ToString();

            Console.Write("{0,10}", istr);
            Console.Write("{0,10}", i2s);
            Console.WriteLine("{0,10}", i3s);

        }
        public static void PrintHeader()
        {
            Console.Write("{0,10}", "Interger");
            Console.Write("{0,10}", "Squared");
            Console.WriteLine("{0,10}", "Cubed");
            Console.Write("{0,10}", "=========");
            Console.Write("{0,10}", "==========");
            Console.WriteLine("{0,10}", "==========");
        }
    }
    
}
