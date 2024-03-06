using System;
using System.IO;
using System.Collections.Generic;
namespace week2_cs264
{
    public class Shape
    {
        public virtual string draw() // override the svg file of that shape
        {
            return "";
        }

        public virtual string getSVG() // override the svg file of that shape
        {
            return "";
        }


        string stroke = "2", swidth = "2", fill = "grey";

        

        public void setStyles(string stroke, string fill, string swidth)
        {
            this.stroke = stroke;
            this.fill = fill;
            this.swidth = swidth;

        }

        public void setLineStyles(string stroke, string swidth)
        {
            this.stroke = stroke;
            this.swidth = swidth;
        }

        public void setDefaultStroke() // for the line shape
        {
            this.stroke = "grey";
        }

        public string getStyles()
        {
            return "\" stroke=\"" + this.stroke + "\" fill=\"" + this.fill + "\" stroke-width=\"" + this.swidth + "\"/>";
        }

        public string getLineStyles() // for the line shape
        {
            return "\" stroke=\"" + this.stroke + "\" stroke-width=\"" + this.swidth + "\"/>";
        }

        public string getStroke()
        {
            return this.stroke;
        }

        public string getFill()
        {
            return this.fill;
        }

        public string getSWidth()
        {
            return this.swidth;
        }
        
    }

}