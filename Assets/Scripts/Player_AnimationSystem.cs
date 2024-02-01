using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_AnimationSystem : MonoBehaviour
{

    public Player_MovementSystem Player;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = transform.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Player.GetCurrentPlayerState() == Player_MovementSystem.PlayerStates.Player_Idle)
        {
            anim.SetInteger("CurrentStateNumber", 0);
        }
        else if(Player.GetCurrentPlayerState() == Player_MovementSystem.PlayerStates.Player_Move)
        {
            anim.SetInteger("CurrentStateNumber", 1);
        }
        else if (Player.GetCurrentPlayerState() == Player_MovementSystem.PlayerStates.Player_Sleep)
        {
            anim.SetInteger("CurrentStateNumber", 2);
        }
    }
}
