//Promedio ponderado (25 / 35 / 40)
//En un programa de formación, la nota definitiva se calcula así: el primer corte vale 25 %, el segundo 35 % y el tercero 40 %.
//Lea las tres notas y muestre la definitiva.

double nota1, nota2, nota3, promedio;
Console.Write("Ingrese la nota del primer corte: ");
nota1=Convert.ToDouble(Console.ReadLine());
Console.Write("Ingrese la nota del segundo corte: ");
nota2=Convert.ToDouble(Console.ReadLine());
Console.Write("Ingrese la nota del tercer corte: ");
nota3=Convert.ToDouble(Console.ReadLine());

promedio = (nota1 * 0.25) + (nota2 * 0.35) + (nota3 * 0.40);

Console.Write($"El promedio ponderado es de: {promedio}");

