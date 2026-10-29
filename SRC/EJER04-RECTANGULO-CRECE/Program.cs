//El rectángulo que crece
//Lea base y altura, muestre área y perímetro
//Luego calcule cuál sería el área si la base se duplicara y la altura se triplicara

double baserect, altura, area, perímetro, areabase, alturatriple;
Console.Write("Ingrese la base del rectángulo: ");
baserect = Convert.ToDouble(Console.ReadLine());
Console.Write("Ingrese la altura del rectángulo: ");
altura = Convert.ToDouble(Console.ReadLine());
area = baserect * altura;
perímetro = 2 * (baserect + altura);
Console.WriteLine($"El área del rectángulo es: {area}");
Console.WriteLine($"El perímetro del rectángulo es: {perímetro}");
areabase = 2 * baserect;
alturatriple = 3 * altura;
Console.WriteLine($"El área del rectángulo con la base duplicada: {areabase}");
Console.WriteLine($"El área del rectángulo con la altura triplicada es: {alturatriple}");