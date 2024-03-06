using System;
using System.IO;

using System.Collections; // arraylist
using System.Collections.Generic;

// put shapes in canvas
// delete them
// update in canvas

// class shape construct

// lariza julia rodrigo 19718171
// assignment 5 cs264
// please use google chrome to look at svg file.
// update functions will need a colour parameter
// when you run the code, a svg file will be made/(updated if made already)
// Program.cs and Shape.cs are the only files here at first

// I used Abstract Factory

/*
New Classes:

1. Factory 
2. Styles

*/

namespace week2_cs264
{
    class Program
    {
        public static CareTaker savedFolders = new CareTaker(new Momento(new Canvas()));
        public static Factory factory = new Factory(); // using the factory
        static void Main(string[] args)
        {
            Canvas canvas = new Canvas();
            Console.WriteLine("\nApp Running\nWelcome!\n\nWould you like to set parameters for your Canvas?");
            if (yesOrNo())
            {
                canvas = setCanvasDimensions(canvas);
            }

            savedFolders.remove();
            savedFolders.addMomento(new Momento(canvas));

            canvas.getCanvasDimensions(); // set dimientions

            printCommands(canvas); // print the commands

            String command = "";
            bool confirm = false;
            while (confirm == false)
            {
                command = Console.ReadLine().ToLower();
                switch (command)
                {
                    case "a": canvas = addShape(canvas); printCommands(canvas); break;
                    case "u": undo(canvas); printCommands(canvas); break;
                    case "r": redo(canvas); printCommands(canvas); break;
                    case "c":
                        Console.WriteLine("\nAre you sure you wanna clear the canvas?");
                        if (yesOrNo())
                        {
                            canvas.Blank();
                            savedFolders.addMomento(new Momento(canvas));
                        }
                        Console.WriteLine("\nCanvas is an empty paper!");
                        yesToContinue();
                        printCommands(canvas); break;
                    case "d":
                        Console.WriteLine("\n-----Display Canvas-----\n" + canvas.draw() + "\n-----End of Display-----");
                        Console.WriteLine("\n-----Display savedFolders-----\n" + savedFolders.drawMomento() + "\n-----End of savedFolders-----");
                        yesToContinue();
                        printCommands(canvas); break;
                    case "s": Console.WriteLine("\nTo print, you must leave the app. Ok? \n(a new file 'Program.svg' will be made/edited)"); if (yesOrNo()) confirm = true; break;
                    case "h": printCommands(canvas); break;
                    case "w": setCanvasDimensions(canvas); printCommands(canvas); break;
                    case "b": Console.WriteLine("\nBye Bye :) see ya?"); if (yesOrNo()) confirm = true; else printCommands(canvas); break;
                }


            }


            Console.WriteLine("\nsee ya!");

            if (File.Exists("Program.svg")) System.IO.File.WriteAllText("Program.svg", string.Empty);
            outputFile(canvas);
        }

        public static Canvas addShape(Canvas canvas) // uses 
        {
            factory.processOrder(canvas);
            savedFolders = factory.getSavedFolderFromFactory();
            return factory.getCanvasFromFactory();
        }

        public static void undo(Canvas canvas)
        {
            Console.WriteLine("undo function");

            if (savedFolders.getLength() > 1) // if the canvas is nt empty
            {
                canvas.undoShape();
                savedFolders.undo();
            }
            else
            {
                Console.WriteLine("Theres nothing here to undo :<");
            }
        }

        public static void redo(Canvas canvas)
        {
            Console.WriteLine("redo function");
            canvas.redoShape();
            savedFolders.redo();
        }

        
        public static void printCommands(Canvas canvas)
        {

            Console.WriteLine("\nHit any command: 'a', 'u', 'r', 'd', 'c', 's', 'w', 'h' or 'e':");
            Console.WriteLine("(a) Add a shape");
            Console.WriteLine("(u) Undo a command");
            Console.WriteLine("(r) Redu a command");
            Console.WriteLine("(c) clear Canvas! ");
            Console.WriteLine("(d) Display the current Canvas");
            Console.WriteLine("(s) Save the canvas to a file?");
            Console.WriteLine("(w) change Canvas dimensions! " + canvas.getCanvasDimensions());
            Console.WriteLine("(h) Help?");
            Console.WriteLine("(b) Bye bye?");

        }

        public static Canvas setCanvasDimensions(Canvas canvas)
        {
            Console.WriteLine("Set canvas dimensions:\n");
            Console.WriteLine("width: ");
            canvas.setWidth(int.Parse(Console.ReadLine()));
            Console.WriteLine("height:");
            canvas.setHeight(int.Parse(Console.ReadLine()));

            return canvas;
        }


        public static bool yesOrNo()
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

        public static void yesToContinue()
        {
            Console.WriteLine("Enter y to continue");
            String confirm = Console.ReadLine().ToLower();
            while (!confirm.Equals("y"))
            {
                confirm = Console.ReadLine().ToLower();
            }
        }

        public static void outputFile(Canvas canvas)
        {
            var file = new FileStream(@"./Program.svg", FileMode.OpenOrCreate);
            //var standardOutput = Console.Out;
            StreamWriter writer = new StreamWriter(file);
            using (writer)
            {
                Console.SetOut(writer);
                //Console.WriteLine(canvas.draw());
                Console.WriteLine(savedFolders.drawMomento());
            }
        }

    }
}
