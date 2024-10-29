namespace Shape
{
    public class RectangularPrism : Shape3D
    {
        public override void GetDimensions()
        {
            double length = GetDimension("length", "rectangular prism");
            double height = GetDimension("height", "rectangular prism");
            double width = GetDimension("width", "rectangular prism");

            surfaceArea = 2 * (length * width + length * height + width * height);
            volume = length * width * height;
        }
    }
}
