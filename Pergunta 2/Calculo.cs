namespace Pergunta_2
{
    public class Calculo
    {

        public double Calcular(double a, double b, double c)
        {
            if (a > b && a > c)
            {
                double result = ((a * 4) + (b * 3) + (c * 3)) / 10;
                return result;
            }
            else if (b > a && b > c)
            {
                double result = ((a * 3) + (b * 4) + (c * 3)) / 10;
                return result;
            }
            else if (c > b && c > a)
            {
                double result = ((a * 3) + (b * 3) + (c * 4)) / 10;
                return result;
            }
            else
            {
                double result = ((a * 3) + (b * 3) + (c * 3)) / 10;
                return result;
            }
        }
    }
}
