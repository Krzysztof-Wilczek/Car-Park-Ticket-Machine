// See https://aka.ms/new-console-template for more information
Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.ForegroundColor = ConsoleColor.Gray;
Console.Clear();
Console.WriteLine("Welcome to the car park");
Console.WriteLine("Please enter your car registration");
string registration = Console.ReadLine();
Console.WriteLine("Is this registration correct:" +registration+ "?");
Console.WriteLine("y/n");
string YN = Console.ReadLine();
if (YN == "n")
{
   while(YN == "n")
    {
        Console.WriteLine("Please re-enter your registration");
        registration = Console.ReadLine();
        Console.WriteLine("Is this registration correct:"+registration+ "?");
        YN = Console.ReadLine();
    }
        
}
Console.WriteLine("Please select duration (Press numbers 1-7)");
Console.WriteLine("0 - Up to 30 minutes - £1");
Console.WriteLine("1 - Up to 1 hour - £2");
Console.WriteLine("2 - Up to 2 hours - £3");
Console.WriteLine("3 - Up to 3 hours - £4");
Console.WriteLine("4 - Up to 4 hour - £5");
Console.WriteLine("5 - Up to 6 hours - £6");
Console.WriteLine("6 - Up to 12 hours - £10");
int option = int.Parse(Console.ReadLine());
int[] This = { 1, 2, 3, 4, 5, 6, 10 };
float AmtOwed = This[option];
float Totalpaid = 0;
while(Totalpaid < AmtOwed)
{
    Console.WriteLine("Please enter the required amount £" +(AmtOwed - Totalpaid)+ "");
    float paying = float.Parse(Console.ReadLine());
    Totalpaid+= paying;
    if (Totalpaid < AmtOwed)
    {
        Console.WriteLine("You still need to pay £" + AmtOwed + "");
    }
    else if (Totalpaid > AmtOwed)
    {
        float change = Totalpaid - AmtOwed;
        Console.WriteLine("Here is your change, £" + change + "");
    }
    else
    {
        Console.WriteLine("Thank you for paying");
    }
}