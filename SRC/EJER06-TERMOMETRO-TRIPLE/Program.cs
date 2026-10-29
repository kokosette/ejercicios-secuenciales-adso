//Termómetro triple
//Lea una temperatura en °C, conviértala a °F (°C × 1.8 + 32) y a Kelvin (°C + 273.15), muestre los tres valores.

double c, f, k;
Console.Write("Ingrese los C°: ");
c = Convert.ToDouble(Console.ReadLine());
f = c * 1.8 + 32;
k = c + 273.15;
Console.WriteLine($"La temperatura en F° es de: {f}");
Console.WriteLine($"La temperatura en K° es de: {k}");

