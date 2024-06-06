namespace TiendaElectronica
{
    public class Laptop : Dispositivo
    {
        public int Ram {  get; set; }
        public int almacenamiento { get; set; }
        public Laptop() { 
            Ram = 0;
            almacenamiento = 0;
        }
    }
}
