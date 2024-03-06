using System;
using System.IO;
using System.Collections.Generic;

/*
public string line()
        {
            return "<line x1=\"10\" x2=\"50\" y1=\"110\" y2=\"90\" stroke=\"pink\" stroke-width=\"5\"/>";
        }
        public string line(int x, int x2, int y, int y2)
        {
            return "<line x1=\"" + x + "\" x2=\"" + x2 + "\" y1=\"" + y + "\" y2=\"" + y2 + "\" stroke=\"pink\" stroke-width=\"5\"/>";
        }
        public string line(int x, int x2, int y, int y2, string stroke, string swidth)
        {
            return "<line x1=\"" + x + "\" x2=\"" + x2 + "\" y1=\"" + y + "\" y2=\"" + y2 + "\" stroke=\"" + stroke + "\" stroke-width=\"" + swidth + "\"/>";
        }*/


namespace week2_cs264
{
    public class Line : Shape
    {
        String svg = "";
        int x1, x2, y1, y2;
        public Line()
        {
            x1 = 10;
            x2 = 50;
            y1 = 110;
            y2 = 90;
        }

        public Line(int x1, int x2, int y1, int y2)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;
            setSvg();
        }

        public void setSvg()
        {
            svg = "<line x1=\"" + x1 + "\" x2=\"" + x2 + "\" y1=\"" + y1 + "\" y2=\"" + y2 + getLineStyles();
        }
        public string getSvg()
        {
            return svg;
        }



        public override string draw()
        {
            setSvg();
            string draw = "<line x1=\"" + x1 + "\" x2=\"" + x2 + "\" y1=\"" + y1 + "\" y2=\"" + y2 + getLineStyles();
            //Console.WriteLine("Added Circle (x = {0}, y = {1}, r = {2}) added ", x, y, r, getStroke(), getFill(), getSWidth());
            return draw;
        }
        public void statedDrawn()
        {
            Console.WriteLine(getSvg());
            Console.WriteLine("Added Line (x1 = {0}, x2 = {1}, y1 = {2}, y2 = {3}) added ", x1, x2, y1, y2,  getStroke(), getSWidth());
        }
    }

    
}