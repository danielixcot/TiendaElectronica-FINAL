namespace TiendaElectronica
{
    public class Dispositivo
    {
        public int Serie { get; set; }
        public string Marca { get; set; }
        public int Modelo { get; set; }
        public Dispositivo() { 
            Serie = 0;
            Marca = string.Empty;
            Modelo = 0;
        }
    }
}
