using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class Player : MonoBehaviourPunCallbacks
{
    public PhotonView playerPrefab;
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    // Update is called once per frame
    public override void OnConnectedToMaster()
    {
        Debug.Log("Connected");
        PhotonNetwork.JoinRandomOrCreateRoom();
    }
    public override void OnJoinedRoom()
    {
        Debug.Log("Joined Room");
        PhotonNetwork.Instantiate(playerPrefab.name, Vector3.zero, Quaternion.identity);
    }
}
