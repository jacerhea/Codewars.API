public class Rank
{
    public int id { get; set; }
    public string name { get; set; }
    public string color { get; set; }
}

public class CreatedBy
{
    public string username { get; set; }
    public string url { get; set; }
}

public class GetCodeChallenge
{
    public string id { get; set; }
    public string name { get; set; }
    public string slug { get; set; }
    public string category { get; set; }
    public string publishedAt { get; set; }
    public string approvedAt { get; set; }
    public List<string> languages { get; set; }
    public string url { get; set; }
    public Rank rank { get; set; }
    public CreatedBy createdBy { get; set; }
    public string approvedBy { get; set; }
    public string description { get; set; }
    public int totalAttempts { get; set; }
    public int totalCompleted { get; set; }
    public int totalStars { get; set; }
    public List<string> tags { get; set; }
}