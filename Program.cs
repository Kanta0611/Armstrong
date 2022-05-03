using System.Globalization;
// See https://aka.ms/new-console-template for more information
static bool armstrong(int n) {
    int sum = 0;
    int temp = n;
    while (n > 0) {
        int r = n % 10;
        sum += (r * r * r);
        n /= 10;
    }
    if (sum == temp)
        return true;
    else
        return false;
}

int[] numbers = { 153, 370, 371, 407 };

foreach (int n in numbers) {
    Console.WriteLine($"{n} {(armstrong(n) ? "est" : "n'est pas")} un nombre d'Armstrong");
}