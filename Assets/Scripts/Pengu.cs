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
        if (sign_triggered)
        {
            sign_triggered = false;
            //action here!
        }
    }

    public override void Eat()
    {
        Debug.Log("Gorilla eats *munch munch*");
    }

   
    
}
