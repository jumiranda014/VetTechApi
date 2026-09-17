namespace VetTechApi.Models
{
    public class Veterinario
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string CRMV { get; set; } = string.Empty;
        public string Especialidade { get; set; } = string.Empty;
    }
}