
using System;
using System.IO;
using System.Collections.Generic;
namespace week2_cs264
{
    public class Canvas
    {
        public Stack<Shape> canvas = new Stack<Shape>(); // stack to store all shapes
        int width, height;

        private Stack<Shape> undo = new Stack<Shape>(); // statck for undo and redo
        //private Stack<Shape> redo;

        bool blank = false; bool wasBlank = false;



        public Canvas()
        {
            width = 500;
            height = 500;
        }

        public Canvas(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public String getCanvasDimensions() // get dimentions
        {
            return "dimensions currently: (" + getWidth() + ", " + getHeight() + ")";
        }

        //- ---------------------------

        public Shape undoShape()
        {
            //if (blank) return undoBlank();
            // when you remove a shape from the canvas, 
            //then you have to add it to the undo stack to save the information for redoing later

            if (canvas.Count > 0)
            {
                Shape s = removeShape();
                undo.Push(s);
                Console.WriteLine("Undone shape: " + s.draw());
                return s;
            }
            Console.WriteLine("(Theres nothing here to undo :<)");
            return new Shape();
        }

        public Shape undoBlank()
        {

            Console.WriteLine("undo blank:... ");
            wasBlank = true;
            blank = false;
            return new Shape();

        }

        public void redoBlank()
        {
            blank = true;
            wasBlank = false;
            Console.WriteLine("redo blank:... ");

        }

        public void redoShape()
        {
            //if (wasBlank) redoBlank();
            // when you redo, push it back into the canvas 
            //undo only if the stack has somehting
            //Console.WriteLine("undo.Count " + undo.Count);
            if (undo.Count != 0)
            {

                Shape s = undo.Pop();
                Console.WriteLine("redone shape: " + s.draw());
                canvas.Push(s);
            }

            else
            {
                Console.WriteLine("Nothing to redo :>");
            }

        }

        // ----------------------------------

        public void setHeight(int height)
        {
            this.height = height;
        }

        public void setWidth(int width)
        {
            this.width = width;
        }

        public void addShape(Shape s)
        {
            //canvas.Push(s);
            Console.WriteLine("Added Shape to canvas: {0}", s.draw());
            undo = new Stack<Shape>();
            canvas.Push(s);
        }

        public Shape removeShape()
        {
            //canvas.Push(s);
            //Console.WriteLine("Added Shape to canvas: {0}", s.draw());

            Shape s = canvas.Pop();
            Console.WriteLine("!!! REMOVED Shape to canvas: {0}", s.draw());
            return s;
        }

        public int getHeight()
        {
            return this.height;
        }

        public int getSize()
        {
            return canvas.Count;
        }

        public int getWidth()
        {
            return this.width;
        }

        public void Blank()
        {
            undo = canvas;
            blank = true;
            canvas.Clear();
        }

        public string draw() // draw/get everything in the canvas 
        {
            //Circle c = new Circle();
            //canvas.Add(c);
            String drawing = "<?xml version=\"1.0\" standalone=\"no\"?>\n<svg width=\"" + getWidth() + "\" height=\"" + getHeight() + "\" version=\"1.1\" xmlns=\"http://www.w3.org/2000/svg\">";
            for (int i = (getSize() - 1); i >= 0; i--)
            {
                drawing = drawing + "\n" + canvas.ToArray()[i].draw();
                //Console.WriteLine(canvas[i]);
            }

            drawing = drawing + "\n</svg>";
            return drawing;
        }
    }
}