using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    public TextMeshPro textbox;
    public float rateOfHunger;
    public float currentTemperature;
    public float health;

    //movement
    public float moveRadius; // Radius within which the object will move
    public float moveSpeed;// Maximum interval between movements

    public float timer = 0f;
    public float interval;

    public Vector3 randomDestination;
    public interface iFeedable
    {
    public abstract void Eat();
    }
    
   
    public interface iinteractable
    {
        public abstract void Interact();
    }
    public void Move()
    {
        timer += Time.deltaTime;
        if (timer >= interval)
        {
            CalculateNewDestination();
            timer = 0f;

        }

        MoveToRandomDestination();
        


    }
    public void CalculateNewDestination()
    {
        
      
        
        
        randomDestination = transform.position + Random.insideUnitSphere * moveRadius;
       
        
    }

    public void MoveToRandomDestination()
    {
        transform.position = Vector3.MoveTowards(transform.position, randomDestination, moveSpeed * Time.deltaTime);
    }
    public IEnumerator Wait() 
    { 
        while (true) {
            
            randomDestination = transform.position + Random.insideUnitSphere * moveRadius;

            yield return new WaitForSeconds(Random.Range(1, 12));
        }
            


    }
}

