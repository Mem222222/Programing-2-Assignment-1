using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Sign_script : MonoBehaviour
{  //Put On Player
    string Sign;
    public TMP_Text Sign_text;
    //You'll need to manually set the textbox from the prefab
    void Start()
    {

    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        Sign = "";
        //put animal class for habitat
        if (collision.gameObject.tag == "Player")
        
        {
            if (Input.GetKey(KeyCode.E))
            {
                Sign = "";
                //Interact() function goes here!!!
                
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        Sign_text.SetText(Sign);
    }
   
}
