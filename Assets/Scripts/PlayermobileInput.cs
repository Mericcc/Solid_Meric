using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayermobileInput : MonoBehaviour, iMovementInput 
{
   public Vector2 MovementInputVector { get; private set; }
  
   public event Action OnInteractEvent;
}
