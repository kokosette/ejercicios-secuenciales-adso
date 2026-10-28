//Intercambio sin variable auxiliar
//El mismo reto anterior, pero prohibido usar variables adicionales: solo las variables a y b, operaciones aritméticas y asignaciones. Sí se puede. Descúbralo.
int a, b;
Console.Write("Ingrese el valor de a: ");
a= Convert.ToInt32(Console.ReadLine());
Console.Write("Ingrese el valor de b: ");
b= Convert.ToInt32(Console.ReadLine());

a = a + b;
b = a - b;
a = a - b;

Console.WriteLine($"Los valores intercambiados quedarían como: a = {a}, b = {b}");