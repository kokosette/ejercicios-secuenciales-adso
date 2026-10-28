//Intercambio con variable auxiliar
//Lea dos números enteros y guárdelos en las variables a y b. Luego intercambie sus contenidos, de modo que a quede con el valor original de b y b con el de a.
//Solo puede usar una variable adicional. Muestre el resultado.
//c será el intercambio
int a, b, c;
Console.Write("Escriba el valor de a: ");
a= Convert.ToInt32(Console.ReadLine());
Console.Write("Escriba el valor de b: ");
b=Convert.ToInt32(Console.ReadLine());

c = a;
a = b;
b = c;

Console.Write($"El intercambio es: a = {a}, b = {c}");
