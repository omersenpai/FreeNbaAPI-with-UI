namespace WEBUI.Pages.Modal
{
    public class Game
    {

        public class GameInfo
        {
            public int id { get; set; }
            public string date { get; set; }
            public HomeTeam home_team { get; set; }
            public int home_team_score { get; set; }
            public int period { get; set; }
            public bool postseason { get; set; }
            public int season { get; set; }
            public string status { get; set; }
            public string time { get; set; }
            public VisitorTeam visitor_team { get; set; }
            public int visitor_team_score { get; set; }
            public string ErrorMessage { get; set; }

        }

        public class HomeTeam
        {
            public int id { get; set; }
            public string abbreviation { get; set; }
            public string city { get; set; }
            public string conference { get; set; }
            public string division { get; set; }
            public string full_name { get; set; }
            public string name { get; set; }
        }

        public class GameMeta
        {
            public int current_page { get; set; }
            public int next_page { get; set; }
            public int per_page { get; set; }
        }

        public class GameResponse
        {
            public List<GameInfo> data { get; set; }
            public GameMeta meta { get; set; }
            public string ErrorMessage { get; set; }
        }

        public class VisitorTeam
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
