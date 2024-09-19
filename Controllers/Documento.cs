using Microsoft.JSInterop.Infrastructure;

namespace WebApi.Controllers
{
    public class Documento
    {
        string Doc;
        public Documento()
        {
            Doc = string.Empty;

        }
        public Documento(string pDocumneto)
        {
            Doc = pDocumneto;
        }

        public string DevolverDoc()
        {
            return Doc;
        }
    }
}
