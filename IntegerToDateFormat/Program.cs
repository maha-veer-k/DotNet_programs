using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;


namespace  IntegerToDateFormat
{
    public class Validate
    {
       public bool Valid(int Date_Int)
        {
            string[] Months = new string[12] {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            string Date_String = Date_Int.ToString();
            int len = Date_String.Length;
            if(len == 7)
            {
                
                string Day_ = Date_String.Substring(0, 1);
                string Month_ = Date_String.Substring(1, 2);
                string Year_ = Date_String.Substring(3, 4);
                //Console.WriteLine(Day_ + " " + Month_ + " " + Year_ + " len == 7 ");
                if (int.Parse(Day_) > 31 || int.Parse(Day_) < 0 || int.Parse(Month_) < 0 || int.Parse(Month_) > 12) return false;
                else
                {
                    Console.WriteLine("Your DOB is  " + Day_ + "-" + Months[int.Parse(Month_)-1] + "-" + Year_);
                    return true;
                }
            }
            else if (len == 8 && Char.IsNumber(Date_String, len - 1))
            {
                //Console.WriteLine(Day + " " + Month + " " + Year + " len == 8 ");
                string Day = Date_String.Substring(0, 2);
                string Month = Date_String.Substring(2, 2);
                string Year = Date_String.Substring(4, 4);
                if (int.Parse(Day) > 31 || int.Parse(Day) < 0 || int.Parse(Month) < 0 || int.Parse(Month) > 12) return false;
                else
                {
                    Console.WriteLine("Your DOB is  " + Day + "-" + Months[int.Parse(Month)-1] + "-" + Year);
                    return true;
                }
              
            }
            else return false;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            { 
            try
            {                
                    Console.WriteLine("Enter your DOB in DateMonthYear Format  ");
                    int Date_Int = Int32.Parse(Console.ReadLine());
                    Validate validate = new Validate();
                    bool validity = validate.Valid(Date_Int);
                    if(!validity){
                        Console.WriteLine("Invalid Format!!!! Please try again");

                    }
                    else
                    {
                        break;
                    }

                }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter the integer value only !!!!!!!");

            }
        }
        }
    }
}