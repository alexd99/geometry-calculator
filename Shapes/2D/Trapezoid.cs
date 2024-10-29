namespace Shape
{
    public class Trapezoid : Shape2D
    {
        public override void GetDimensions()
        {
            double base1 = GetDimension("length of base 1", "trapezoid");
            double base2 = GetDimension("length of base 2", "trapezoid");
            double height = GetDimension("height", "trapezoid");

            area = (base1 + base2) / 2 * height;
        }
    }
}
