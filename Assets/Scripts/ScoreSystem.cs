using TMPro;
using UnityEngine;

public class ScoreSystem : MonoBehaviour
{
    public static ScoreSystem Instance;

    [SerializeField] private TMP_Text scoreText;
    [HideInInspector] public float score = 0f;
    private float scoreMultiplier = 7.5f;
    private bool ready = false;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    private void Update()
    {
        if (ready)
        {
            Score();
        }
        else
        {
            score = 0;
        }
    }

    public void Ready(bool value)
    {
        ready = value;
    }

    private void Score()
    {
        score += Time.deltaTime * scoreMultiplier;
        scoreText.text = Mathf.FloorToInt(score).ToString();
    }
}