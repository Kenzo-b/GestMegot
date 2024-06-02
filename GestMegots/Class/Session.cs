namespace GestMegots.Class;

public static class Session
{
    public static int SessionHab { get => _sessionHab; }

    public static bool LoggedIn { get => _loggedIn; }

    public static string? Pseudo { get => _pseudo; }

    private static int _sessionHab;
    private static bool _loggedIn;
    private static string? _pseudo;

    public static void SetSession(int sessionHab, bool loggedIn, string pseudo )
    {
        _sessionHab = sessionHab;
        _loggedIn = loggedIn;
        _pseudo = pseudo;
    }

    public static void UnsetSession()
    {
        _sessionHab = 0;
        _loggedIn = false;
        _pseudo = string.Empty;
    }
}