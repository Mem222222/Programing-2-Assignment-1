using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI_script : MonoBehaviour
{   //Put On Player
    string Interact;
    public TMP_Text Interact_Text;
    //You'll need to manually set the textbox from the prefab
    void Start()
    {
    
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        Sign_script signclass = collision.GetComponent<Sign_script>();
        Interact = "Press E";
        if (signclass)
            //change null to sign tag once made
        {
            if (Input.GetKey(KeyCode.E))
            {
                Interact = "";
                //Interact() function goes here!!!
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        Interact_Text.SetText(Interact);
    }
}
