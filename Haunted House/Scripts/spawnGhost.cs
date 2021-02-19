using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnGhost : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject spawnPrefab;
    public Transform gh;
    BoxCollider2D box;
    float distance;
    //int ghostFound = 0;
    int check=0;
   
    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //distance = Vector2.Distance(rb.position, path.vectorPath[currentWaypoint]);
        //if (check == 1)
        ///{
           // GameObject clone = Instantiate(spawnPrefab, transform.position, transform.rotation) as GameObject;
            //MakeThingToSpawn();
           // check = 2;
        //}

         //   mainSpawn();
        
    }
    /*void OnTriggerEnter2D(Collider2D other)
    {
        if (check == 0){
            if ((other.tag == "Player"))
            {
                //MakeThingToSpawn();
                check = 1;
            }
        }
        


    }
    
    void mainSpawn()
    {
       
           MakeThingToSpawn();
           check = 2;
     
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        
            if ((other.tag == "Player"))
            {
                MakeThingToSpawn();
                check = 1;
            }
       
        
    }

    void MakeThingToSpawn()
    {
    // create a new gameObject
        if (check == 0)
        {
            GameObject clone = Instantiate(spawnPrefab, transform.position, transform.rotation) as GameObject;

        }
    }
    */
}
