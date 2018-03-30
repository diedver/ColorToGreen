using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Bitmap Bm = new Bitmap("C:\\Fotologs\\0woensdag 28 maart 2018na laminatie.bmp");


            int i = 0;
            int j = 0;

           // Console.WriteLine(Bm.Width);
           // Console.WriteLine(Bm.Height);


            while (j < Bm.Height)
            {
                while (i < Bm.Width)
                {
                    Color clr = Bm.GetPixel(i, j);
                    int red = clr.R; //Console.WriteLine(red);
                    int green = clr.G; //Console.WriteLine(green);
                    int blue = clr.B; //Console.WriteLine(blue);

                    int greenOverbelicht = green  +50;
                    if (greenOverbelicht > 255)
                    {
                        greenOverbelicht = 255;
                    }

                    Color Groenlayout = Color.FromArgb(0, greenOverbelicht, 0);
                    Bm.SetPixel(i, j, Groenlayout);
 
                    //Color clrNa = Bm.GetPixel(i, j);
                    //int redNA = clrNa.R; //Console.WriteLine(redNA);
                    //int greenNA = clrNa.G; //Console.WriteLine(greenNA);
                    //int blueNA = clrNa.B; //Console.WriteLine(blueNA);
                   // Console.WriteLine(i);
                    i++;
                }
                
                j++;
                
                //Console.WriteLine(j);
                i = 0;
            }
            

            Bm.Save("C:\\Fotologs\\0woensdag 28 maart 2018na laminatie" + " GROEN " + ".bmp");
            

        }
    }
}
