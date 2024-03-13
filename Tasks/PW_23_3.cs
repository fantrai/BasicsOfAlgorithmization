using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class PW_23_3 : AbstractPracticalWork
    {
        public override int NumPracticalWork => 23;

        public override int NumProgram => 2;

        public override string Date => "20 февраля 2024";

        public override string TextTask => "Составить описание класса для вектора, заданного " +
            "координатами его концов в трехмерном пространстве. Обеспечить " +
            "операции сложения и вычитания векторов с получением нового " +
            "вектора (суммы или разности), вычисления скалярного произведения " +
            "двух векторов, длины вектора, косинуса угла между векторами.";

        public override void Program()
        {
            CrutchVector3 vector1 = new CrutchVector3() { X = 10, Y = 5, Z = 3 };
            CrutchVector3 vector2 = new CrutchVector3() { X = -4, Y = 14, Z = 9 };

            Console.WriteLine("вектор 1: " + vector1);
            Console.WriteLine("вектор 2: " + vector2);
            Console.WriteLine("сумма векторов: " + (vector1 + vector2));
            Console.WriteLine("разность векторов: " + (vector1 - vector2));
            Console.WriteLine("длинна вектора 1: " + vector1.LengthVector3);
            Console.WriteLine("скалярное произведение: "+ CrutchVector3.ScalarMult(vector1, vector2));
            Console.WriteLine("косинус угла между векторами: " + CrutchVector3.CosAngleVectors3(vector1, vector2));
        }

        struct CrutchVector3
        {
            public float X { get; set; }
            public float Y { get; set; }
            public float Z { get; set; }

            public float LengthVector3 
            { 
                get 
                {
                    return (float)Math.Sqrt(X * X + Y * Y + Z * Z);
                } 
            }

            public override string ToString()
            {
                return $"X={X}; Y={Y}; Z={Z}";
            }

            public static CrutchVector3 operator + (CrutchVector3 a, CrutchVector3 b)
            {
                return new CrutchVector3() { X = a.X + b.X, Y = a.Y + b.Y, Z = a.Z + b.Z };
            }

            public static CrutchVector3 operator - (CrutchVector3 a, CrutchVector3 b)
            {
                return new CrutchVector3() { X = a.X - b.X, Y = a.Y - b.Y, Z = a.Z - b.Z };
            }

            public static float ScalarMult(CrutchVector3 a, CrutchVector3 b)
            {
                return a.LengthVector3 * b.LengthVector3 * CosAngleVectors3(a, b);
            }

            public static float CosAngleVectors3(CrutchVector3 a, CrutchVector3 b)
            {
                return (a.X * b.X + a.Y * b.Y + a.Z * b.Z) / (a.LengthVector3 * b.LengthVector3);
            }
        }
    }
}
