namespace DarkHeartOfAndaluria.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public int Population { get; set; }

        public int DominantReligion { get; set; }

    }
}
