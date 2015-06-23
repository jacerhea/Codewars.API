public class Overall
{
    public int rank { get; set; }
    public string name { get; set; }
    public string color { get; set; }
    public int score { get; set; }
}

public class Javascript
{
    public int rank { get; set; }
    public string name { get; set; }
    public string color { get; set; }
    public int score { get; set; }
}

public class Ruby
{
    public int rank { get; set; }
    public string name { get; set; }
    public string color { get; set; }
    public int score { get; set; }
}

public class Coffeescript
{
    public int rank { get; set; }
    public string name { get; set; }
    public string color { get; set; }
    public int score { get; set; }
}

public class Languages
{
    public Javascript javascript { get; set; }
    public Ruby ruby { get; set; }
    public Coffeescript coffeescript { get; set; }
}

public class Ranks
{
    public Overall overall { get; set; }
    public Languages languages { get; set; }
}

public class CodeChallenges
{
    public int totalAuthored { get; set; }
    public int totalCompleted { get; set; }
}

public class GetUserResponse
{
    public string username { get; set; }
    public string name { get; set; }
    public int honor { get; set; }
    public string clan { get; set; }
    public int leaderboardPosition { get; set; }
    public List<string> skills { get; set; }
    public Ranks ranks { get; set; }
    public CodeChallenges codeChallenges { get; set; }
}