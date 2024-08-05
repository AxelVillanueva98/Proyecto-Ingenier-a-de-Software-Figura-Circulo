double radio = 5;
double altura = 10;
double perimetro = Application.Circulo.Perimetro(radio);
double area = Application.Circulo.Area(radio);
double volumen = Application.Cilindro.Volumen(area, altura);

Console.WriteLine($"El perímetro de la base de un Cilindro de {radio}cm por pi y por 2 es {perimetro}cm");
Console.WriteLine($"El área de la base de un Cilindro de {radio}cm al cuadrado por pi es {area}cm2");
Console.WriteLine($"El volumen un Cilindro con un área de la base de {area}cm2 y {altura}cm de altura es {volumen}cm3");