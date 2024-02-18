using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI_script : MonoBehaviour
{
    string Interact;
    public TMP_Text Interact_Text;
    
    void Start()
    {
    
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        Interact = "Press E";
        if (collision.gameObject.tag == null)
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
