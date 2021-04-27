using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throw : MonoBehaviour
{
    public int distance;
    public GameObject ball;
    public float speed = 25.0f;
    public Transform playerPos;
    //public bool isFetch = false;
    private float ballThrowTime = 0f;
    private int numBall = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (numBall > 1)
        {
            //Add check for if ball is fetched
        }
        else if(Time.time >= ballThrowTime && Input.GetKeyDown("space")){
            //transform.Translate(0, 0, speed * Time.deltaTime);
            ballThrowTime = Time.time + 1 / numBall;
            ThrowForDog();
            numBall = numBall + 1;
        }
    }

    public void ThrowForDog()
    {
        GameObject b = Instantiate(ball, playerPos.position,playerPos.rotation) as GameObject;
        b.GetComponent<Rigidbody>().AddForce(playerPos.forward * speed, ForceMode.Impulse);
    }
}
