
/* Détermine si un nombre est d'armstrong ou non */
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

Console.WriteLine("Entrez un nombre : ");

string saisie = Console.ReadLine();
int n = int.Parse(saisie);

Console.WriteLine($"{n} {(armstrong(n) ? "est" : "n'est pas")} un nombre d'Armstrong");
