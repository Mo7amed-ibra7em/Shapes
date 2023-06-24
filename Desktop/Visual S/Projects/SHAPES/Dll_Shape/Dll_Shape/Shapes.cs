using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dll_Shape
{
    public class Shapes
    {
        public class Circle_Space ////مساحة دائرة
        {
            public static double GetArea(double radius)
            {
                return Math.PI * Math.Pow(radius, 2);
            }
        }
        public class Circle_Circumference ////محيط دائرة
        {
            public static double GetCircumference(double radius)
            {
                return 2 * Math.PI * radius;
            }
        }
        public class Rectangle_Space ////مساحة مستطيل
        {
            public static double GetArea(double width, double height)
            {
                return width * height;
            }
        }
        public class Rectangle_Circumference ////محيط مستطيل
        {
            public static double GetPerimeter(double length, double width)
            {
                return 2 * (length + width);
            }
        }
        public class Triangle_Space ////مساحة مثلث
        {
            public static double GetPerimeter(double a, double b, double c)
            {
                double s = (a + b + c) / 2;
                double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
                return area;
            }
        }
        public class Triangle_Circumference ////محيط مثلث
        {
            public static double GetPerimeter(double a, double b, double c)
            {
                double perimeter = a + b + c;
                return perimeter;
            }
        }
        public class Square_Space ////مساحة مربع
        {
            public static double CalculateSquareArea(double side)
            {
                double area = side * side;
                return area;
            }
        }
        public class Square_Circumference ////محيط مربع
        {
            public static double GetPerimeter(double side)
            {
                double perimeter = 4 * side;
                return perimeter;
            }
        }
        public class Pyramid_TotalSpace////المساحة الكلية والجانبية للهرم المنتظم
        {
            public static double GetPerimeter(double a, double hight)
            {
                double XSpace = Triangle_Space.GetPerimeter(a, a, a);///مساحة القاعدة
                double YCir = (Triangle_Circumference.GetPerimeter(a, a, a) / 2) * hight;///المساحة الجانبية
                return XSpace + YCir;///المساحة الكلية
            }
            public static double MessageGetPerimeter(double a, double hight)
            {
                double YCir = (Triangle_Circumference.GetPerimeter(a, a, a) / 2) * hight;///المساحة الجانبية
                return YCir;
            }
        }
        public class Cone_TotalSpace////المساحة الكلية ومساحة السطح الجانبي للمخروط
        {
            public static double CalculateSlantHeight(double radius, double height)///الارتفاع المائل
            {
                double slantHeight = Math.Sqrt(Math.Pow(radius, 2) + Math.Pow(height, 2));
                return slantHeight;
            }
            public static double lateral_Area(double radius, double Hight)///مساحة السطح الجانبي
            {
                double lateralArea = Math.PI * radius * CalculateSlantHeight(radius, Hight);
                return lateralArea;
            }
            public static double CalculateTotalSurfaceArea(double radius, double Hight)///المساحة الكلية
            {
                double baseArea = Circle_Space.GetArea(radius);
                double totalSurfaceArea = baseArea + lateral_Area(radius, Hight);
                return totalSurfaceArea;
            }
        }
    }
}
