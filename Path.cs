using System;
using System.IO;
using System.Collections.Generic;

/*
public string path()
        {
            return "<path d=\"M20,230 Q40,205 50,230 T90,230\" fill=\"none\" stroke=\"pink\" stroke-width=\"5\"/>";
        }

        public string path(string poly)
        {
            return "<path d=\"M20,230 Q40,205 50,230 T90,230\" fill=\"none\" stroke=\"pink\" stroke-width=\"5\"/>";
        }

        public string path(string poly, string stroke, string swidth, string fill)
        {
            return "<path d=\"" + poly + "\" fill=\"none\" stroke=\"pink\" stroke-width=\"5\"/>";
        }
*/
namespace week2_cs264
{
    public class Path : Shape
    {
        String svg = "";
        String d;
        public Path()
        {
            d = "M20,230 Q40,205 50,230 T90,230";
        }

        public Path(String d)
        {
            this.d = d;
            setSvg();
        }

        public void setSvg()
        {
            svg = "<path d=\"" + d + getStyles();
        }
        public string getSvg()
        {
            return svg;
        }



        public override string draw()
        {
            setSvg();
            string draw = "<path d=\"" + d + getStyles();
            //Console.WriteLine("Added Circle (x = {0}, y = {1}, r = {2}) added ", x, y, r, getStroke(), getFill(), getSWidth());
            return draw;
        }
        public void statedDrawn()
        {
            Console.WriteLine(getSvg());
            Console.WriteLine("Added Path (d = {0}) added ", d, getStroke(), getFill(), getSWidth());
        }
    }


}