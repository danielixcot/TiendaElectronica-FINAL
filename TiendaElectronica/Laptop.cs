namespace TiendaElectronica
{
    public class Laptop : Dispositivo
    {
        public int Ram {  get; set; }
        public int Almacenamiento { get; set; }
        public Laptop() { 
            Ram = 0;
            Almacenamiento = 0;
        }
    }
}
