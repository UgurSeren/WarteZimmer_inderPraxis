namespace WarteZimmer_inderPraxis.Models
{
    public class Patienten
    {
        public int? PatientId { get; set; }
        public string? gender { get; set; }
        public string? name { get; set; }
        public string? wohnthaft { get; set; }
        public string? stadt { get; set; }

        public string? beschwerde { set; get; }

    }
}
