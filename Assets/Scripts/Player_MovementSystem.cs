using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_MovementSystem : MonoBehaviour
{

    Rigidbody RB;
    public Player_AnimationSystem AnimSystem;
    public Vector3 MovementDirection;
    public Player_InputActions PlayerInputs;

    public enum PlayerStates
    {
        Player_Idle,
        Player_Move,
        Player_Sleep
    }

    private static PlayerStates currentPlayerState = PlayerStates.Player_Idle;

    public PlayerStates GetCurrentPlayerState()
    {
        return currentPlayerState;
    }

    public static void ChangeCurrentPlayerState(PlayerStates newPlayerState)
    {
        currentPlayerState = newPlayerState;
    }

    // Start is called before the first frame update
    void Start()
    {
        PlayerInputs = new Player_InputActions();
        PlayerInputs.Enable();
        RB = transform.GetComponent<Rigidbody>();
        AnimSystem.Player = this;
    }

    // Update is called once per frame
    void Update()
    {
        GetInput();
    }


    void GetInput()
    {
        MovementDirection = Camera.main.transform.forward * PlayerInputs.Player.Move.ReadValue<Vector2>().y + Camera.main.transform.right * PlayerInputs.Player.Move.ReadValue<Vector2>().x;

        if (currentPlayerState == PlayerStates.Player_Idle)
        {
            if (MovementDirection != Vector3.zero)
            {
                currentPlayerState = PlayerStates.Player_Move;
            }
            else
            {
                RB.velocity = Vector3.Lerp(RB.velocity, Vector3.zero, Time.deltaTime * 0.2f);
            }

        }

        if(currentPlayerState == PlayerStates.Player_Move)
        {
            Vector3 TargetPosition = MovementDirection;
            if (MovementDirection != Vector3.zero)
            {
                currentPlayerState = PlayerStates.Player_Move;
                TargetPosition.y = 0;
                Quaternion newRotation = Quaternion.LookRotation(TargetPosition);
                transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, Time.deltaTime / 0.1f);
            }
            else
            {
                currentPlayerState = PlayerStates.Player_Idle;
            }
            RB.velocity = Vector3.Lerp(RB.velocity, MovementDirection * 4, Time.deltaTime / 0.1f);

        }

        if(currentPlayerState == PlayerStates.Player_Sleep)
        {
            RB.velocity = Vector3.Lerp(RB.velocity, Vector3.zero, Time.deltaTime * 0.2f);
        }
        
    }

    public static void sleep()
    {
        ChangeCurrentPlayerState(PlayerStates.Player_Sleep);
    }

}
