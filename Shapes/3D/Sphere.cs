namespace Shape
{
    public class Sphere : Shape3D
    {
        public override void GetDimensions()
        {
            double radius = GetDimension("radius", "sphere");

            volume = 4.0 / 3.0 * Math.PI * Math.Pow(radius, 3);
            surfaceArea = 4 * Math.PI * Math.Pow(radius, 2);
        }
    }
}
