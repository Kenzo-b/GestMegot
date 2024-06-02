using System.Security.Cryptography;
using System.Text;

namespace GestMegots.Class;

public static class Hashing
{
    public static string ToSha256(string s)
    {
        using var sha256 = SHA256.Create();
        byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(s));
        var sb = new StringBuilder();
        foreach (var t in bytes)
        {
            sb.Append(t.ToString("x2"));
        }
        return sb.ToString();
    }
}