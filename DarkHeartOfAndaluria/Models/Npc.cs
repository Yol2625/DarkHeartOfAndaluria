namespace DarkHeartOfAndaluria.Models
{
    public class Npc
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public int Age { get; set; }
        public int Species { get; set; }
        public string Description { get; set; } = "";


        public int Tier { get; set; }

        public int HomeCityId { get; set; }

        public int CurrentCityId { get; set; }

        public City HomeCity { get; set; } = null!;

        public City CurrentCity { get; set; } = null!;


    }
}
