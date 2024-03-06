using System;
using System.IO;
using System.Collections.Generic;
namespace week2_cs264
{
    public class Circle : Shape
    {
        String svg = "";
        int x, y, r;
        public Circle()
        {
            x = 50;
            y = 50;
            r = 40;
        }

        public Circle(int x, int y, int r)
        {
            this.x = x;
            this.y = y;
            this.r = r;
            setSvg();
        }

        public void setSvg()
        {
            svg = "<circle cx=\"" + x + "\" cy=\"" + y + "\" r=\"" + r + getStyles();
        }
        public string getSvg()
        {
            return svg;
        }



        public override string draw()
        {
            setSvg();
            string draw = "<circle cx=\"" + x + "\" cy=\"" + y + "\" r=\"" + r + getStyles();
            //Console.WriteLine("Added Circle (x = {0}, y = {1}, r = {2}) added ", x, y, r, getStroke(), getFill(), getSWidth());
            return draw;
        }
        public void statedDrawn() // when adding shape into canvas, this line pops up
        {
            Console.WriteLine(getSvg());
            Console.WriteLine("Added Circle (x = {0}, y = {1}, r = {2}) added ", x, y, r, getStroke(), getFill(), getSWidth());
        }
    }

    
}