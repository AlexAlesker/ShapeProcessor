using NUnit.Framework;
using ShapeProcessor.Shapes;
using System;

namespace ShapeProcessor {

[TestFixture]
internal class CircleTestCase {
    [Test]
    public void CircleWrongCreationTest() {
        Assert.Throws<ArgumentException>(() => new Circle(-1));
        Assert.Throws<ArgumentException>(() => new Circle(0));
    }

    [Test]
    public void CircleRightCreationTest() {
        Assert.That(new Circle(1).Radius, Is.EqualTo(1));
    }
}
}