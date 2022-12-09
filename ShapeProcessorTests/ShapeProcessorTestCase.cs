using NUnit.Framework;
using ShapeProcessor.Shapes;
using System;

namespace ShapeProcessor {

[TestFixture]
internal class ShapeProcessorTestCase {

    [Test]
    public void CircleSquareCalcTest() {
        Assert.That(ShapeProcessor.GetSquare(new Circle(1)), Is.EqualTo(Math.PI));
        Assert.That(ShapeProcessor.GetSquare(new Circle(2)), Is.EqualTo(Math.PI * 2 * 2));
    }

    [Test]
    public void TriangleSquareCalcTest() {
        Assert.That(ShapeProcessor.GetSquare(new Triangle(1, 1, 1)), Is.EqualTo(0.4330127018922193d));
    }
}
}
