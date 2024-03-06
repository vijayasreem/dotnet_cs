using System;
using System.IO;
using System.Collections.Generic;

/*
public string polygon()
        {
            return "<polygon points=\"50 160 55 180 70 180 60 190 65 205 50 195 35 205 40 190 30 180 45 180\" stroke=\"pink\" fill=\"transparent\" stroke-width=\"5\"/>\" />";
        }

        public string polygon(string poly)
        {
            return "<polygon points=\"" + poly + "\" stroke=\"pink\" fill=\"transparent\" stroke-width=\"5\"/>\" />";
        }

        public string polygon(string poly, string stroke, string swidth, string fill)
        {
            return "<polygon points=\"" + poly + "\" stroke=\"" + stroke + "\" fill=\"" + fill + "\" stroke-width=\"" + swidth + "\"/>";
        }
*/
namespace week2_cs264
{
    public class Polygon : Shape
    {
        String svg = "";
        String poly;
        public Polygon()
        {
            poly = "50 160 55 180 70 180 60 190 65 205 50 195 35 205 40 190 30 180 45 180";
        }

        public Polygon(String poly)
        {
            this.poly = poly;
            setSvg();
        }

        public void setSvg()
        {
            svg = "<polygon points=\"" + poly + getStyles();
        }
        public string getSvg()
        {
            return svg;
        }



        public override string draw()
        {
            setSvg();
            string draw = "<polygon points=\"" + poly + getStyles();
            //Console.WriteLine("Added Circle (x = {0}, y = {1}, r = {2}) added ", x, y, r, getStroke(), getFill(), getSWidth());
            return draw;
        }
        public void statedDrawn()
        {
            Console.WriteLine(getSvg());
            Console.WriteLine("Added Polygon (points = {0}) added ", poly, getStroke(), getFill(), getSWidth());
        }
    }


}