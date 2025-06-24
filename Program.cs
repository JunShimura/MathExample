using System;
using System.Numerics;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var vector = new Vector2(3.0f, 5.0f);
            var l1 = Math.Sqrt(vector.X * vector.X + vector.Y * vector.Y);
            var l2 = vector.Length();
            Console.WriteLine($"長さは同じか？{l1}{l1==l2}{l2}");

            var normalizedVector1 = vector/(float)l1;
            Console.WriteLine($"正規化されたベクトル1: {normalizedVector1}");
            var normalizedVector2 = Vector2.Normalize(vector);
            Console.WriteLine($"正規化されたベクトル2: {normalizedVector2}");
     
        }
    }
}
