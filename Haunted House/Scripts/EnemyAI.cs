using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Pathfinding;

public class EnemyAI : MonoBehaviour
{
    public Transform target;
    public float speed = 200f;
    public float nextWaypointDistance = 3f;
   
    Path path;
    int currentWaypoint = 0;
    bool reachedEndOfPath = false;
    //int cho = 0;
    Seeker seeker;
    Rigidbody2D rb;
    int check;
    //Vector2 force;
    public Transform enemyGFX;

    //TextMeshPro mText = gameObject.GetComponent<TextMeshPro>();

    public Text spottedText;


    void Start()
    {
        seeker = GetComponent<Seeker>();
        rb = GetComponent<Rigidbody2D>();
        
       
        InvokeRepeating("Updatepath", 0f, 0.5f);
        
        
        //seeker.StartPath(rb.position, target.position, OnPathComplete);
    }

    void Updatepath()
    {
        if(seeker.IsDone())
            seeker.StartPath(rb.position, target.position, OnPathComplete); //Generate seeker path

    }

    void OnPathComplete(Path p)         //To check a complete path has been found
    {
        if (!p.error)
        {
            path = p;
            currentWaypoint = 0;
        }
    }
    
    
    // Update is called once per frame
    void FixedUpdate()
    {
        

            if (path == null)
                return;
            if (currentWaypoint >= path.vectorPath.Count)//Total amount of waypoints in path
            {
                reachedEndOfPath = true;
                return;
            }
            else
            {
                reachedEndOfPath = false;
            }

            float dis = Vector2.Distance(transform.position, target.transform.position);
            if (dis <= 6.0f)
            {
                spottedText.text = "You Have Been Spotted!";
            // Debug.Log("Inside: " + dis);
                Vector2 direction = ((Vector2)path.vectorPath[currentWaypoint] - rb.position).normalized;

                    Vector2 force = direction * speed * Time.deltaTime;

                    rb.AddForce(force);

                //checkDistance(force);

                float distance = Vector2.Distance(rb.position, path.vectorPath[currentWaypoint]);
            

                if (distance < nextWaypointDistance)
                {
                    currentWaypoint++;
                }
                 if (force.x >= 0.01f)
                {
                    enemyGFX.localScale = new Vector3(0.6f, 0.6f, 1f);
                }
                else if (force.x <= -0.0f)
                {
                    enemyGFX.localScale = new Vector3(-0.6f, 0.8f, 1f);
                }
            }
        else
        {
            spottedText.text = "";
        }

        

            
      //  }
        
    }

    void checkDistance(Vector2 force)
    {
        float dist= Vector2.Distance(rb.position, path.vectorPath[currentWaypoint]);
        Debug.Log("Distance: "+dist);
        if (dist <= 2.0f)
        {
            rb.AddForce(force);
        }
        else
            return;
    }
}
