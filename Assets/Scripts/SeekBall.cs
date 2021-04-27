using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeekBall : SteeringBehaviour
{
    private GameObject targetGameObject = null;
    public Vector3 target = Vector3.zero;
    //public GameObject ball;
    //public bool isThrown = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnDrawGizmos()
    {
        if(isActiveAndEnabled && Application.isPlaying)
        {
            Gizmos.color = Color.green;
            if(targetGameObject != null)
            {
                target = targetGameObject.transform.position;
            }
            Gizmos.DrawLine(transform.position, target);
        }
    }

    public override Vector3 Calculate()
    {
        return boid.SeekForce(target);
    }
    // Update is called once per frame
    void Update()
    {
        /*if(ball == null)
        {
            ball = GameObject.FindWithTag("Ball");
            Debug.Log(ball.GetComponent<BallBehaviour>().isThrown);
        }*/
        targetGameObject = GameObject.FindWithTag("Ball");
        if(targetGameObject != null)
        {
            //ball = GameObject.Find("Ball");
            //Debug.Log(targetGameObject.GetComponent<Throw>().isThrown);
            //Debug.Log(ball.GetComponent<BallBehaviour>().isThrown);
            //Debug.Log(targetGameObject);
            
            target = new Vector3(targetGameObject.transform.position.x,0f,targetGameObject.transform.position.z);
            /*if (targetGameObject.GetComponent<Throw>().isThrown == true)
            {
                target = targetGameObject.transform.position;
            }*/
            
        }
    }
}
