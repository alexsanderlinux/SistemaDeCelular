namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Android : Smartphone
    {
        public Android(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo" //feito
        public override void InstalarAplicativo(string nomeApp)
        {
             Console.WriteLine($"Instalando aplicativo \"{nomeApp}\" no Android");
        }
    }
}