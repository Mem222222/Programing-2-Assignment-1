using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    
    public float rateOfHunger;
    public float currentTemperature;
    public float health;

    //movement
    public float moveRadius; // Radius within which the object will move
    public float minInterval; // Minimum interval between movements
    public float maxInterval;
    public float moveSpeed;// Maximum interval between movements

    public Vector3 randomDestination;
    public float nextMoveTime;
    public float moveProbibility;
    public abstract void Eat();
    public void Move()
    {

        if (nextMoveTime > moveProbibility && transform.position == randomDestination)
        {
            CalculateNewDestination();
            MoveToRandomDestination();

        }
        else if (transform.position == randomDestination) { CalculateNewDestination(); }
        else { MoveToRandomDestination(); }
                

        
    }
    public void CalculateNewDestination()
    {
        
        nextMoveTime = Time.time + Random.Range(minInterval, maxInterval);
        if (transform.position == randomDestination)
        {
            randomDestination = transform.position + Random.insideUnitSphere * moveRadius;
        }
        
    }

    public void MoveToRandomDestination()
    {
        transform.position = Vector3.MoveTowards(transform.position, randomDestination, moveSpeed * Time.deltaTime);
    }
}

