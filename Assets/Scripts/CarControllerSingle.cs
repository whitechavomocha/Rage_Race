using UnityEngine;

public class CarControllerSingle : MonoBehaviour
{
    [SerializeField] private float speed = 5;
    [SerializeField] private float speedGainPerSec = 0.2f;
    [SerializeField] private float turnSpeed = 3f;
    [SerializeField] private GameObject readyButton;

    private int steerValue = 0;
    private bool ready = false;

    private void FixedUpdate()
    {
        if (ready)
        {
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
        if (speed < 20f)
        {
            speed += speedGainPerSec * Time.deltaTime;
        }

        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}