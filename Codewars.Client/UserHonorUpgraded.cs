public class User
{
    public string id { get; set; }
    public int honor { get; set; }
    public int honor_delta { get; set; }
}

public class UserHonorUpgraded
{
    public string action { get; set; }
    public User user { get; set; }
}