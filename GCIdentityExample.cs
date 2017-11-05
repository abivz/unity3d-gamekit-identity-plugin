using UnityEngine;

using GCIdentityPlugin;

public class GCIdentityExample : MonoBehaviour
{
    void Awake()
    {
        Social.localUser.Authenticate(OnSocialAuthenticated);
    }

    void OnSocialAuthenticated(bool success)
    {
        Debug.Log("Player is authenticated: " + success);

        if (success)
        {
            Debug.Log("Generate identity...");

            //  WARNING: Put this GameObject name for receive callbacks
            GCIdentity.GenerateIdentity(this.name);
        }
    }

    public void OnIdentitySuccess(string identity)
    {
        var parsed = GCIdentity.ParseIdentity(identity);
        Debug.LogFormat("Key: {0}\nSign: {1}\nSalt: {2}\nTimestamp: {3}", parsed[0], parsed[1], parsed[2], parsed[3]);
        
        //  Connect with third-party application...
    }

    public void OnIdentityError(string error)
    {
        Debug.Log("Identity error: " + error);
    }
}
