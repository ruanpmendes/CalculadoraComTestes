namespace AulaTest
{
    public class Calculadora
    {
        public int Somar(int a, int b)
        {
            return a + b;
        }

        public int Dividir(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException("Tentativa de divisão por zero.");
            return a / b;
        }
    }
}
