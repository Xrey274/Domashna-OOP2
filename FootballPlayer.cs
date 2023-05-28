public class FootballPlayer : Person
{
    public int Number { get; set; }
    public double Height { get; set; }
}

public class Goalkeeper : FootballPlayer { }
public class Defender : FootballPlayer { }
public class Midfielder : FootballPlayer { }
public class Striker : FootballPlayer { }