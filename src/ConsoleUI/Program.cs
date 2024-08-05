// code .\src\ConsoleUI\Program.cs

double perimetro;
double area;
double volumen;

Console.WriteLine("Calculadora de Perímetro, Area y Volumen de un Cilindro");

Console.Write("Dame el radio: ");
double radio = Convert.ToDouble(Console.ReadLine());

Console.Write("Dame la altura: ");
double altura = Convert.ToDouble(Console.ReadLine());

perimetro = Application.Circulo.CalcularPerimetro(radio);
area = Application.Circulo.CalcularArea(radio);

volumen = Application.Cilindro.CalcularVolumen(area, altura);

Console.WriteLine();
Console.WriteLine($"Perímetro: {perimetro}cm\nÁrea: {area}cm2\nVolumen {volumen}cm3");