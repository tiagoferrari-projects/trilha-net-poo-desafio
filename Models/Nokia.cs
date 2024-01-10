namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string iMei, string modelo, int memoria)
       : base(numero, iMei, modelo, memoria)
        { }
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Acessando Play Store....Aplicativo {nomeApp} instalado com sucesso.");
        }
    }
}