
using System;
namespace week2_cs264
{
    // part 1 of assignment: Abstract Factory: All the methods here are taken from the main of my previous assignment. 
    // They are just placed in its own separate class called Factory,
    public class Factory 
    {
        public static CareTaker savedFolders = new CareTaker(new Momento(new Canvas())); // Momento
        public static Canvas CANVAS = new Canvas(); //Canvas recording to be sent back to main
        public static Styles editStyles = new Styles(); // part 2 of the assignment, placing styles in its own separated Class

        
        public Canvas processOrder(Canvas canvas) {
            listOfShapes();
            String command = "";
            bool confirm = false;

            while (confirm == false) // check for user input
            {
                command = Console.ReadLine().ToLower();
                
                switch (command)
                {
                    case "a": addCircle(canvas); listOfShapes(); break;
                    case "b": addRectangle(canvas); listOfShapes(); break;
                    case "c": addEllipse(canvas); listOfShapes(); break;
                    case "d": addLine(canvas); listOfShapes(); break;
                    case "e": addPolyline(canvas); listOfShapes(); break;
                    case "f": addPolygon(canvas); listOfShapes(); break;
                    case "g": addPath(canvas); listOfShapes(); break;
                    case "h": listOfShapes(); break;
                    case "n": Console.WriteLine("\nFinish adding shapes?"); if (Yep()) confirm = true; else listOfShapes(); break;

                }
            }

            return canvas;
        }

        public CareTaker getSavedFolderFromFactory(){ //get the saved momentos from here
            return savedFolders;
        }

        public Canvas getCanvasFromFactory(){ // get the currrent canvas records
            return CANVAS;
        }

        /*

            Here we add individual shapes into the canvas and saved files. 
            We have a method to checkShape() if the user is happy with the outcome

        */
        public void addCircle(Canvas canvas)
        {
            Console.WriteLine("Circle function");

            Circle circle = new Circle();
            Console.WriteLine("Would you like to set the Dimensions of the Circle?");
            if (Yep())
            {
                Console.WriteLine("\nSet Circle dimensions:\n");
                Console.WriteLine("cx: ");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("cy:");
                int y = int.Parse(Console.ReadLine());
                Console.WriteLine("r:");
                int r = int.Parse(Console.ReadLine());

                circle = new Circle(x, y, r);
            }

            editStyles.changeStyle(circle, "Circle");
            if (checkShape(circle, "Circle"))
            {
                canvas.addShape(circle);
                CANVAS = canvas;
                savedFolders.addMomento(new Momento(canvas));
            }
        }

        public bool checkShape(Shape s, String type)
        {
            Console.WriteLine("This svg {0} will be written as:", type);
            Console.WriteLine(s.draw());
            Console.WriteLine("\nOkay?");
            while (Yep() == false)
            {
                Console.WriteLine("Abandon shape?");
                if (Yep()) return false;
                Console.WriteLine("add shape?");
            }
            return true;
        }
        
        public  void addRectangle(Canvas canvas)
        {
            Console.WriteLine("Rectangle function");

            Rectangle rectangle = new Rectangle();
            Console.WriteLine("\nWould you like to set the Dimensions of the Rectangle?");
            if (Yep())
            {
                Console.WriteLine("\nSet Rectangle dimensions:\n");
                Console.WriteLine("x: ");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("y:");
                int y = int.Parse(Console.ReadLine());
                Console.WriteLine("width:");
                int width = int.Parse(Console.ReadLine());
                Console.WriteLine("height:");
                int height = int.Parse(Console.ReadLine());

                rectangle = new Rectangle(x, y, width, height);
            }

            editStyles.changeStyle(rectangle, "Rectangle");
            if (checkShape(rectangle, "Rectangle"))
            {
                canvas.addShape(rectangle);
                CANVAS = canvas;
                savedFolders.addMomento(new Momento(canvas));
            }
        }

        public  void addEllipse(Canvas canvas)
        {
            Ellipse ellipse = new Ellipse();
            Console.WriteLine("\nWould you like to set the Dimensions of the Ellipse?");
            if (Yep())
            {
                Console.WriteLine("\nSet Ellipse dimensions:\n");
                Console.WriteLine("cx: ");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("cy:");
                int y = int.Parse(Console.ReadLine());
                Console.WriteLine("rx:");
                int x2 = int.Parse(Console.ReadLine());
                Console.WriteLine("ry:");
                int y2 = int.Parse(Console.ReadLine());

                ellipse = new Ellipse(x, y, x2, y2);
            }

            editStyles.changeStyle(ellipse, "Ellipse");
            if (checkShape(ellipse, "Ellipse"))
            {
                canvas.addShape(ellipse);
                CANVAS = canvas;
                savedFolders.addMomento(new Momento(canvas));
            }
        }
        public  void addLine(Canvas canvas)
        {
            Line line = new Line();
            line.setDefaultStroke();
            Console.WriteLine("\nWould you like to set the Dimensions of the Line?");
            if (Yep())
            {
                Console.WriteLine("\nSet Line dimensions:\n");
                Console.WriteLine("x1: ");
                int x1 = int.Parse(Console.ReadLine());
                Console.WriteLine("x2:");
                int x2 = int.Parse(Console.ReadLine());
                Console.WriteLine("y1:");
                int y1 = int.Parse(Console.ReadLine());
                Console.WriteLine("y2:");
                int y2 = int.Parse(Console.ReadLine());

                line = new Line(x1, x2, y1, y2);
            }

            editStyles.changeLineStyle(line);
            if (checkShape(line, "Line"))
            {
                canvas.addShape(line);
                CANVAS = canvas;
                savedFolders.addMomento(new Momento(canvas));
            }
        }
        public  void addPolyline(Canvas canvas)
        {
            Polyline polyline = new Polyline();
            Console.WriteLine("\nWould you like to set the Dimensions of the Polyline?");
            if (Yep())
            {
                Console.WriteLine("\nSet Polyline dimensions:\n");
                Console.WriteLine("polyline: ");
                String poly = Console.ReadLine();

                polyline = new Polyline(poly);
            }

            editStyles.changeStyle(polyline, "Polyline");
            if (checkShape(polyline, "Polyline"))
            {
                canvas.addShape(polyline);
                CANVAS = canvas;
                savedFolders.addMomento(new Momento(canvas));
            }
        }

        public  void addPolygon(Canvas canvas)
        {
            Polygon polygon = new Polygon();
            Console.WriteLine("\nWould you like to set the Dimensions of the Polygon?");
            if (Yep())
            {
                Console.WriteLine("\nSet Polygon dimensions:\n");
                Console.WriteLine("points: ");
                String poly = Console.ReadLine();

                polygon = new Polygon(poly);
            }

            editStyles.changeStyle(polygon, "Polygon");
            if (checkShape(polygon, "Polygon"))
            {
                canvas.addShape(polygon);
                CANVAS = canvas;
                savedFolders.addMomento(new Momento(canvas));
            }
        }

        public  void addPath(Canvas canvas)
        {
            Console.WriteLine("Path function");

            Path path = new Path();
            Console.WriteLine("\nWould you like to set the Dimensions of the Path?");
            if (Yep())
            {
                Console.WriteLine("\nSet Path dimensions:\n");
                Console.WriteLine("d: ");
                String poly = Console.ReadLine();

                path = new Path(poly);
            }

            editStyles.changeStyle(path, "Path");
            if (checkShape(path, "Path"))
            {
                canvas.addShape(path);
                CANVAS = canvas;
                savedFolders.addMomento(new Momento(canvas));
            }
        }

        public  void listOfShapes()
        {
            Console.WriteLine("What shape would you like? \nChoose 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' or 'n'");
            Console.WriteLine("\n(a) Circle");
            Console.WriteLine("(b) Rectangle");
            Console.WriteLine("(c) Ellipse");
            Console.WriteLine("(d) Line");
            Console.WriteLine("(e) Polyline");
            Console.WriteLine("(f) Polygon");
            Console.WriteLine("(g) Path");
            Console.WriteLine("(h) Help....");
            Console.WriteLine("(n) Nevermind!");
        }

        public  bool Yep()
        {
            Console.WriteLine("Enter y or n:  ");
            String confirm = Console.ReadLine().ToLower();
            while (!confirm.Equals("y") & !confirm.Equals("n"))
            {
                confirm = Console.ReadLine().ToLower();
            }

            if (confirm.Equals("y")) return true;
            else return false;

        }
    }
}