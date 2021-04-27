using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class Arrive : SteeringBehaviour
{
    public Vector3 targetPosition = Vector3.zero;
    public float slowingDistance = 10.0f;

    private GameObject targetGameObject = null;
    public bool isfetch;
    public Transform player;
    public GameObject dog;
    public Transform ball;

    public Vector3 dogPos; 

    public override Vector3 Calculate()
    {
        return boid.ArriveForce(targetPosition, slowingDistance);
    }

    public void Update()
    {
        
        if(GameObject.FindWithTag("Ball") != null)
        {
            targetGameObject = GameObject.FindWithTag("Ball");
            ball = targetGameObject.transform;
        }
        if (targetGameObject != null)
        {
            //targetPosition = targetGameObject.transform.position;
            targetPosition = new Vector3(targetGameObject.transform.position.x,0f,targetGameObject.transform.position.z);
            dogPos = new Vector3(dog.transform.position.x, 0f, dog.transform.position.z);
            /*if((dogPos - targetPosition) > 0.1)
            {
                dog.GetComponent<RetrieveBall>().ball = targetGameObject;
                dog.GetComponent<RetrieveBall>().enabled = true;
            }*/
        }
        /*if(Vector3.Distance(transform.position, targetGameObject.transform.position) > 1)
        {
            dog.GetComponent<RetrieveBall>().ball = targetGameObject;
            dog.GetComponent<RetrieveBall>().enabled = true;
        }
        if(dog.GetComponent<RetrieveBall>().enabled == true)
        {
            targetPosition = new Vector3(player.position.x,0f,player.position.z);
        }*/
    }
}