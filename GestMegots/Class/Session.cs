namespace GestMegots.Class;

public static class Session
{
    private static int _sessionHab;
    private static bool _loggedIn;
    public static int SessionHab { get => _sessionHab; set => _sessionHab = value; }
    public static bool LoggedIn { get => _loggedIn; set => _loggedIn = value; }
}