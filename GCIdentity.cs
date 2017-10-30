using System.Runtime.InteropServices;

public class GCIdentity
{
    [DllImport("__Internal")]
    static extern void _GenerateIdentity(string gameObjectName);

    public static void GenerateIdentity(string gameObjectName)
    {
        _GenerateIdentity(gameObjectName);
    }

    public static string[] ParseIdentity(string identity)
    {
        return identity.Split(new char[] {';'});
    }
}
