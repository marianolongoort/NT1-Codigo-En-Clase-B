namespace NT1B_Console.Models
{
    public class Mascota
    {
        public int MascotaId { get; set; }
        public string Nombre { get; set; }

        //Relacion uno a uno
        public Persona Duenio { get; set; }
    }
}