namespace Shape
{
    // Base abstract class for all shapes
    public abstract class Shape
    {
        // Method to get the dimension of the shape from the user
        public double GetDimension(string dimensionName, string shape)
        {
            Console.Write($"What is the {dimensionName} of the {shape}: ");
            double dimension = double.Parse(Console.ReadLine() ?? "0");
            return dimension;
        }

        // Abstract method to get the dimensions of the shape
        public abstract void GetDimensions();
    }

    // Base abstract class for all 2d shapes
    public abstract class Shape2D : Shape
    {
        // Property to store the area of the shape
        public double area { get; set; }

        // Method to print the area of the shape
        public void PrintArea()
        {
            Console.WriteLine($"Area: {area:F2}");
        }
    }

    // Base abstract class for all 3d shapes
    public abstract class Shape3D : Shape
    {
        // Property to store the surface area of the shape
        public double surfaceArea { get; set; }

        // Property to store the volume of the shape
        public double volume { get; set; }

        // Method to print the surface area of the shape
        public void PrintSurfaceArea()
        {
            Console.WriteLine($"Surface Area: {surfaceArea:F2}");
        }

        // Method to print the volume of the shape
        public void PrintVolume()
        {
            Console.WriteLine($"Volume: {volume:F2}");
        }
    }
}
