using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tasks
{
    internal class PW_23_2 : AbstractPracticalWork
    {
        public override int NumPracticalWork => 23;

        public override int NumProgram => 2;

        public override string Date => "20 февраля 2024";

        public override string TextTask => "Создать класс для хранения комплексных чисел. " +
            "Реализовать операции над комплексными числами: сложение, " +
            "вычитание, умножение, деление, сопряжение, возведение в степень, " +
            "извлечение корня. Предусмотреть возможность изменения формы " +
            "записи комплексного числа: алгебраическая форма, " +
            "тригонометрическая форма, экспоненциальная форма.";

        public override void Program()
        {
            ComplexNumber complexNumber = new ComplexNumber(2, 4);
            ComplexNumber complexNumber2 = new ComplexNumber(3, 5);

            Console.WriteLine("Число 1: " + complexNumber);
            Console.WriteLine("Число 2: " + complexNumber2 + "\n");

            Console.WriteLine("Число 1 в экспоненциальной форме:" + complexNumber.ExponentialFormToString);
            Console.WriteLine("Число 1 в тригонометрической форме:" + complexNumber.TrigonimetricFormToString +"\n");

            Console.WriteLine("Сумма чисел 1 и 2: " + (complexNumber + complexNumber2));
            Console.WriteLine("Разность чисел 1 и 2: " + (complexNumber - complexNumber2));
            Console.WriteLine("Произведение чисел 1 и 2: " + (complexNumber * complexNumber2));
            Console.WriteLine("Частное чисел 1 и 2: " + (complexNumber / complexNumber2));
            Console.WriteLine("Число 1 в степени 5: " + ComplexNumber.Pow(complexNumber, 5));

            Console.WriteLine("Корни 5 степени из числа 1:");
            ComplexNumber[] roots = ComplexNumber.RootOfTheNumber(complexNumber, 5);
            for (int i = 0; i < roots.Length; i++)
            {
                Console.WriteLine(roots[i]);
            }
        }

        struct ComplexNumber
        {
            public ComplexNumber(float elA, float elB)
            {
                A = elA;
                B = elB;
            }

            public float A { get; set; }
            public float B { get; set; }
            public float R 
            { 
                get 
                {
                    return (float)Math.Sqrt(A * A + B * B);
                } 
            }
            public float Fi 
            { 
                get 
                {
                    float fi = 0;
                    if (A > 0 && B > 0)
                    {
                        fi = (float)(Math.Atan(B / A) * (180 / Math.PI));
                    }
                    else if (A > 0 && B < 0)
                    {
                        fi = -(float)(Math.Atan(B / A) * (180 / Math.PI));
                    }
                    else if (A < 0 && B > 0)
                    {
                        fi = (float)(Math.PI - (Math.Atan(B / A) * (180 / Math.PI)));
                    }
                    else if (A < 0 && B < 0)
                    {
                        fi = (float)(-Math.PI + (Math.Atan(B / A) * (180 / Math.PI)));
                    }
                    else if (A == 0 && B > 0)
                    {
                        fi = (float)(Math.PI / 2);
                    }
                    else if (A == 0 && B < 0)
                    {
                        fi = (float)(-Math.PI / 2);
                    }
                    else if (A > 0 && B == 0)
                    {
                        fi = 0;
                    }
                    else if (A < 0 && B == 0)
                    {
                        fi = (float)Math.PI;
                    }
                    return (float)Math.Round(fi, 2);
                }
            }

            public override string ToString()
            {
                return (A != 0 ? A.ToString() : "")
                        + (B != 0 && B > 0 ? " + " : "")
                        + (B != 0 ? B.ToString() + "i" : "");
            }
            public string ExponentialFormToString 
            { 
                get 
                {
                    return R == 0 ? "0" : $"{R}e^({Fi} * i)";
                } 
            }
            public string TrigonimetricFormToString 
            { 
                get
                {
                    return R == 0 ? "0" : $"{R}*(cos {Fi}) + i*(sin {Fi})";
                }
            }

            public static ComplexNumber operator + (ComplexNumber a, ComplexNumber b)
            {
                return new ComplexNumber(a.A + b.A, a.B + b.B);
            }

            public static ComplexNumber operator - (ComplexNumber a, ComplexNumber b)
            {
                return new ComplexNumber(a.A - b.A, a.B - b.B);
            }

            public static ComplexNumber operator * (ComplexNumber a, ComplexNumber b)
            {
                return new ComplexNumber(a.A * b.A - a.B * b.B, a.A * b.B + a.B  * b.A);
            }

            public static ComplexNumber operator / (ComplexNumber a, ComplexNumber b)
            {
                return new ComplexNumber((a.A * b.A + a.B * b.B) / (b.A * b.A + b.B * b.B),
                    (a.B * b.A - a.A * b.B) / (b.A * b.A + b.B * b.B));
            }

            public static ComplexNumber Pow(ComplexNumber a, int n)
            {
                ComplexNumber result = a;
                for (int i = 0; i < n - 1; i++) 
                {
                     result = result * a;
                }
                return result;
            }

            public static ComplexNumber[] RootOfTheNumber(ComplexNumber a, int n)
            {
                List<ComplexNumber> result = new List<ComplexNumber>();
                for (float k = 0; k < n; k++)
                {
                    float newA = (float)Math.Round(Math.Pow(a.R, 1f / n) * 
                        Math.Cos((a.Fi + 2f * Math.PI * k) / n * (Math.PI / 180)), 2);
                    float newB = (float)Math.Round(Math.Pow(a.R, 1f / n) * 
                        Math.Sin((a.Fi + 2f * Math.PI * k) / n * (Math.PI / 180)), 2);
                    result.Add(new ComplexNumber(newA, newB));
                }
                return result.ToArray();
            }
        }
    }
}
