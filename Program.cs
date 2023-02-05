// See https://aka.ms/new-console-template for more information
using static System.Console;

Write("Hello and WELCOME!");
Console.ReadKey();
bool returning = true;
while (returning)
{
    WriteLine("1.Area" + ' ' + "2.Perimeter " + ' ' + "3.Volume" + ' ' + "4.Imaginary Numbers" + ' ' + "5.Quadratic");
    Write("Your Choice:");
    Double MainEntry = Convert.ToDouble(Console.ReadLine());
    if (MainEntry == 1)
    {
        WriteLine("1.RECTANGLE " + ' ' +
                  "2.CIRCLE " + ' ' +
                  "3.Triangle" + ' ' +
                  "4.Cylinder");
        Write("Selection:");
        var entry = Convert.ToDouble(Console.ReadLine());
        if (entry == 1)
        {
            Area.Rectangle();
            ExitandEntry.ExitFunction();
        }

        else if (entry == 2)
        {
            Area.Circle();
            ExitandEntry.ExitFunction();

        }
        else if (entry == 3)
        {
            Area.Triangle();
            ExitandEntry.ExitFunction();
        }
        else if (entry == 4)
        {
            WriteLine("1.Closed" + ' ' + "2.One side Open" + ' ' + "3.Totally Open");
            Write("Selection:");
            var entry3 = Convert.ToDouble(Console.ReadLine());
            if (entry3 == 1)
            {
                Area.ClosedCylinder();
                ExitandEntry.ExitFunction();
            }
            else if (entry3 == 2)
            {
                Area.OneSideOpenCylinder();
                ExitandEntry.ExitFunction();
            }
            else if (entry3 == 3)
            {
                Area.TotallyOpenCylinder();
                ExitandEntry.ExitFunction();
            }
        }
        else Exceptions.Exception1();

    }
    else if (MainEntry == 2)
    {

        WriteLine("1.RECTANGLE " + ' ' +
                  "2.CIRCLE ");
        Write("Selection:");
        Double periEntry = Convert.ToDouble(ReadLine());
        if (periEntry == 1)
        {
            Perimeter.Rectangle();
            ExitandEntry.ExitFunction();
        }
        else if (periEntry == 2)
        {
            Perimeter.Circle();
            ExitandEntry.ExitFunction();
        }
        else Exceptions.Exception1();
    }
    else if (MainEntry == 3)
    {
        WriteLine("1.Prism " + ' ' +
                 "2.Sphere " + ' ' + "3.Pyramid");
        Write("Selection:");
        Double volEntry = Convert.ToDouble(ReadLine());
        if (volEntry == 1)
        {
            WriteLine("1.Cube" + ' ' + "2.Cuboid" + ' ' + "3.Cylinder");
            Write("Selection:");
            Double volEntry2 = Convert.ToDouble(ReadLine());
            if (volEntry2 == 1)
            {
                Volume.squarePrism();
                ExitandEntry.ExitFunction();

            }
            else if (volEntry2 == 2)
            {
                Volume.rectangularPrism();
                ExitandEntry.ExitFunction();
            }
            else if (volEntry2 == 3)
            {
                Volume.Cylinder();
                ExitandEntry.ExitFunction();
            }
            else Exceptions.Exception1();
        }
        else if (volEntry == 2)
        {
            Volume.Sphere();
            ExitandEntry.ExitFunction();
        }
        else if (volEntry == 3)
        {
            WriteLine("1.Square pyramid" + ' ' + "2.Cone" + ' ' + "3.Rectangular pyramid");
            Write("Selection:");
            Double volEntry3 = Convert.ToDouble(ReadLine());
            if (volEntry3 == 1)
            {
                Volume.SquarePyramid();
                ExitandEntry.ExitFunction();
            }
            else if (volEntry3 == 2)
            {
                Volume.Cone();
                ExitandEntry.ExitFunction();
            }
            else if (volEntry3 == 3)
            {
                Volume.RectangularPyramid();
                ExitandEntry.ExitFunction();
            }
            else
                Exceptions.Exception1();
        }
        else Exceptions.Exception1();
    }
    else if (MainEntry == 4)
    {
        WriteLine("1.Addition" + ' ' + "2.Multiplication" + ' ' + "3.Division");
        Write("Your Choice:");
        Double fUserEntry = Convert.ToDouble(ReadLine());
        if (fUserEntry == 1)
        {
            complexNumber.Addition();
            ExitandEntry.ExitFunction();
        }
        else if (fUserEntry == 2)
        {
            complexNumber.Multiplication();
            ExitandEntry.ExitFunction();
        }

        else if (fUserEntry == 3)
        {
            complexNumber.Division();
            ExitandEntry.ExitFunction();
        }


    }
    else
    {
        Exceptions.Exception1();
    }
}


internal class Area
{
    public static void Rectangle()
    {
        Write("Enter the length of your Rectangle:");
        Double length = Convert.ToDouble(ReadLine());
        Write("Enter the width of your Rectangle:");
        Double width = Convert.ToDouble(ReadLine());
        Double AreaofRectangle = length * width;
        WriteLine("The Area of the Rectangle is" + ' ' + AreaofRectangle);
    }

    public static void Circle()
    {
        Double radius = 0;
        Write("Enter the radius of your Circle:");
        radius = Convert.ToDouble(ReadLine());
        Double AreaofCircle = (3.142) * (radius * radius);
        WriteLine("The Area of the Circle is" + ' ' + AreaofCircle);
    }

    public static void Triangle()
    {
        Write("Enter the height of the triangle:");
        Double height = Convert.ToDouble(ReadLine());
        Write("Enter the length of the base:");
        Double baseLength = Convert.ToDouble(ReadLine());
        Double AreaofTriangle = (0.5) * baseLength * height;
        WriteLine("The Area of your triangle is" + ' ' + AreaofTriangle);

    }
    public static void ClosedCylinder()
    {
        Write("Enter the height of the cylinder:");
        Double height = Convert.ToDouble(ReadLine());
        Write("Enter the radius of the base:");
        Double baseradius = Convert.ToDouble(ReadLine());
        Double TotalSurfaceArea = 2 * (3.142) * baseradius * (baseradius + height);
        WriteLine(" The Total Surface Area of your cylinder is:" + ' ' + TotalSurfaceArea);
    }
    public static void OneSideOpenCylinder()
    {
        Write("Enter the height of the cylinder:");
        Double height = Convert.ToDouble(ReadLine());
        Write("Enter the radius of the base:");
        Double baseradius = Convert.ToDouble(ReadLine());
        Double TotalSurfaceArea = (3.142) * baseradius * (baseradius + (2 * height));
        WriteLine(" The Total Surface Area of your cylinder is:" + ' ' + TotalSurfaceArea);
    }
    public static void TotallyOpenCylinder()
    {
        Write("Enter the height of the cylinder:");
        Double height = Convert.ToDouble(ReadLine());
        Write("Enter the radius of the base:");
        Double baseradius = Convert.ToDouble(ReadLine());
        Double TotalSurfaceArea = (3.142) * baseradius * 2 * height;
        WriteLine(" The Total Surface Area of your cylinder is:" + ' ' + TotalSurfaceArea);
    }
}
internal class Perimeter
{
    public static void Rectangle()
    {
        Write("Enter the length of your Rectangle:");
        Double length = Convert.ToDouble(ReadLine());
        Write("Enter the width of your Rectangle:");
        Double width = Convert.ToDouble(ReadLine());
        Double PerimeterofRectangle = 2 * (length + width);
        WriteLine("The Perimeter of the Rectangle is" + ' ' + PerimeterofRectangle);
    }
    public static void Circle()
    {
        Write("Enter the radius of your Circle:");
        Double radius = Convert.ToDouble(ReadLine());
        _ = radius * 2;
        Double Circumferenceofcircle = 3.142 * radius * 2;
        WriteLine("The Circumference of the Circle is" + ' ' + Circumferenceofcircle);
    }
}
internal class Volume
{
    public static void squarePrism()
    {
        Write("Enter the Length of the base:");
        Double lengthOfBase = Convert.ToDouble(ReadLine());
        Write("Enter the Height of the Prism:");
        Double heightOfPrism = Convert.ToDouble(ReadLine());
        Double VolumeOfPrism = (lengthOfBase * lengthOfBase) * heightOfPrism;
        WriteLine("The Volume of Your Cube is:" + ' ' + VolumeOfPrism);

    }
    public static void rectangularPrism()
    {
        Write("Enter the Length of the base:");
        Double lengthOfBase = Convert.ToDouble(ReadLine());
        Write("Enter the Width of the Base:");
        Double widthOfBase = Convert.ToDouble(ReadLine());
        Write("Enter the Height of the Cuboid:");
        Double heightOfPrism = Convert.ToDouble(ReadLine());
        Double VolumeOfPrism = (lengthOfBase * widthOfBase) * heightOfPrism;
        WriteLine("The Volume of Your Cuboid is:" + ' ' + VolumeOfPrism);

    }
    public static void triangularPrism()
    {


    }
    public static void SquarePyramid()
    {
        Write("Enter the Length of the base:");
        Double lengthOfBase = Convert.ToDouble(ReadLine());
        Write("Enter the Width of the Base:");
        Double widthOfBase = Convert.ToDouble(ReadLine());
        Write("Enter the Height of the Pyramid:");
        Double heightOfPrism = Convert.ToDouble(ReadLine());
        Double VolumeOfPrism = (0.33) * (lengthOfBase * widthOfBase) * heightOfPrism;
        WriteLine("The Volume of Your Pyramid is:" + ' ' + VolumeOfPrism);
    }
    public static void Sphere()
    {
        Write("Enter the radius of Sphere:");
        Double radiusOfSphere = Convert.ToDouble(ReadLine());
        Double VolumeOfPrism = (3.142 * radiusOfSphere * radiusOfSphere) * (1.33);
        WriteLine("The Volume of Your Sphere is:" + ' ' + VolumeOfPrism);
    }
    public static void Cylinder()
    {
        Write("Enter the radius of the base:");
        Double radiusOfBase = Convert.ToDouble(ReadLine());
        Write("Enter the Height of the Cylinder:");
        Double heightOfPrism = Convert.ToDouble(ReadLine());
        Double VolumeOfPrism = (3.142 * radiusOfBase * radiusOfBase) * (heightOfPrism);
        WriteLine("The Volume of Your Cylinder is:" + ' ' + VolumeOfPrism);
    }
    public static void RectangularPyramid()
    {
        Write("Enter the Length of the base:");
        Double lengthOfBase = Convert.ToDouble(ReadLine());
        Write("Enter the Width of the Base:");
        Double widthOfBase = Convert.ToDouble(ReadLine());
        Write("Enter the Height of the Pyramid:");
        Double heightOfPrism = Convert.ToDouble(ReadLine());
        Double VolumeOfPrism = (0.33) * (lengthOfBase * widthOfBase) * heightOfPrism;
        WriteLine("The Volume of Your Pyramid is:" + ' ' + VolumeOfPrism);
    }
    public static void Cone()
    {
        Double radiusOfBase = 0;
        Double heightOfPrism = 0;
        Write("Enter the radius of the base:");
        radiusOfBase = Convert.ToDouble(ReadLine());
        Write("Enter the Height of the Cone:");
        heightOfPrism = Convert.ToDouble(ReadLine());
        Double VolumeOfPrism = (0.33) * (3.142 * radiusOfBase * radiusOfBase * heightOfPrism);
        WriteLine("The Volume of Your Cone is:" + ' ' + VolumeOfPrism);
    }

}
internal class ExitandEntry
{
    public static void ExitFunction()
    {
        bool returning = true;
        Write("Press '1' To start over or '2' to exit: ");
        var entry2 = 0;
        entry2 = Convert.ToInt32(ReadLine());
        if (entry2 == 1)
        {
            returning = true;
        }
        else if (entry2 == 2)
        {
            Environment.Exit(0);
        }
    }
}
internal class Exceptions
{
    public static void Exception1()
    {
        WriteLine("Please the Input was wrong! ");
        WriteLine(" Enter the correct Input");
    }
}
internal class complexNumber
{
    public static void Division()
    {
        Write("Enter first real part:");
        Double fRealPart = (Double)Convert.ToDouble(ReadLine());
        Write("Enter First Imaginary:");
        Double sRealPart = (Double)Convert.ToDouble(ReadLine());
        Write("Enter Second Real Part:");
        Double fImaginaryPart = Convert.ToDouble(ReadLine());
        Write("Enter Second Imaginary part:");
        Double sImaginaryPart = Convert.ToDouble(ReadLine());
        Double Quotient1 = (sImaginaryPart * sImaginaryPart) + (fImaginaryPart * fImaginaryPart);
        Double Quotient2 = ((fRealPart * fImaginaryPart) + (sRealPart * sImaginaryPart));
        Double Quotient3 = (-1 * ((fRealPart * sImaginaryPart) - (sRealPart * fImaginaryPart)));
        WriteLine("Your final Answer is:" + ' ' + Quotient2 + ' ' + "/" + Quotient1 + ' ' + Quotient3 + "i" + ' ' + "/" + Quotient1);
        WriteLine("Do you want the real Parts and Imaginary Part?");
        Write("If Yes press '1', If No press '2':");
        Double UserEntry = (Double)Convert.ToDouble(ReadLine());
        if (UserEntry == 1)
        {
            WriteLine("Real Part is :" + Quotient2 + ' ' + "/" + Quotient1);
            WriteLine("Imaginary Part is:" + Quotient3 + "i" + ' ' + "/" + Quotient1);

        }
        else if (UserEntry == 2)
        {
            ExitandEntry.ExitFunction();

        }
        else Exceptions.Exception1();


    }
    public static void Addition()
    {
        Write("Enter first real part:");
        Double fRealPart = (Double)Convert.ToDouble(ReadLine());
        Write("Enter First Imaginary:");
        Double fImaginaryPart = (Double)Convert.ToDouble(ReadLine());
        Write("Enter Second Real Part:");
        Double sRealPart = Convert.ToDouble(ReadLine());
        Write("Enter Second Imaginary part:");
        Double sImaginaryPart = Convert.ToDouble(ReadLine());
        Double Sum1 = fRealPart + sRealPart;
        Double Sum2 = fImaginaryPart + sImaginaryPart;
        WriteLine("Your final Answer is:" + ' ' + Sum1 + "+" + Sum2 + "i");
        WriteLine("Do you want the real Parts and Imaginary Part?");
        Write("If Yes press '1', If No press '2':");
        Double UserEntry = (Double)Convert.ToDouble(ReadLine());
        if (UserEntry == 1)
        {
            WriteLine("Real Part is :" + Sum1);
            WriteLine("Imaginary Part is:" + Sum2 + "i");

        }
        else if (UserEntry == 2)
        {
            ExitandEntry.ExitFunction();

        }
        else Exceptions.Exception1();
    }
    public static void Multiplication()
    {
        Write("Enter first real part:");
        Double fRealPart = (Double)Convert.ToDouble(ReadLine());
        Write("Enter First Imaginary:");
        Double fImaginaryPart = (Double)Convert.ToDouble(ReadLine());
        Write("Enter Second Real Part:");
        Double sRealPart = Convert.ToDouble(ReadLine());
        Write("Enter Second Imaginary part:");
        Double sImaginaryPart = Convert.ToDouble(ReadLine());
        Double Quotient1 = (fRealPart * sRealPart) - (fImaginaryPart * sImaginaryPart);
        Double Quotient2 = ((fImaginaryPart * sRealPart) + (fRealPart * sImaginaryPart));
        WriteLine("Your final Answer is:" + ' ' + Quotient1 + "+" + Quotient2 + "i");
        WriteLine("Do you want the real Parts and Imaginary Part?");
        Write("If Yes press '1', If No press '2':");
        Double UserEntry = (Double)Convert.ToDouble(ReadLine());
        if (UserEntry == 1)
        {
            WriteLine("Real Part is :" + Quotient1);
            WriteLine("Imaginary Part is:" + Quotient2 + "i");

        }
        else if (UserEntry == 2)
        {
            ExitandEntry.ExitFunction();

        }
        else Exceptions.Exception1();
    }
}
internal class Quadratic
{
    public static void roots()
    {

    }
    public static void solution()
    {

    }
    public static void stateOfSolution()
    {

    }
}