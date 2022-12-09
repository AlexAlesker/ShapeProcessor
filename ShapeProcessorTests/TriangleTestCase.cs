using System;
using NUnit.Framework;
using ShapeProcessor.Shapes;

namespace ShapeProcessor {

[TestFixture]
internal class TriangleTestCase {
    [Test]
    public void TriangleWrongCreationTest1() {
        Assert.Throws<ArgumentException>(() => new Triangle(-1, 1, 1));
        Assert.Throws<ArgumentException>(() => new Triangle(1, -1, 1));
        Assert.Throws<ArgumentException>(() => new Triangle(1, 1, -1));
    }

    [Test]
    public void TriangleWrongCreationTest2() {
        Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 3));
    }

    [Test]
    public void TriangleRightCreationTest() {
        var triangle = new Triangle(1, 1, 1);
        Assert.That(triangle.A, Is.EqualTo(1));
        Assert.That(triangle.B, Is.EqualTo(1));
        Assert.That(triangle.C, Is.EqualTo(1));
    }
}
}
