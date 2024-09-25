using System.Security.Cryptography.X509Certificates;

namespace ProjetoC_.Models
{
    public class Nokia : Celular
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no seu Nokia.");
        }
    }
}