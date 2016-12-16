using UnityEngine;
using System.Collections;
using WebSocketSharp;

public class GameServer : MonoBehaviour {

    private WebSocket socket;
	void Start () {
        socket = new WebSocket("10.100.13.3");

        socket.OnMessage += (sender, e) =>
        {

        }
	}
	
	void Update () {
	
	}
}
