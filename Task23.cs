// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
double res = 0;
for (int i = 1; i <= n-1;) {
    res = Math.Pow(i, 3);
    Console.Write(res + ", ");
    i += 1;
}
Console.WriteLine(Math.Pow(n, 3));