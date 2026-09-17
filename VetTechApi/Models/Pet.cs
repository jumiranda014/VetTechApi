namespace VetTechApi.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Especie { get; set; } = string.Empty;

        public string TutorId { get; set; }


    }
}