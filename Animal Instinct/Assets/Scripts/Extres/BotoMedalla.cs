using UnityEngine;
using System.Collections;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;

public class BotoMedalla : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void OnMouseDown()
    {
        if (Social.localUser.authenticated)
        {
            Social.Active.ShowAchievementsUI();
        }
        else
        {
            Social.localUser.Authenticate((bool success) => { });
        }
    }
}
