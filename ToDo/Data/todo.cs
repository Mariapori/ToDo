using System.ComponentModel.DataAnnotations;

namespace ToDo.Data
{
    public class todo
    {
        public int Id { get; set; }
        [Required]
        public string Kuvaus { get; set; }
        public Tila Tila { get; set; }
        public DateTime Muokattu { get; set; }
        public DateTime Luotu { get; set; }

        public string Luoja { get; set; }
        public bool Personal { get; set; }

    }

    public enum Tila
    {
        ToDo,
        Aloitettu,
        Valmis
    }
}
