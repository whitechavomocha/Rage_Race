using Photon.Pun;
using UnityEngine;

public class CarController : MonoBehaviourPunCallbacks
{
    [SerializeField] private float speed = 5;
    [SerializeField] private float speedGainPerSec = 0.2f;
    [SerializeField] private float turnSpeed = 3f;
    [SerializeField] private GameObject readyButton;

    private int steerValue = 0;
    private bool ready = false;

    //private void Start()
    //{
    //    CameraWork _cameraWork = this.gameObject.GetComponent<CameraWork>();

    //    if (_cameraWork != null)
    //    {
    //        if (photonView.IsMine)
    //        {
    //            _cameraWork.OnStartFollowing();
    //        }
    //    }
    //    else
    //    {
    //        Debug.LogError("<Color=Red><a>Missing</a></Color> CameraWork Component on playerPrefab.", this);
    //    }
    //}

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
        if (photonView.IsMine)
        {
            steerValue = value;
        }
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