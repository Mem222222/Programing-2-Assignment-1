using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pengu : Animal
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

    public override void Eat()
    {
        textbox.SetText("Imma bout to poop!");
        Debug.Log("Pengu eats *munch munch*");
    }
    public override void Interact()
    {
        textbox.SetText("The Zebra is very weird, I dont like him");
       
    }


}
