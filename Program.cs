using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Konwolucje
{
    class Program
    {
        static void Main(string[] args)
        {
            //var bitmap = new Bitmap("cat_grey.png");
            //var image3 = EditImage.ChangeBitMapToLists(bitmap);

            var image = new List<List<double>>() {
                new List<double>(){0,0,0,0,0,0,0,0,0},
                new List<double>(){0,1,0,0,0,0,0,1,0},
                new List<double>(){0,0,1,0,0,0,1,0,0},
                new List<double>(){0,0,0,1,0,1,0,0,0},
                new List<double>(){0,0,0,0,1,0,0,0,0},
                new List<double>(){0,0,0,1,0,1,0,0,0},
                new List<double>(){0,0,1,0,0,0,1,0,0},
                new List<double>(){0,1,0,0,0,0,0,1,0},
                new List<double>(){0,0,0,0,0,0,0,0,0},
            };
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine('\n');
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(image[i][j] + "  ");
                }
            }
            //var image2 = EditImage.DrawBorder(image, border);
            List<List<List<double>>> listOfImages = new List<List<List<double>>>();
            for (int x = 0; x < Filters.LoadFirstPackOfFilters3().Count; x++)
            {
                
                var image3 = EditImage.Convolution(image, padding: 0, Filters.LoadFirstPackOfFilters4()[x], stride: 1);
                image3 = EditImage.ReLU(image3);
                image3 = EditImage.Pooling(image3, 2, 2);
                image3 = EditImage.Pooling(image3, 2, 2);
                listOfImages.Add(image3);
            }
            





            //var bitmap2 = EditImage.ChangeListsToBitmap(image);
            //var bitmap3 = EditImage.ChangeListsToBitmap(image2);

            //bitmap2.Save("krzyrzyk1.png", ImageFormat.Png);
            //bitmap3.Save("krzyrzyk2.png", ImageFormat.Png);
            Console.ReadKey();
        }
    }
}
