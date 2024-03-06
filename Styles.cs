using System;
using System.IO;
using System.Collections.Generic;
namespace week2_cs264
{
    public class Styles : Factory // part 2 of the assignment
    {

        public void changeStyle(Shape s, String type) // these methods existed in the previous main method and now Styles are in their own classes
        {
            Console.WriteLine("change style function");
            Console.WriteLine("\nThe default styles for this {0} are: (stroke = {1}, fill = {2}, stroke-width = {3}", type, s.getStroke(), s.getFill(), s.getSWidth() + ")");
            Console.WriteLine("Wanna change it?");
            if (Yep())
            {
                Console.WriteLine("\nSet {0} styles:\n", type);
                Console.WriteLine("stroke: ");
                String stroke = Console.ReadLine();
                Console.WriteLine("fill:");
                String fill = Console.ReadLine();
                Console.WriteLine("stroke-width:");
                String strokeW = Console.ReadLine();

                s.setStyles(stroke, fill, strokeW);
            }

        }

        public void changeLineStyle(Shape s) // this is for the Line svg only
        {
            Console.WriteLine("\nThe default styles for this Line are: (stroke = {0}, stroke-width = {1}", s.getStroke(), s.getSWidth() + ")");
            Console.WriteLine("Wanna change it?");
            if (Yep())
            {
                Console.WriteLine("\nSet Line styles:\n");
                Console.WriteLine("stroke (COLOUR): ");
                String stroke = Console.ReadLine();
                Console.WriteLine("stroke-width:");
                String strokeW = Console.ReadLine();

                s.setLineStyles(stroke, strokeW);
            }

        }
    }

    

}