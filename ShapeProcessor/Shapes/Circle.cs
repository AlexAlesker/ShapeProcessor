using System;

namespace ShapeProcessor.Shapes {

public class Circle : IShape {
    public double Radius { get; }

    public Circle(double radius) {
        if (radius <= 0) {
            throw new ArgumentException($"Radius {radius} can not be less than zero");
        }

        Radius = radius;
    }

    public double GetSquare() {
        return Math.PI * Math.Pow(Radius, 2);
    }
}
}
