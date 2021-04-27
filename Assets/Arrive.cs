using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class Arrive : SteeringBehaviour
{
    public Vector3 targetPosition = Vector3.zero;
    public float slowingDistance = 15.0f;

    private GameObject targetGameObject = null;

    public override Vector3 Calculate()
    {
        return boid.ArriveForce(targetPosition, slowingDistance);
    }

    public void Update()
    {
        targetGameObject = GameObject.FindWithTag("Ball");
        if (targetGameObject != null)
        {
            //targetPosition = targetGameObject.transform.position;
            targetPosition = new Vector3(targetGameObject.transform.position.x,0f,targetGameObject.transform.position.z);
        }
    }
}