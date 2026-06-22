using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    public class ConversorDeTemperatura {

        public double CelsiusParaFahrenheit(double celsius) {
            return (celsius * 9 / 5) + 32;
        }
        public double FahrenheitParaCelsius(double fahrenheit) {
            return (fahrenheit - 32) * 5 / 9;
        }
        public double CelsiusParaKelvin(double celsius) {
            return celsius + 273.15;
        }
        public double KelvinParaCelsius(double kelvin) {
            return kelvin - 273.15;
        }

    }
        internal class MetodosComRetornoExercicio1 {

        public static void Executar() {
            var conversor = new ConversorDeTemperatura();
            double celsius = 25;
            double fahrenheit = conversor.CelsiusParaFahrenheit(celsius);
            Console.WriteLine($"{celsius}°C é igual a {fahrenheit}°F");
           
        }
}
}

