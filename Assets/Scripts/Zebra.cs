using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zebra : Animal
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
        textbox.SetText("*num num num*  *BURAP*");
        Debug.Log("zbra eats *munch munch*");
    }

   
    
}
