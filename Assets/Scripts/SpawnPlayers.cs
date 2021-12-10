using Photon.Pun;
using UnityEngine;

public class SpawnPlayers : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private Transform[] spawnPoints;

    private void Start()
    {
        int spawnPoint = 0;

        if (PhotonNetwork.LocalPlayer.ActorNumber == 1)
        {
            spawnPoint = 0;
        }
        else if (PhotonNetwork.LocalPlayer.ActorNumber == 2)
        {
            spawnPoint = 1;
        }
        else if (PhotonNetwork.LocalPlayer.ActorNumber == 3)
        {
            spawnPoint = 2;
        }
        else if (PhotonNetwork.LocalPlayer.ActorNumber == 4)
        {
            spawnPoint = 3;
        }

        PhotonNetwork.Instantiate(player.name,
            new Vector3
            (spawnPoints[spawnPoint].transform.position.x,
            spawnPoints[spawnPoint].transform.position.y,
            spawnPoints[spawnPoint].transform.position.z),
            Quaternion.identity);
    }
}