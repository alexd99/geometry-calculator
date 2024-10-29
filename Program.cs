using System;

namespace GeometryCalculator
{
    class Program
    {
        static void Main()
        {
            // Print the banner with ASCII art
            PrintBanner();
            Console.WriteLine("Welcome to the Geometry Calculator!");

            int option = -1;
            while (option != 0)
            {
                // Display the main menu
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1) Calculate 2D Shape");
                Console.WriteLine("2) Calculate 3D Shape");
                Console.WriteLine("0) Exit");
                Console.Write("Enter your choice: ");

                // Parse the user's input
                if (int.TryParse(Console.ReadLine(), out option))
                {
                    switch (option)
                    {
                        case 1:
                            // Handle 2D shape calculations
                            var selectedShape2D = createOptionMenu(shapesArray2D);
                            if (selectedShape2D.Key != null)
                            {
                                selectedShape2D.Value.GetDimensions();
                                selectedShape2D.Value.PrintArea();
                            }
                            break;
                        case 2:
                            // Handle 3D shape calculations
                            var selectedShape3D = createOptionMenu(shapesArray3D);
                            if (selectedShape3D.Key != null)
                            {
                                selectedShape3D.Value.GetDimensions();
                                selectedShape3D.Value.PrintSurfaceArea();
                                selectedShape3D.Value.PrintVolume();
                            }
                            break;
                        default:
                            // Handle invalid option
                            Console.WriteLine("Invalid option. Please try again.");
                            break;
                    }
                    Console.WriteLine();
                }
                else
                {
                    // Handle invalid input
                    Console.WriteLine("Invalid input. Please enter a valid option.");
                }
            }
            Console.WriteLine("Good Bye ...");
        }

        // Creates and displays a menu for selecting a shape, returns the selected shape
        private static KeyValuePair<string, T> createOptionMenu<T>(
            KeyValuePair<string, T>[] shapesArray
        )
        {
            Console.WriteLine("");
            Console.WriteLine("Select a shape:");
            // Loops over each shape in the shape array and makes a menu option for it
            for (int i = 0; i < shapesArray.Length; i++)
            {
                Console.WriteLine($"{i + 1}) {shapesArray[i].Key}");
            }
            Console.Write("Enter your choice: ");

            // Parse the user's input for shape selection
            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                // checks if the option selected is a valid selection, and is in the range of the provided menu options
                if (choice >= 1 && choice <= shapesArray.Length)
                {
                    Console.WriteLine();
                    return shapesArray[choice - 1];
                }
                else
                {
                    // Handle invalid input
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            }
            else
            {
                // Handle invalid input
                Console.WriteLine("Invalid input. Please enter a valid choice.");
            }

            return default;
        }

        // Prints the banner with ASCII art
        private static void PrintBanner()
        {
            Console.WriteLine(
                "   ____                           _                 ____      _            _       _             "
            );
            Console.WriteLine(
                "  / ___| ___  ___  _ __ ___   ___| |_ _ __ _   _   / ___|__ _| | ___ _   _| | __ _| |_ ___  _ __ "
            );
            Console.WriteLine(
                " | |  _ / _ \\/ _ \\| '_ ` _ \\ / _ \\ __| '__| | | | | |   / _` | |/ __| | | | |/ _` | __/ _ \\| '__|"
            );
            Console.WriteLine(
                " | |_| |  __/ (_) | | | | | |  __/ |_| |  | |_| | | |__| (_| | | (__| |_| | | (_| | || (_) | |   "
            );
            Console.WriteLine(
                "  \\____|\\___|\\___/|_| |_| |_|\\___|\\__|_|   \\__, |  \\____\\__,_|_|\\___|\\__,_|_|\\__,_|\\__\\___/|_|   "
            );
            Console.WriteLine(
                "                                           |___/                                                 "
            );
            Console.WriteLine();
        }

        // Array of key-value pairs for 2D shapes
        static KeyValuePair<string, Shape.Shape2D>[] shapesArray2D =
        {
            new KeyValuePair<string, Shape.Shape2D>("Rectangle", new Shape.Rectangle()),
            new KeyValuePair<string, Shape.Shape2D>("Triangle", new Shape.Triangle()),
            new KeyValuePair<string, Shape.Shape2D>("Circle", new Shape.Circle()),
            new KeyValuePair<string, Shape.Shape2D>("Trapezoid", new Shape.Trapezoid())
        };

        // Array of key-value pairs for 3D shapes
        static KeyValuePair<string, Shape.Shape3D>[] shapesArray3D =
        {
            new KeyValuePair<string, Shape.Shape3D>(
                "Rectangle Prism",
                new Shape.RectangularPrism()
            ),
            new KeyValuePair<string, Shape.Shape3D>("Sphere", new Shape.Sphere()),
            new KeyValuePair<string, Shape.Shape3D>("Cone", new Shape.Cone()),
            new KeyValuePair<string, Shape.Shape3D>(
                "Rectangular Pyramid",
                new Shape.RectangularPyramid()
            )
        };
    }
}
