using System;

struct Vector
{
    public float x;
    public float y;
    public float z;

    public Vector(float x, float y, float z) //конструктор
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public static Vector operator +(Vector a, Vector b) //оператор сложения векторов
    {
        return new Vector(a.x + b.x, a.y + b.y, a.z + b.z);
    }

    public static float operator *(Vector a, Vector b) //оператор умножения (скалярное)
    {
        return a.x * b.x + a.y * b.y + a.z * b.z;
    }

    public static Vector operator *(Vector a, float n) //умножение вектора на число
    {
        return new Vector(a.x * n, a.y * n, a.z * n);
    }

    public static Vector operator *(float n, Vector v1)
    {
        return v1 * n;
    }


    public static bool operator ==(Vector a, Vector b) //сравнение векторов по длине
    {
        return a.Length() == b.Length();
    }

    public float Length()
    {
        return (float)Math.Sqrt(x * x + y * y + z * z);
    }

    public static bool operator !=(Vector a, Vector b) //сравнение векторов по длине
    {
        return a.Length() != b.Length();
    }

    public override string ToString()
    {
        return $"Vector({x}, {y}, {z})";
    }
}

public class Programm
{
    public static void Main(string[] args)
    {
        Vector v1 = new Vector(1, 1, 1);
        Vector v2 = new Vector(2, 2, 2);

        Vector sum = v1 + v2;
        float p = v1 * v2;
        Vector p1 = v1 * 4;

        Console.WriteLine($"Сумма: {sum}");
        Console.WriteLine($"Скалярное произведение: {p}");
        Console.WriteLine($"Вектор v1, умноженный на 4: {p1}");
        Console.WriteLine($"Равны ли векторы v1 и v2 по длине? {v1 == v2}");
    }
}