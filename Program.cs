int dividendo, divisor, resto;

Console.WriteLine("maxímo divisor comum (metodo interativo)\n");

Console.Write("digite o 1º numero (a): ");
dividendo = Convert.ToInt32(Console.ReadLine());

Console.Write("digite o 2º numero (b): ");
divisor = Convert.ToInt32(Console.ReadLine());

do
{
    resto = dividendo % divisor;
    dividendo = divisor;
    divisor = resto;
}
 while (resto != 0);

 Console.WriteLine($"MDC(a , b) = {dividendo}");
