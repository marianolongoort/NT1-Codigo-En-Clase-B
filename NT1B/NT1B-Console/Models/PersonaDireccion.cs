namespace NT1B_Console.Models
{
    public class PersonaDireccion
    {
        public int PersonaId { get; set; }
        public Persona Persona { get; set; }

        public int DireccionId { get; set; }
        public Direccion Direccion { get; set; }

    }
}