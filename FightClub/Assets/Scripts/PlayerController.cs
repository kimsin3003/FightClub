using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    private Animator fightAnimation;

    void Start()
    {
        fightAnimation = GetComponent<Animator>();
    }

    public void Punch()
    {
        fightAnimation.SetTrigger("punch");
    }

    public void WalkBack(bool onWalkBack)
    {
        fightAnimation.SetBool("GoingForward", onWalkBack);
    }

    public void WalkForward(bool onWalkForward)
    {
        fightAnimation.SetBool("GoingBack", onWalkForward);
    }

    public void Guard(bool onGuard)
    {
        fightAnimation.SetBool("Guard", onGuard);
    }
}
