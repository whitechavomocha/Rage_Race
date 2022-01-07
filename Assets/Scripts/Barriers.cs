using UnityEngine;
using UnityEngine.SceneManagement;

public class Barriers : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.transform.tag == "Player")
        {
            Invoke(nameof(Restart), 0.5f);
        }
    }

    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}