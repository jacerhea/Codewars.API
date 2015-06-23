public class User
{
    public string id { get; set; }
    public int rank { get; set; }
}

public class UserRankUpgraded
{
    public string action { get; set; }
    public User user { get; set; }
    public object language { get; set; }
}