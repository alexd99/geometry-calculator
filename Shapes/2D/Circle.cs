namespace Shape
{
    public class Circle : Shape2D
    {
        public override void GetDimensions()
        {
            double radius = GetDimension("radius", "circle");

            area = Math.PI * Math.Pow(radius, 2);
        }
    }
}
