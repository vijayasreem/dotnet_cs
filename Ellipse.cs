using System;
using System.IO;
using System.Collections.Generic;

/*
public string ellipse()
        {
            return "<ellipse cx=\"75\" cy=\"75\" rx=\"20\" ry=\"5\" stroke=\"pink\" fill=\"transparent\" stroke-width=\"5\"/>";
        }
        public string ellipse(int x, int y, int x2, int y2)
        {
            return "<ellipse cx=\"" + x + "\" cy=\"" + y + "\" rx=\"" + x2 + "\" ry=\"" + y2 + "\" stroke=\"pink\" fill=\"transparent\" stroke-width=\"5\"/>";
        }
        public string ellipse(int x, int y, int x2, int y2, string stroke, string swidth, string fill)
        {
            return "<ellipse cx=\"" + x + "\" cy=\"" + y + "\" rx=\"" + x2 + "\" ry=\"" + y2 + "\" stroke=\"" + stroke + "\" fill=\"" + fill + "\" stroke-width=\"" + swidth + "\"/>";
        }
*/
namespace week2_cs264
{
    public class Ellipse : Shape
    {
        String svg = "";
        //String stroke = "grey";
        int x, y, x2, y2;
        public Ellipse()
        {
            x = 75;
            y = 75;
            x2 = 20;
            y2 = 5;
        }

        public Ellipse(int x, int y, int x2, int y2)
        {
            this.x = x;
            this.y = y;
            this.x2 = x2;
            this.y2 = y2;
            setSvg();
        }

        public void setSvg()
        {
            svg = "<ellipse cx=\"" + x + "\" cy=\"" + y + "\" rx=\"" + x2 + "\" ry=\"" + y2 + getStyles();
        }
        public string getSvg()
        {
            return svg;
        }



        public override string draw()
        {
            setSvg();
            string draw = "<ellipse cx=\"" + x + "\" cy=\"" + y + "\" rx=\"" + x2 + "\" ry=\"" + y2 + getStyles();
            //Console.WriteLine("Added Circle (x = {0}, y = {1}, r = {2}) added ", x, y, r, getStroke(), getFill(), getSWidth());
            return draw;
        }

        public void setLineStroke()
        {
            setSvg();
        }

        public void statedDrawn()
        {
            Console.WriteLine(getSvg());
            Console.WriteLine("Added Ellipse (cx = {0}, cy = {1}, rx = {2}, ry = {3}) added ", x, y, x2, y2, getStroke(), getFill(), getSWidth());
        }
    }

    
}