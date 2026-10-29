double a, p, r;
Console.Write("Ingrese el valor del radio: ");
r = Convert.ToDouble(Console.ReadLine());
a = Math.PI * Math.Pow(r, 2);
p = 2 * Math.PI * r;

Console.WriteLine($"El área del círculo es: {a}");
Console.WriteLine($"El perímetro del círculo es: {p}");
