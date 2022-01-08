using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchGameMode : MonoBehaviour
{
    [SerializeField] private string singlePlayerScene = string.Empty;

    public void SinglePlayerMode()
    {
        SceneManager.LoadScene(singlePlayerScene);
    }

    public void GoToPlayStore()
    {
        Application.OpenURL("https://play.google.com/store/apps/dev?id=7308950571385201570");
    }

    public void ShowLeaderBoardUI()
    {
        LeaderBoardManager.Instance.ShowLeaderBoard();
    }
}