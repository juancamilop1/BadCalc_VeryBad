using System;


namespace BadCalcVeryBad
{
    public class Calculadora_Arreglada
    {
		public static void Main(string[] args)
		{
			Console.WriteLine("Bienvenido a La Mala Calculadora");

			// Solicitar el primer número
			Console.Write("Ingrese el primer número: ");
			string input1 = Console.ReadLine();
			double numero1;
			// Validación de entrada
			while (!double.TryParse(input1, out numero1))
			{
				Console.Write("Entrada inválida. Ingrese un número válido: ");
				input1 = Console.ReadLine();
			}

			// Solicitar el segundo número
			Console.Write("Ingrese el segundo número: ");
			string input2 = Console.ReadLine();
			double numero2;
			while (!double.TryParse(input2, out numero2))
			{
				Console.Write("Entrada inválida. Ingrese un número válido: ");
				input2 = Console.ReadLine();
			}

			// Solicitar la operación
			Console.Write("Ingrese la operación (+, -, *, /): ");
			string operacion = Console.ReadLine();

			double resultado = 0;
			bool operacionValida = true;

			// Realizar la operación
			switch (operacion)
			{
				case "+":
					resultado = numero1 + numero2;
					break;
				case "-":
					resultado = numero1 - numero2;
					break;
				case "*":
					resultado = numero1 * numero2;
					break;
				case "/":
					if (numero2 != 0)
					{
						resultado = numero1 / numero2;
					}
					else
					{
						Console.WriteLine("Error: No se puede dividir por cero.");
						operacionValida = false;
					}
					break;
				default:
					Console.WriteLine("Operación no válida.");
					operacionValida = false;
					break;
			}

			// Mostrar el resultado si la operación fue válida
			if (operacionValida)
			{
				Console.WriteLine($"El resultado es: {resultado}");
			}
		}
	}  
}
