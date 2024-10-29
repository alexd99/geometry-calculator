namespace Shape
{
    public class RectangularPyramid : Shape3D
    {
        public override void GetDimensions()
        {
            double length = GetDimension("length", "rectangular pyramid");
            double width = GetDimension("width", "rectangular pyramid");
            double height = GetDimension("height", "rectangular pyramid");

            surfaceArea =
                length * width
                + length * Math.Sqrt(Math.Pow(width / 2.0, 2) + Math.Pow(height, 2))
                + width * Math.Sqrt(Math.Pow(length / 2.0, 2) + Math.Pow(height, 2));
            volume = length * width * height / 3;
        }
    }
}
