namespace Shape
{
    public class Triangle : Shape2D
    {
        public override void GetDimensions()
        {
            double triangleBase = GetDimension("base", "triangle");
            double height = GetDimension("height", "triangle");

            area = 0.5 * triangleBase * height;
        }
    }
}
