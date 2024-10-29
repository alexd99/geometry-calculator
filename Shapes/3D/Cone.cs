namespace Shape
{
    public class Cone : Shape3D
    {
        public override void GetDimensions()
        {
            double radius = GetDimension("radius", "cone");
            double height = GetDimension("height", "cone");

            surfaceArea =
                Math.PI * radius * (radius + Math.Sqrt(Math.Pow(height, 2) + Math.Pow(radius, 2)));
            volume = Math.PI * Math.Pow(radius, 2) * (height / 3.0);
        }
    }
}
