using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerdigitsumApp
{
    public class mainfuncaion
    {
        public int mainfun()
        {
            int n = 0, i = 1, Limit = 0, m = 0;
            int sum = 0, Sumofdigits = 0;
            string number = "";
            Console.WriteLine("Enter the Number with power digit:");
            number = Convert.ToString(Console.ReadLine());
            String[] subint = number.Split('^');
            n = Convert.ToInt32(subint[0]);
            m = n;
            Limit = Convert.ToInt32(subint[1]);
            for (i = 1; i < Limit; i++)
            {
                m = m * n;
            }
            sum = m;
            string strsum = Convert.ToString(sum);
            int[] intsumarr = new int[strsum.Length];
            for (int j = 0; j < strsum.Length; j++)
            {
                intsumarr[j] = Convert.ToInt32(strsum[j] - '0');
                Sumofdigits = Sumofdigits + Convert.ToInt32(intsumarr[j]);
            }
            Console.WriteLine("Sum Of Digits :" + Sumofdigits);
            return Sumofdigits;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            mainfuncaion mf = new mainfuncaion();
            mf.mainfun();
            Console.ReadKey();
        }
    }
}
