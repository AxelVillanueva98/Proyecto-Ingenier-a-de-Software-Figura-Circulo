using System;

namespace Application;

public class Circulo
{
    public static double Perimetro(double radio)
    {
        double perimetro = Math.PI * radio * 2;
        return perimetro;
    }
    public static double Area(double radio)
    {
        double area = radio * radio * Math.PI;
        return area;
    }
}