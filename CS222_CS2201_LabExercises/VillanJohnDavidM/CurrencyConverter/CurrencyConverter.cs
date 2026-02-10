Console.Write("Enter amount in USD: ");
double amount = double.Parse(Console.ReadLine());

Console.Write("Enter exchange rate from USD to EUR: ");
double rate = double.Parse(Console.ReadLine());

double exchangeAmount = amount * rate;

Console.Write("Amount in EUR: {0:F2}", exchangeAmount);

