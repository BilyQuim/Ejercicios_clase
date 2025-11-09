namespace Operacion_Biblio
{
    public class Calculadora
    {
        public double Sumar(double a, double b) => a + b;
        public double Restar(double a, double b) => a - b;
        public double Multiplicar(double a, double b) => a * b;
        
        public double Dividir(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("No se puede dividir por cero");
            return a / b;
        }
        
        public double Potencia(double baseNum, double exponente) => Math.Pow(baseNum, exponente);
        
        public double RaizCuadrada(double numero)
        {
            if (numero < 0)
                throw new ArgumentException("No se puede calcular la raíz de un número negativo");
            return Math.Sqrt(numero);
        }
        
        public double Porcentaje(double numero, double porcentaje) => (numero * porcentaje) / 100;
    }
}