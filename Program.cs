class HeightCategory
{
    /// <summary>
    /// Height categories:
    /// Height is less than 150 cm = "Short"
    /// Height is between 150 cm and 165 cm = "Average height"
    /// Height is between 165 cm and 195 cm = "Tall"
    /// Height is above 195 cm = "Very tall"
    /// Note: 1 inch = 2.54 centimeter
    /// You need to convert the input value(inches) into centimeters.
    /// </summary>
    static void Main()
    {

        decimal heightInInches = 0;

        System.Console.Write("Enter height in inches using a period to separate decimals: ");
        string heightInput = System.Console.ReadLine();

        // display error message if input not a number
        if (!System.Decimal.TryParse(heightInput, out heightInInches))
        {
            System.Console.WriteLine("Wrong input");
        }
        else
        // process height from inches to centimeters
        {
            // System.Console.WriteLine("Height in inches is " + heightInInches);

            decimal heightInCm = heightInInches * (decimal)2.54;
            // System.Console.WriteLine("Height in cm is " + heightInCm);

            // Height is less than 150 cm = "Short"
            if (heightInCm < 150)
            {
                System.Console.WriteLine("Short: " + heightInCm + " cm");
            }

            // Height is between 150 cm and 165 cm = "Average height"
            else if (heightInCm >= 150 && heightInCm < 165 ) {
                System.Console.WriteLine("Average height " + heightInCm + " cm");
            }

            // Height is between 165 cm and 195 cm = "Tall"
            else if ((heightInCm >= 165 && heightInCm <= 195))
            {
                System.Console.WriteLine("Tall " + heightInCm + " cm");
            }

            // Height is above 195 cm = "Very tall"
            else
            {
                System.Console.WriteLine("Very tall " + heightInCm + " cm");
            }
        }

        // press any key to end program running in console
        System.Console.WriteLine("Press any key to end program.");
        System.Console.ReadKey();
    }
}
