using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Sign_script : MonoBehaviour
{  //Put On Player
    string Sign;
    public TMP_Text Sign_text;
    public GameObject target;
    //You'll need to manually set the textbox from the prefab
    void Start()
    {

    }
    private void OnTriggerStay2D(Collider2D collision)
    { Animal animal = target.GetComponent<Animal>();
       
        //put animal class for habitat
        if (collision.gameObject.tag == "Player")
           
        {   Sign = "Press E or R to interact with the " + animal;
            if (Input.GetKey(KeyCode.E))
            {
                Sign = "";
                //Interact() function goes here!!!
                animal.Eat();
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        Sign_text.SetText(Sign);
    }
   
}
