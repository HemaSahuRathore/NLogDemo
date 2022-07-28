using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLogDemo
{
    public class EvenOrOdd
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public static void CheckEven0rOdd()
        {
            Console.Write("Please enter the number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num <= 0)
            {
                logger.Warn("Please enter the positive Number");
                logger.Error("Number should not be negative");
                logger.Debug("Debug Failed!!");
            }
            else
            {
                if (num % 2 == 0)
                    Console.WriteLine("It is an even number");
                else
                    Console.WriteLine("It is an odd number");

                logger.Debug("Debugging successful");
                logger.Info("Answer Displayed");
            }

           

        }
    }
}
