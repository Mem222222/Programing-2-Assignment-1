using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Animal;

public class Gorilla : Animal, iinteractable, iFeedable
{
    public bool sign_triggered;
    public bool isAggressive;

    private void Start()
    {
        moveRadius = 6; // Radius within which the object will move
       
        
        rateOfHunger = 3;
        moveSpeed = 3;
        
        interval = Random.Range(1, 12);

        CalculateNewDestination();
        MoveToRandomDestination();
    }
    private void Update()
    {
        Move();
        
    }

    public void Eat()
    {
        textbox.SetText("yo thanks for da munch");
        Debug.Log("Gorilla eats *munch munch*");
    }

    public void Interact()
    {
        textbox.SetText("It gets boring in my cage");
     
    }


}
