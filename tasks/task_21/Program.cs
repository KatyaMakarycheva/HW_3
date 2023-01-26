// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84

int Xa = 3, Ya = 6, Za = 8;
int Xb = 2, Yb = 1, Zb = -7;

double Distance = GetDistance(Xa, Ya, Za, Xb, Yb, Zb);

double GetDistance(int Xa, int Ya, int Za, int Xb, int Yb, int Zb)
{
    return Math.Sqrt((Xb - Xa) * (Xb - Xa) + (Yb - Ya) * (Yb - Ya) + (Zb - Za) * (Zb - Za));
}

System.Console.WriteLine(Distance);