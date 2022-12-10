using System;
using System.Collections.Generic;
using System.Linq;

namespace ShapeProcessor.Shapes {

public class Triangle : IShape {
    public double A { get; }
    public double B { get; }
    public double C { get; }
    public double Square { get; }
    public bool IsRightTriangle { get; }

    public Triangle(double a, double b, double c) {
        CheckForNegativeOrZero(a);
        CheckForNegativeOrZero(b);
        CheckForNegativeOrZero(c);

        CheckForDegenerateTriangle(a, b, c);
        CheckForDegenerateTriangle(b, a, c);
        CheckForDegenerateTriangle(c, a, b);

        A = a;
        B = b;
        C = c;

        Square = GetSquare();

        var sideLengths = new List<double> { A, B, C }.OrderBy(x => x).ToList();
        // NOTE: possible loss of precision
        IsRightTriangle = Math.Pow(sideLengths[2], 2) == Math.Pow(sideLengths[0], 2) + Math.Pow(sideLengths[1], 2);
    }

    private static void CheckForNegativeOrZero(double x) {
        if (x <= 0) {
            throw new ArgumentException($"Side length {x} can not be less than zero");
        }
    }

    private static void CheckForDegenerateTriangle(double x1, double x2, double x3) {
        if (x1 >= x2 + x3) {
            throw new ArgumentException($"Side length {x1} can not be greater than sum of {x2} and {x3}");
        }
    }

    private double GetSquare() {
        // semiPerimeter
        var p = (A + B + C) / 2;

        // Heron's formula
        return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
    }
}
}
