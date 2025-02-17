// GeometryLibrary.cs - библиотека для расчета площадей геометрических фигур
using System;
using System.Text.RegularExpressions;

namespace GeometryLibrary
{
    public static class Geometry
    {
        public static double SquareArea(double side) => side * side;
        public static double RectangleArea(double width, double height) => width * height;
        public static double TriangleArea(double baseLength, double height) => 0.5 * baseLength * height;
    }
}
