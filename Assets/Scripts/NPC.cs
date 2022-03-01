using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class NPC : MonoBehaviour
{
   public GameObject ui_window;
   public AudioSource audioSource;

   private void Awake()
   {
       audioSource = GetComponent<AudioSource>();
   }

   public virtual void Interact()
   {
       ui_window.SetActive(true);
       
   }

    protected virtual string GetText()
    {
       return ""; 
    }

}
