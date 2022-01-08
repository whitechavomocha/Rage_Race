using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;

public class LeaderBoardManager : MonoBehaviour
{
    public static LeaderBoardManager Instance;
    private void Awake()
    {
        if (Instance == null)
	    {
            Instance = this;
            DontDestroyOnLoad(this);
	    }
        
    }

    private void Start()
    {
        Login();
    }

    public void Login()
    {
        Social.localUser.Authenticate((bool success) => { }); 
    }

    public void AddScoreToLeaderBoard()
    {
        Social.ReportScore((long)ScoreSystem.Instance.score, LeaderBoard.leaderboard_best_drivers, (bool success) => { });
    }

    public void ShowLeaderBoard()
    {
        if (Social.localUser.authenticated)
        {
            PlayGamesPlatform.Instance.ShowLeaderboardUI(LeaderBoard.leaderboard_best_drivers);
        }
        else
        {
            Login();
        }
        
    }
}
