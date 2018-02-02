using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetworkManager : Photon.MonoBehaviour {

    public string Version;
	
	void Start () {
        PhotonNetwork.ConnectUsingSettings(Version);
	}

    void OnConnectedToMaster()
    {
        PhotonNetwork.JoinOrCreateRoom("Global", new RoomOptions() { maxPlayers = 30 }, null);
    }
	
    void OnJoinedRoom()
    {
        PhotonNetwork.Instantiate("Personaje3d", transform.position, transform.rotation, 0);
    }
}
