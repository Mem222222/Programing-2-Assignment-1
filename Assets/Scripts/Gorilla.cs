using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gorilla : Animal
{
    
    public bool isAggressive;

    private void Start()
    {
        moveRadius = 6; // Radius within which the object will move
        minInterval = 0; // Minimum interval between movements
        maxInterval = 100;
        rateOfHunger = 3;
        moveSpeed = 3;
        moveProbibility = 75f;
        
        CalculateNewDestination();
        MoveToRandomDestination();
    }
    private void Update()
    {
        Move();
    }

    public override void Eat()
    {
        Debug.Log("Gorilla eats *munch munch*");
    }

   
    
}
