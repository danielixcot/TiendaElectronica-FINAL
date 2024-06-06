namespace TiendaElectronica
{
    public class Smarthphone : Dispositivo
    {
        public string Sistemaop {  get; set; }
        public int Camaras { get; set; }
        public Smarthphone()
        {
            Sistemaop = string.Empty;
            Camaras = 0;
        }
    }
}
