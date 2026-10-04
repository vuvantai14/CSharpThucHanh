using System;

namespace LAB04D
{
    public class PhuongTrinhBacHai
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public PhuongTrinhBacHai()
        {
            A = B = C = 0;
        }

        public PhuongTrinhBacHai(double a, double b, double c = 0)
        {
            A = a;
            B = b;
            C = c;
        }

        public string GiaiBacNhat()
        {
            if (A == 0)
            {
                if (B == 0)
                    return "Phương trình có vô số nghiệm.";

                return "Phương trình vô nghiệm.";
            }

            double x = -B / A;
            return $"Phương trình có nghiệm x = {x:0.##}";
        }

        public string GiaiBacHai()
        {
            if (A == 0)
            {
                return GiaiBacNhat();
            }

            double delta = B * B - 4 * A * C;

            if (delta < 0)
                return "Phương trình vô nghiệm.";

            if (delta == 0)
            {
                double x = -B / (2 * A);
                return $"Phương trình có nghiệm kép x1 = x2 = {x:0.##}";
            }

            double x1 = (-B + Math.Sqrt(delta)) / (2 * A);
            double x2 = (-B - Math.Sqrt(delta)) / (2 * A);

            return $"Phương trình có 2 nghiệm:\r\nx1 = {x1:0.##}\r\nx2 = {x2:0.##}";
        }
    }
}