using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerMovement : MonoBehaviour
{
    public static int spawnEnemy = 0;
    public Transform pl;
    public static int haveKey = 0;
    public static int haveTreasure = 0;
    public float direction;

    public float speed = 5.0f;

    private int dir = 0;

    private Animator anim;

   // bool _facingRight = true;
    bool _isGrounded = false;
    bool _isRunning = false;
    bool _canDoubleJump = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        direction = Input.GetAxis("Horizontal");

        

        GetComponent<Rigidbody2D>().velocity = new Vector2(direction*speed,Input.GetAxis("Vertical")*speed);

        /*if (direction != 0)
        {
            anim.SetBool("Running", true);
            anim.SetBool("Grounded", true);
        }
        else
        {
            anim.SetBool("Running", false);
            anim.SetBool("Grounded", true);
        }*/

        if (direction>= 0.001f)
        {
            //Debug.Log("In: "+1);
            dir = 0;
            
        }
        else if(direction <= -0.0f)
        {
            //Debug.Log("In: " + 2);
            dir = 1;
     
        }

        if(dir==0)
            transform.rotation = Quaternion.Euler(0, 0, 0);
        else if(dir==1)
            transform.rotation = Quaternion.Euler(0, 180, 0);

        if (direction != 0)
        {
            anim.SetBool("Running", true);
            anim.SetBool("Grounded", true);
        }
        else
        {
            anim.SetBool("Running", false);
            anim.SetBool("Grounded", true);
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            spawnEnemy = 1;
        }

        if (other.tag == "Key")
        {
            haveKey = 1;
        }

    }
    
    
        private void OnCollisionEnter2D(Collision2D treasure)
        {
            if((treasure.gameObject.tag=="Treasure") && (haveKey == 1))
            {
            //Debug.Log("Game Over");
                SceneManager.LoadScene("WinScreen");
            }
        }
        
        
}
