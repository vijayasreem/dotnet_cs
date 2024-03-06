
using System;
using System.IO;
using System.Collections.Generic;
namespace week2_cs264
{
    public class CareTaker
    {
        public List<Momento> ListOfCanvas = new List<Momento>(); // stack to store all shapes

        private List<Momento> FolderOfSavedCanvas = new List<Momento>();

        public CareTaker(Momento canvas)
        {
            //Console.WriteLine("yeah");
            //Console.WriteLine("get construct Lenth: " + ListOfCanvas.Count);

            ListOfCanvas.Add(canvas);
        }

        public void addMomento(Momento canvas)
        {
            ListOfCanvas.Add(canvas);

            //Console.WriteLine("get addmoment Lenth: " + ListOfCanvas.Count);
        }

        public String drawMomento()
        {
            //Console.WriteLine("get drawmomento Lenth: " + ListOfCanvas.Count);
            return ListOfCanvas.ToArray()[ListOfCanvas.Count - 1].drawCanvas();


        }

        public void remove()
        {
            //remove canvas
            ListOfCanvas.RemoveAt(ListOfCanvas.Count - 1);
        }

        public void undo()
        {
            // save item
            if (ListOfCanvas.Count > 1)
            {
                Momento canvas = ListOfCanvas.ToArray()[ListOfCanvas.Count - 1]; // take of last shape

                // removes item from main list
                ListOfCanvas.RemoveAt(ListOfCanvas.Count - 1);

                // adds it to the redoFolder stack
                FolderOfSavedCanvas.Add(canvas);


            }

            //Console.WriteLine(drawMomento());



            //Console.WriteLine("get undo Lenth: " + ListOfCanvas.Count);

        }

        public void redo()
        {
            // save item
            if (FolderOfSavedCanvas.Count > 0)
            {
                Momento canvas = FolderOfSavedCanvas.ToArray()[FolderOfSavedCanvas.Count - 1]; // take of last shape

                // removes item from RedoFolder
                FolderOfSavedCanvas.RemoveAt(FolderOfSavedCanvas.Count - 1);

                // adds it to the canvas stack
                ListOfCanvas.Add(canvas);
            }

            //Console.WriteLine(drawMomento());

            //Console.WriteLine("get redo Lenth: " + ListOfCanvas.Count);

        }

        public int getLength()
        {
            // save item
            //Console.WriteLine("get Lenth: " + ListOfCanvas.Count);
            //Console.WriteLine(drawMomento());
            return ListOfCanvas.Count; // ignore the empty canvas
        }

    }
}