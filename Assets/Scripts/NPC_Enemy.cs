using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC_Enemy : NPC
{
    
    public Text textField;
    public string text = "I deal 10 physical damage    ( •̀ᴗ•́ )و ̑̑ ";

    public override void Interact()
    {
        base.Interact();
        audioSource.Play();
        FindObjectOfType<Player>().ReceiveDamaged();
    }

    protected override string GetText()
    {
        return text;
    }

}
