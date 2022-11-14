using GuestNumberRefractoring.IteratorPattern;

Console.WriteLine("Wish number between 0 and 100: and i guess it in 7 steps!\n" +
        "Enter any value to continue:");

StepCollection collection = new (new (GetUserInputNumber()));
foreach (var element in collection)
{
    Console.WriteLine(element);
}

static int GetUserInputNumber(){
    int inputNumber;
    while (!int.TryParse(Console.ReadLine(), out inputNumber) && inputNumber < 0 && inputNumber > 100)
    {
        Console.WriteLine("Please enter correct number between 0 and 100");
    }
    return inputNumber;
}