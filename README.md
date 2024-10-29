# Overview

To further my learning as a software engineer, I wrote this geometry calculator in C#. I find geometry fascinating and wanted to build a tool to deepen my understanding of both Object-Oriented Programming and the C# language. This project allowed me to explore key object-oriented programming concepts such as abstraction and inheritance. The geometry calculator I developed is a versatile tool designed to perform various geometric calculations. It supports calculations for different shapes, such as circles, rectangles, spheres, and more. The calculator can compute properties like area, and volume (for 3D shapes).

## Key Features

- User Interface: A console-based user interface that prompts users to select a shape and enter the necessary dimensions.
- Shape Classes: Abstract base class Shape from which specific shape classes like Circle, Rectangle, and Sphere inherit.
- Calculations: Methods to calculate properties like area and volume, implemented in the derived classes.
- Input Validation: Ensures users enter valid data for calculations.
- Extensibility: Easily add new shapes and calculations by extending the existing class hierarchy.

## Purpose and Learning Goals

- Understanding C#: As someone new to C#, I aimed to become familiar with its syntax and core features.
- Object-Oriented Programming: By using abstract classes and inheritance, I wanted to solidify my understanding of these key OOP concepts.
- Practical Application: Applying theoretical knowledge to a real-world problem, thereby reinforcing my learning through practice.
- Problem-Solving Skills: Enhancing my ability to design and implement a solution to a specific problem using programming.

By building this geometry calculator, I achieved a deeper understanding of C# and object-oriented programming while also creating a useful tool.

# Development Environment

This app is written in c#, and only uses the standard c# libraries. The dotnet framework is also used for building and running the app.

The app can be build using dotnet on the top level of the project using: `dotnet build`. After the build is complete the built code can found in the `/bin/Debug/net8.0`.

# Useful Websites

- [C# Docs](https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/)
- [How to set up .Net](https://learn.microsoft.com/en-us/dotnet/core/install/macos)