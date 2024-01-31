// See https://aka.ms/new-console-template for more information
using TollFeeCalculator;
using TollFeeCalculator.Models;

var calc = new TollCalculator();

var vehicle = string.Empty;

while (string.IsNullOrEmpty(vehicle))
{
    Console.WriteLine("Please choose vehicle type: (car or motorbike)");
    var line = Console.ReadLine();
    if (!string.IsNullOrEmpty(line) && (line == "car" || line == "motorbike"))
    {
        vehicle = line!.ToLower();
    }
}

var dateTimes = new List<DateTime>();
while (true) // Loop indefinitely
{
    Console.WriteLine("Please type \"result\" to see the fee");
    Console.WriteLine("Please enter date and time in format: YYYY/MM/dd, hh:mm");
    var line = Console.ReadLine();
    if (!string.IsNullOrEmpty(line))
    {
        if (line!.ToLower() == "result")
        {
            if (vehicle == "car")
            {
                Console.WriteLine("Fee is: " + calc.GetTollFee(new Car(), dateTimes.ToArray()));
            }
            else if (vehicle == "motorbike")
            {
                Console.WriteLine("Fee is: " + calc.GetTollFee(new Motorbike(), dateTimes.ToArray()));
            }
            break;
        }
        else
        {
            if (DateTime.TryParse(line, out DateTime dateTime))
            {
                dateTimes.Add(dateTime);
            }
            else
            {
                Console.WriteLine("Wrong! Please try again");
            }
        }
    }
    
}

Console.WriteLine("Thank you. Bye :)");
Console.ReadKey();