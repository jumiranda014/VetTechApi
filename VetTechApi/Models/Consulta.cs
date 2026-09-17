using VetTechApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VetTechApi.Models;

namespace VetTechApi.Models
{
    public class Consulta
    {
        public int Id { get; set; }
        public DateTime DataHora { get; set; }
        public string Motivo { get; set; } = string.Empty;

        public int PetId { get; set; }
        public Pet? Pet { get; set; }

        public int VeterinarioId { get; set; }
        public Veterinario? Veterinario { get; set; }
    }
}