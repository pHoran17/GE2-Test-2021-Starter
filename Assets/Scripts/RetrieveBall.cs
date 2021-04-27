using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RetrieveBall : SteeringBehaviour
{
    public GameObject ball;
    public GameObject dog;
    public Transform player;

    [HideInInspector]
    public Boid b;


    void onEnable()
    {
        ball = GameObject.FindWithTag("Ball");
        GameObject dogMouth = GameObject.FindWithTag("Mouth");
        ball.GetComponent<Rigidbody>().useGravity = false;
        ball.GetComponent<Rigidbody>().isKinematic = true;
        ball.transform.SetParent(dogMouth.transform);
        ball.transform.position = dogMouth.transform.position;
    }
    public void Awake()
    {
        b = GetComponent<Boid>();
    }

    public override Vector3 Calculate()
    {
        return b.ArriveForce(player.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
