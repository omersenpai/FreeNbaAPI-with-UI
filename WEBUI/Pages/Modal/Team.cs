namespace WEBUI.Pages.Modal
{
    public class Team
    {
        public class TeamInfo
        {
            public int id { get; set; }
            public string abbreviation { get; set; }
            public string city { get; set; }
            public string conference { get; set; }
            public string division { get; set; }
            public string full_name { get; set; }
            public string name { get; set; }
            public string ErrorMessage { get; set; }
        }

        public class TeamMeta
        {
            public int current_page { get; set; }
            public int next_page { get; set; }
            public int per_page { get; set; }
        }

        public class TeamResponse
        {
            public List<TeamInfo> data { get; set; }
            public TeamMeta meta { get; set; }
            public string ErrorMessage { get; set; }
        }

    }
}
