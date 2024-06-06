namespace TiendaElectronica
{
    public class Tablet: Dispositivo
    {
        public int Tamano {  get; set; }
        public string Stylus { get; set; }
        public Tablet() { 
            Tamano = 0;
            Stylus = string.Empty;
        }
    }
}
