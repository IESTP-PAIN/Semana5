namespace WebApi.Controllers
{
    public class Alumno
    {
        //creando propiedades
        string Nombre;
        string Apellido;
        string DNI;
        DateTime FechaNacimiento;

        //constructor sin parametros
        public Alumno()
        {
            Nombre = string.Empty;
            Apellido = string.Empty;
            DNI = string.Empty;
            FechaNacimiento = DateTime.Now;
        }
        //constructor con parametros
        public Alumno(string pNombre, string pApellido, string pDNI)
        {
            Nombre = pNombre;
            Apellido = pApellido;
            DNI = pDNI;
        }
        public Alumno(string pNombre, string pApellido, string pDNI, DateTime pFechaNacimiento)
        {
            Nombre = pNombre;
            Apellido = pApellido;
            DNI = pDNI;
            FechaNacimiento = pFechaNacimiento;
        }

        public string DevolverNombreCompleto()
        {
            return Nombre + " " + Apellido;
        }

        public int DevolverEdad()
        {
            return DateTime.Now.Year - FechaNacimiento.Year;
        }
    }
}