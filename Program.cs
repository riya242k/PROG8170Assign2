using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG8170Assign2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius (cm)");
            int radiusInput = int.Parse(Console.ReadLine());
            while (radiusInput <= 0)
            {
                Console.WriteLine("Please enter a valid radius greater than 0");
                radiusInput = int.Parse(Console.ReadLine());
            }
            Circle circleObj = new Circle();
            circleObj.SetRadius(radiusInput);
            Console.WriteLine(
                "Select an opeartion from menu\n\n1. Get Circle Radius\n2. Change Circle Radius\n3. Get Circle Circumference\n4. Get Circle Area\n5. Exit\n"
            );
            string opeartionInput = (Console.ReadLine());
            bool breakLoop = false;
            while (breakLoop == false)
            {
                switch (opeartionInput)
                {
                    case "Get Circle Radius":
                        Console.WriteLine(
                            "The radius of circle is: " + circleObj.GetRadius() + " cm"
                        );
                        breakLoop = true;
                        break;
                    case "Change Circle Radius":
                        Console.WriteLine("Enter the new radius (cm)");
                        int newRadiusInput = int.Parse(Console.ReadLine());
                        while (newRadiusInput <= 0)
                        {
                            Console.WriteLine("Please enter a valid radius greater than 0");
                            newRadiusInput = int.Parse(Console.ReadLine());
                        }
                        circleObj.SetRadius(newRadiusInput);
                        Console.WriteLine(
                            "The radius of circle is updated to " + newRadiusInput + " cm"
                        );
                        breakLoop = true;
                        break;
                    case "Get Circle Circumference":
                        double circumference = circleObj.GetCircumference();
                        Console.WriteLine(
                            "The circumference of circle is "
                                + circumference.ToString("0.##")
                                + " cm"
                        );
                        breakLoop = true;
                        break;
                    case "Get Circle Area":
                        double area = circleObj.GetArea();
                        Console.WriteLine(
                            "The area of circle is " + area.ToString("0.##") + " cm square"
                        );
                        breakLoop = true;
                        break;
                    case "Exit":
                        Environment.Exit(0);
                        breakLoop = true;
                        break;
                    default:
                        Console.WriteLine(
                            "Please enter a valid option from menu\n\n1. Get Circle Radius\n2. Change Circle Radius\n3. Get Circle Circumference\n4. Get Circle Area\n5. Exit\n"
                        );
                        opeartionInput = (Console.ReadLine());
                        breakLoop = false;
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
