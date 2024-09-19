using Microsoft.AspNetCore.Mvc;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
        
        [HttpGet("HolaMundo/{Nombre}")]
        public string HolaMundo(string Nombre)
        {
            int numero = 10;
            string nombre = "Carla Maribel";
            double flotante = 3.5;
            bool existe = true;
            DateTime fechadeHoy = DateTime.Now;
            return "Hola " + Nombre;
        }
        [HttpGet("DevolverFecha")]
        public string DevolverFecha()
        {
            return DateTime.Now.ToString();
        }
        [HttpGet("DevolverSuma/{Numero1}/{Numero2}")]
        public int DevolverSuma(int Numero1, int Numero2)
        {
            return Numero1 + Numero2;
        }
        [HttpGet("DevolverMayor/{Numero1}/{Numero2}")]
        public string DevolverMayor(int Numero1, int Numero2)
        {
            string respuesta = "";
            if (Numero1 > Numero2)
            {
                respuesta = "El mayor es " + Numero1.ToString();
            }
            else
            {
                respuesta = "El mayor es" + Numero2.ToString();
            }
            return respuesta;
        }
        [HttpGet("GetCadena")]
        public string GetCadena()
        {

            string nombre = "jose";
            string apellido = "maria";
            int num1 = 10;
            string completo = nombre + apellido + " " + num1.ToString();
            return completo;
        }
        [HttpGet("GetEdad/{edad}/{nombre}")]
        public string GetEdad(int edad, string nombre)
        {
            string respuesta = "";
            if (edad <= 18)
            {
                respuesta = "sr" + nombre + "es Mayor de edad";
            }
            else
            {
                respuesta = "sr" + nombre + "es menor de edad";
            }
            
                return respuesta;
        }


        [HttpGet("CalcularArea/{largo}/{ancho}")]
                public string CalcularArea(int largo, int ancho)
                {
                    int area = largo * ancho;
                    return "Su area es " + area + " metros cuadrados";
                }

                [HttpGet("CalcularEdad/{añoNac}/{nombre}")]
                public string CalcularEdad(int añoNac, string nombre)
                {
                    int edad = DateTime.Now.Year - añoNac;
                    return "Sr(s) " + nombre + " su edad es " + edad + " años";
                }

                [HttpGet("CalcularGeneracion/{añoNac}")]
                public string CalcularGeneracion(int añoNac)
                {
                    int año = DateTime.Now.Year - añoNac;
                    if (año >= 18 && año <= 20)
                    {
                        return "Usted es de la generacion z";
                    }
                    else
                    {
                        return "Usted no es de la gneracion z";
                    }

                }

        [HttpGet("DevolverSuma/{numero}")]
        public string DevolverSuma(int numero)
        {
            string mensaje = string.Empty;
            Alumno Alumno1 = new Alumno();
            Alumno Alumno2 = new Alumno("Juan", "Perez", "4370258");
            if(numero == 1)
            {
                return Alumno1.DevolverNombreCompleto();
            }
            else
            {
                return Alumno2.DevolverNombreCompleto();
            }
            
        }

        [HttpGet("DevolverDocumento/{numero}")]
        public string DevolverDocumento(int numero)
        {
            Documento documento1 = new("4370258");

            return documento1.DevolverDoc();

        }

        [HttpGet("DevolverEdad")]
        public int DevolverEdad()
        {
            string mensaje = string.Empty;
            Alumno Alumno3 = new Alumno("Juan", "Perez", "4370258", new DateTime(2003, 8, 18));
            return Alumno3.DevolverEdad();
        }
    }

}