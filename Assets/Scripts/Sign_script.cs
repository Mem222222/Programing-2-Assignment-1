using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static Animal;

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
    {
        iinteractable animal = target.GetComponent<iinteractable>();
        iFeedable animal2 = target.GetComponent<iFeedable>();
        //put animal class for habitat
        if (collision.gameObject.tag == "Player")
           
        {   
            if (Input.GetKey(KeyCode.E))
            {
                Sign = "You feed the " + animal + " Crack!";
                //Interact() function goes here!!!
               animal2.Eat();
            }
            if (Input.GetKey(KeyCode.R))
            {
                Sign = "You petted and interaced with the " + animal;
                //Interact() function goes here!!!
                animal.Interact();
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Sign = "";
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Animal animal = target.GetComponent<Animal>();
        if (collision.gameObject.tag == "Player")
        {
            Sign = "Press E or R to interact with the " + animal;
        }
    }
    // Update is called once per frame
    void Update()
    {
        Sign_text.SetText(Sign);
    }
   
}
