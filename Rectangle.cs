using System;
using System.IO;
using System.Collections.Generic;

namespace week2_cs264
{
    public class Rectangle : Shape
    {
        String svg = "";
        int x, y, width, height;
        public Rectangle()
        {
            x = 10;
            y = 10;
            width = 30;
            height = 30;
        }

        public Rectangle(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            setSvg();
        }

        public void setSvg()
        {
            svg = "<rect x=\"" + x + "\" y=\"" + y + "\" width=\"" + width + "\" height=\"" + height + getStyles();
        }
        public string getSvg()
        {
            return svg;
        }



        public override string draw()
        {
            setSvg();
            string draw = "<rect x=\"" + x + "\" y=\"" + y + "\" width=\"" + width + "\" height=\"" + height + getStyles();
            //Console.WriteLine("Added Circle (x = {0}, y = {1}, r = {2}) added ", x, y, r, getStroke(), getFill(), getSWidth());
            return draw;
        }
        public void statedDrawn()
        {
            Console.WriteLine(getSvg());
            Console.WriteLine("Added Rectangle (x = {0}, y = {1}, width = {2}, height = {3}) added ", x, y, width, height, getStroke(), getFill(), getSWidth());
        }
    }

    
}