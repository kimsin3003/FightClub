using UnityEngine;
using System.Collections;

public class Refree : MonoBehaviour {

    [SerializeField] private PlayerController player;
    [SerializeField] private PlayerController opponent;
    [SerializeField] private GameServer gameServer; 

	void Start () {
	
	}
	
	void Update () {
        PlayerMove();
        OpponentMove();
    }

    void OpponentMove()
    {
    }


    void PlayerMove()
    {
        bool punch = Input.GetMouseButtonDown(0);
        bool guard = Input.GetMouseButtonDown(1);
        bool a = Input.GetKeyDown(KeyCode.A);
        bool d = Input.GetKeyDown(KeyCode.D);

        if (punch)
        {
            player.Punch();
        }

        if (guard)
        {
            player.Guard(true);
        }

        if (d)
        {
            player.WalkForward(true);
        }

        if (a)
        {
            player.WalkBack(true);
        }


        a = Input.GetKeyUp(KeyCode.A);
        d = Input.GetKeyUp(KeyCode.D);
        guard = Input.GetMouseButtonUp(1);

        if (guard)
        {
            player.Guard(false);
        }

        if (d)
        {
            player.WalkForward(false);
        }

        if (a)
        {
            player.WalkBack(false);
        }
    }
}
