using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
   
    
    public PlayerMovement playerMovement;
    public PlayerRenderer playerRenderer;
    public PlayerAiInteractions playerAiInteractions;
    public iMovementInput movementInput;
    public PlayerAnimations playerAnimations;

    public GameObject ui_window;

    private void Start()
    {
        playerAnimations = GetComponent <PlayerAnimations>();
        playerMovement = GetComponent <PlayerMovement>();
        playerRenderer = GetComponent <PlayerRenderer>();
        playerAiInteractions = GetComponent <PlayerAiInteractions>();
        movementInput = GetComponent <iMovementInput >();
        movementInput.OnInteractEvent += () => playerAiInteractions.Interact(playerRenderer.IsSpriteFlipped);

    }


    private void FixedUpdate()
    {
        playerMovement.MovePlayer(movementInput.MovementInputVector);
        playerRenderer.RenderePlayer(movementInput.MovementInputVector);
        playerAnimations.SetUpAnimations(movementInput.MovementInputVector);

        if (movementInput.MovementInputVector.magnitude > 0)
        {
            ui_window.SetActive(false);
        }
    }

    
    public void ReceiveDamaged()
    {
        playerRenderer.FlashRed();
    }

    
}
