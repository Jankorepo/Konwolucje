using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konwolucje
{
    public static class EditImage
    {
        //public static List<List<double>> DrawBorder(List<List<double>> image, int borderSize)
        //{
        //    List<List<double>> newImage = new List<List<double>>();
        //    for (int i = 0; i < image.Count; i++)
        //    {
        //        newImage.Add(new List<double>());
        //        for (int j = 0; j < image.Count; j++)
        //        {
        //            newImage[i].Add(image[i][j]);
        //        }
        //    }
        //    for (int i = 0; i < borderSize; i++)
        //    {
        //        newImage.Insert(0, new List<double>(new double[image[0].Count]));
        //        newImage.Add(new List<double>(new double[image[0].Count]));
        //    }
        //    for (int i = 0; i < newImage.Count; i++)
        //    {
        //        for (int j = 0; j < borderSize; j++)
        //        {
        //            newImage[i].Insert(0, 0);
        //            newImage[i].Add(0);
        //        }
        //    }
        //    return newImage;
        //}

        internal static List<List<double>> Pooling(List<List<double>> image, int maxPoolingSize, int stride)
        {
            var size = image.Count % 2 == 1 ? image.Count + 1 : image.Count;
            var imageAfterPooling = new List<List<double>>();
            for (int i = 1; i < size; i += stride)
            {
                imageAfterPooling.Add(new List<double>());
                for (int j =1; j < size; j += stride)
                {
                    double highestValue = ChooseHighestValue(i, j, image, maxPoolingSize);
                    imageAfterPooling.Last().Add(highestValue);
                }
            }
            return imageAfterPooling;
        }

        private static double ChooseHighestValue(int i, int j, List<List<double>> image,int maxPoolingSize)
        {
            List<double> values = new List<double>();
            for (int x = 0; x < maxPoolingSize; x++)
            {
                for (int y = 0; y < maxPoolingSize; y++)
                {
                    int imageX = i - (maxPoolingSize / 2) + x;
                    int imageY = j - (maxPoolingSize / 2) + y;
                    if(imageX<image.Count && imageY<image[0].Count)
                        values.Add(image[imageX][imageY]);
                    else
                        values.Add(0);
                }
            }
            return values.Max();
        }



        public static List<List<double>> ReLU(List<List<double>> image)
        {
            for (int i = 0; i < image.Count; i++)
                for (int j = 0; j < image[0].Count; j++)
                    image[i][j] = image[i][j] < 0 ? 0: image[i][j];
            return image;
        }




        //public static List<List<double>> ChangeBitMapToLists(Bitmap bitmap)
        //{
        //    var imageAsLists = new List<List<double>>();
        //    for (int y = 0; y < bitmap.Height; y++)
        //    {
        //        imageAsLists.Add(new List<double>());
        //        for (int x = 0; x < bitmap.Width; x++)
        //        {
        //            Color c = bitmap.GetPixel(x, y);
        //            double rgb = (double)Math.Round(.299 * c.R + .587 * c.G + .114 * c.B);
        //            imageAsLists[y].Add(rgb);
        //        }
        //    }
        //    return imageAsLists;
        //}
        public static Bitmap ChangeListsToBitmap(List<List<double>> image)
        {
            var bitmap = new Bitmap(image.Count, image[0].Count);
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    int value = Convert.ToInt32(image[x][y]);
                    bitmap.SetPixel(y, x, Color.FromArgb(255,value,value,value));
                }
            }
            return bitmap;
        }
        public static List<List<double>> Convolution(List<List<double>> image,int padding, List<List<double>> filter, int stride)
        {
            var newImage = new List<List<double>>();
            for (int i = filter.Count / 2; i < image.Count-padding; i+=stride)
            {
                newImage.Add(new List<double>());
                for (int j =filter.Count/2; j < image[0].Count-padding; j+=stride)
                {
                    List<List<double>> matrix = CreateTmpMatrix(i, j, image, filter.Count);
                    double sum = MultiplicationOfMatrices(matrix,filter);
                    newImage.Last().Add(sum);
                }
            }
            return newImage;
        }
        private static List<List<double>> CreateTmpMatrix(int i, int j, List<List<double>> image, int matrixSize)
        {
            List<List<double>> matrix = new List<List<double>>();
            for (int x = 0; x < matrixSize; x++)
            {
                matrix.Add(new List<double>());
                for (int y = 0; y < matrixSize; y++)
                    matrix.Last().Add(image[i - matrixSize / 2 + x][j - matrixSize / 2 + y]);
            }
            return matrix;
        }

        public static double MultiplicationOfMatrices(List<List<double>> matrix, List<List<double>> filter)
        {
            double sum =0;
            int size = matrix.Count;
            for (int x = 0; x < size; x++)
                for (int y = 0; y < size; y++)
                    sum += matrix[x][y] * filter[x][y];
            return sum/(size*size);
        }
    }
}
