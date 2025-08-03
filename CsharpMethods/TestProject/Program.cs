// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

double total =0;
double minimumSpend = 30.00;

double[] items = { 15.97, 3.50, 12.25, 22.99, 10.98 };
double[] discounts = { 0.30,0.00, 0.10,0.20, 0.50};



for(int i=0; i< items.Length; i++)
{
    total += getDiscounterPrice(i);
}

total -= totalMeetsMinimum() ? 5.00 : 0.00;

Console.WriteLine($"Total: ${formatDecimal(total)}");

double getDiscounterPrice(int itemIndex)
{
    return items[itemIndex] * (1 - discounts[itemIndex]);
    //return result;
}

bool totalMeetsMinimum()
{
    return total >= minimumSpend;
}

string formatDecimal(double input)
{
    return input.ToString().Substring(0, 5);
}