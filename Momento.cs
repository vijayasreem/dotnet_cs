
using System;
using System.IO;
using System.Collections.Generic;
namespace week2_cs264
{
    public class Momento
    {
        private Canvas ListOfShapes;
        public Momento (Canvas ListOfShapes)
        {
            this.ListOfShapes = ListOfShapes;
        }

        public Canvas GetShape(){
            return this.ListOfShapes;
        }

        public String drawCanvas()
        {
            return ListOfShapes.draw();
        }


    }
}