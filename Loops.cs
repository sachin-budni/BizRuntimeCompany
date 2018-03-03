using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Loops
    {
        static void Main(string[] args)
        {
            Console.WriteLine("If Condition");
            Console.WriteLine("Enter Any Number");
            int i = Convert.ToInt32(Console.ReadLine());
            if (i < 0)
            {
                if (i == 0)
                {
                    Console.WriteLine("Enter more than 0");
                }
                else
                {
                    Console.WriteLine("Enter valid number");
                }
            }
            else if (i < 35)
            {
                Console.WriteLine("Fail");
            }
            else if (i >= 35)
            {
                if (i >= 35 && i < 45)
                {
                    Console.WriteLine("Just Pass");
                }
                else if (i >= 45 && i < 60)
                {
                    Console.WriteLine("Second Class");
                }
                else if (i >= 60 && i < 75)
                {
                    Console.WriteLine("First Class");
                }
                else if (i >= 75 && i <= 99)
                {
                    Console.WriteLine("Distinction");
                }
                else if (i == 100)
                {
                    Console.WriteLine("Out of Out");
                }
            }

            Console.WriteLine("switch cases");

            switch (i)
            {
                case 10:
                    Console.WriteLine("it is number 10 ");
                    break;
                case 20:
                    Console.WriteLine("it is number 20 ");
                    break;
                case 30:
                    Console.WriteLine("it is number 30");
                    break;
                default:
                    Console.WriteLine("it is not 10,20,30 number");
                    break;
            }

            Console.WriteLine("for Loop");

            for (int k=1; k<=3; k++)
            {
                for(int m=1; m<=3; m++)
                {
                    Console.WriteLine(k + " : " + m);
                }
            }
            int n = 1;
            Console.WriteLine("For Echa Loops");
            int[] z = new int[] { 10, 20, 30, 40, 60, 80 };
            foreach(int z1 in z)
            {
                Console.WriteLine(z1);
            }

            Console.WriteLine("while Loops");

            while (n<=3)
            {
                int o = 1;
                while(o<=3)
                {
                    Console.WriteLine(n+" : "+o);
                    o++;
                }
                n++;
            }

            Console.WriteLine("Do While Loop");

            int x = 1;
            do
            {
                int y = 1;
                do
                {
                    Console.WriteLine(x+":"+y);
                    y++;
                }
                while (y < 3);
                x++;
            }
            while (x < 3);

            Console.WriteLine("break Statement");

            for (int p=1;p<=5; p++)
            {
                if(p==4)
                {
                    break;
                }
                Console.WriteLine(p);
            }

            Console.WriteLine("Continues Statement");

            for (int p=1; p<=5; p++)
            {
                if(p==3)
                {
                    continue;
                }
                Console.WriteLine(p);
            }

            Console.WriteLine("Goto statements");
        good:
            Console.WriteLine("enter proper age");
            int age = Convert.ToInt32(Console.ReadLine());
            if(age<1)
            {
                goto good;
            }
            else
            {
                Console.WriteLine("your age is = " + age);
            }

            for(int k=1; k<=5; k++)
            {
                if(k==3)
                {
                    goto Google;
                }
                Console.WriteLine(k);
            }
        Google:
            Console.WriteLine("came out loop");
            
            
            Console.ReadLine();
        }
    }
}