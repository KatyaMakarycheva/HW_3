// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84

double GetDistance(double Xa, double Ya, double Za, double Xb, double Yb, double Zb)
{
    return Math.Sqrt(Math.Pow(Xb - Xa, 2) + 
                     Math.Pow(Yb - Ya, 2) + 
                     Math.Pow(Zb - Za,2));
}

double GetNumber(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToDouble(Console.ReadLine());
}

double Xa = GetNumber("Xa = ");  
double Ya = GetNumber("Ya = ");  
double Za = GetNumber("Za = ");  
double Xb = GetNumber("Xb = ");  
double Yb = GetNumber("Yb = ");  
double Zb = GetNumber("Zb = ");

double Distance = GetDistance(Xa, Ya, Za, Xb, Yb, Zb);

System.Console.WriteLine(Distance);