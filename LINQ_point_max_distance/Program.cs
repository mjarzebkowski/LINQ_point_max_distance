using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography;

namespace LINQ_point_max_distance
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<Point> pointList = new List<Point>(generatePointList(100000));
            List<Point> pointList = new List<Point>();
            pointList = generatePointList(100000);
            //printList(pointList);
            findMax3(pointList);

            Console.ReadKey();
        }


        static List<Point> generatePointList(uint counter)
        {
            Random rnd = new Random();

            List<Point> pointList = new List<Point>();
            for (uint i = 0; i <= counter; i++)
            {
                pointList.Add(new Point((int)i, rnd.Next(), rnd.Next()));
            }
            return pointList;
        }

        static void printList(List<Point> pointList)
        {
            foreach (Point p in pointList)
            {
                Console.WriteLine(p);
            }
        }

        static void findMax3(List<Point> pointList)
        {
            List<Point> maxDistancePoint = new List<Point>();
            maxDistancePoint = from p in pointList where Math.Sqrt((p._X * p._X) + (p._Y * p._Y))  ;
            // Math.Sqrt((Point._X * Point._X) + (Point._Y * Point._Y));
            // Console.WriteLine(p1 + "distance:  " + p2 + "distance:   " + p3 + "distance:   ");
            SELECT TOP 3 FROM pointList WHERE Math.Sqrt((p._X * p._X) + (p._Y * p._Y)) == MAX
            foreach (Point p in pointList)
            {
                Console.WriteLine(p + " distance: " + Math.Sqrt((p._X * p._X) + (p._Y * p._Y)));
            }

            var resoult = 

        }
    }

    internal sealed class Point
    {
        private double X;
        private double Y;
        private int id;

        public Point(int id,double X, double Y)
        {
            this.X = X;
            this.Y = Y;
            this.id = id;
        }

        public double _X { get => X; set => X = value; }
        public double _Y { get => Y; set => Y = value; }
        public int _id { get => id; set => id = value; }

        public override string ToString()
        {
            return string.Format("Point:{0} X:{1} Y:{2}", id, X, Y);
        }

    }
}
