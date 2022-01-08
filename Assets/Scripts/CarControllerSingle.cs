using UnityEngine;

public class CarControllerSingle : MonoBehaviour
{
    [SerializeField] private float speed = 5;
    [SerializeField] private float speedGainPerSec = 2f;
    [SerializeField] private float turnSpeed = 80f;
    [SerializeField] private GameObject readyButton;

    private int steerValue = 0;
    private bool ready = false;
    public bool gameReady = false;

    private void FixedUpdate()
    {
        if (ready)
        {
            gameReady = true;
            Move();
        }

        transform.Rotate(0f, steerValue * turnSpeed * Time.deltaTime, 0f);
    }

    public void Steer(int value)
    {
            steerValue = value;
    }

    public void Ready(bool value)
    {
        ready = value;
        readyButton.SetActive(false);
    }

    private void Move()
    {
        if (speed < 60f)
        {
            speed += speedGainPerSec * Time.deltaTime;
        }

        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}