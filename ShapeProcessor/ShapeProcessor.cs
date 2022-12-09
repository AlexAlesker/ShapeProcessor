namespace ShapeProcessor {

public interface IShape {
    double GetSquare();
}

public static class ShapeProcessor {
    public static double GetSquare(IShape shape) {
        return shape.GetSquare();
    }
}
}