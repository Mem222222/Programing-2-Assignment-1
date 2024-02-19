using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Animal;

public class Zebra : Animal, iinteractable, iFeedable
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

    public  void Eat()
    {
        textbox.SetText("*num num num*  *BURAP*");
        Debug.Log("zbra eats *munch munch*");
    }
    public void Interact()
    {
        textbox.SetText("wanna see a magic trick? I can make my water bowl disappear!");
        
    }


}
