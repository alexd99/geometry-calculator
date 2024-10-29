namespace Shape
{
    class Rectangle : Shape2D
    {
        public override void GetDimensions()
        {
            double length = GetDimension("length", "rectangle");
            double width = GetDimension("width", "rectangle");

            area = length * width;
        }
    }
}
