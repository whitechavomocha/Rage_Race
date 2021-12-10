using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchGameMode : MonoBehaviour
{
    [SerializeField] private string singlePlayerScene = string.Empty;
    [SerializeField] private string multiPlayerScene = string.Empty;

    public void SinglePlayerMode()
    {
        SceneManager.LoadScene(singlePlayerScene);
    }

    public void MultiPlayerMode()
    {
        SceneManager.LoadScene(multiPlayerScene);
    }

    public void GoToPlayStore()
    {
        Application.OpenURL("https://play.google.com/store/apps/details?id=com.AdivinisGames.com.unity.BouncyPixels");
    }
}