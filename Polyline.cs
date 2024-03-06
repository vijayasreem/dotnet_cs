using System;
using System.IO;
using System.Collections.Generic;

/*
public string polyline()
        {
            return "<polyline points=\"60 110 65 120 70 115 75 130 80 125 85 140 90 135 95 150 100 145\" stroke=\"pink\" fill=\"transparent\" stroke-width=\"5\"/>";
        }

        public string polyline(string poly)
        {
            return "<polyline points=\"" + poly + "\" stroke=\"pink\" fill=\"transparent\" stroke-width=\"5\"/>\" />";
        }

        public string polyline(string poly, string stroke, string swidth, string fill)
        {
            return "<polyline points=\"" + poly + "\" stroke=\"" + stroke + "\" fill=\"" + fill + "\" stroke-width=\"" + swidth + "\"/>";
        }
*/
namespace week2_cs264
{
    public class Polyline : Shape
    {
        String svg = "";
        String poly;
        public Polyline()
        {
            poly = "60 110 65 120 70 115 75 130 80 125 85 140 90 135 95 150 100 145";
        }

        public Polyline(String poly)
        {
            this.poly = poly;
            setSvg();
        }

        public void setSvg()
        {
            svg = "<polyline points=\"" + poly + getStyles();
        }
        public string getSvg()
        {
            return svg;
        }



        public override string draw()
        {
            setSvg();
            string draw = "<polyline points=\"" + poly + getStyles();
            //Console.WriteLine("Added Circle (x = {0}, y = {1}, r = {2}) added ", x, y, r, getStroke(), getFill(), getSWidth());
            return draw;
        }
        public void statedDrawn()
        {
            Console.WriteLine(getSvg());
            Console.WriteLine("Added Polyline (points = {0}) added ", poly, getStroke(), getFill(), getSWidth());
        }
    }


}