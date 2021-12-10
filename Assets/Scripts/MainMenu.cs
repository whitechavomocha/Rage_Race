using Photon.Pun;
using Photon.Realtime;
using TMPro;
using UnityEngine;

public class MainMenu : MonoBehaviourPunCallbacks
{
    [SerializeField] private TMP_InputField join;
    [SerializeField] private TMP_InputField create;
    [SerializeField] private string gameScene = string.Empty;

    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom(join.text);
    }

    public void CreateRoom()
    {
        RoomOptions roomOptions = new RoomOptions();
        roomOptions.MaxPlayers = 4;

        PhotonNetwork.CreateRoom(create.text, roomOptions);
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel(gameScene);
    }
}