namespace WEBUI.Pages.Modal
{
    public class Player
    {
        
        public class Playersinfo
        {
            public int id { get; set; }
            public string first_name { get; set; }
            public int? height_feet { get; set; }
            public int? height_inches { get; set; }
            public string last_name { get; set; }
            public string position { get; set; }
            public Team team { get; set; }
            public int? weight_pounds { get; set; }
            public string ErrorMessage { get; set; }

        }

        public class PlayersMeta
        {
            public int current_page { get; set; }
            public int next_page { get; set; }
            public int per_page { get; set; }
        }

        public class PlayersResponse
        {
            public List<Playersinfo> data { get; set; }
            public PlayersMeta meta { get; set; }
            public string ErrorMessage { get; set; }
        }

        public class Team
        {
            public int id { get; set; }
            public string abbreviation { get; set; }
            public string city { get; set; }
            public string conference { get; set; }
            public string division { get; set; }
            public string full_name { get; set; }
            public string name { get; set; }
        }


    }
}
