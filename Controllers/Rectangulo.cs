namespace WebApi.Controllers
{
    public class Rectangulo
    {
        double baser;
        double alturar;
        //contructor clase rectangulo
        public Rectangulo()
        {
            //inicializando valores de la clse rectangulo
            baser = 0;
            alturar = 0;
        }
        // constructor parametros
        public Rectangulo( double pbaser, double palturar)
        {
            baser = pbaser;
            alturar =palturar;
        }
        public double DevolverArea()
        {
            return baser * alturar;
        }
    }
}
