namespace ShapeProcessor {

public interface IShape {
    double Square { get; }
}

public static class ShapeProcessor {
    public static double GetSquare(IShape shape) {
        return shape.Square;
    }
}
}