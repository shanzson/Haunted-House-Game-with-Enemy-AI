using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class keyController : MonoBehaviour
{
    public Image key;
    //private Image image;
    // Start is called before the first frame update
    void Start()
    {/*
        GameObject go = GameObject.Find("Canvas");
        if (!go)
            return;

        image = go.GetComponent<Image>();
        */
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            
            //if (image)
              //  image.enabled = !image.enabled;
            Destroy(gameObject);

            //GameObject clone = Instantiate(spawnPrefab, transform.position, transform.rotation) as GameObject;
            key.enabled = true;
        }
    }
}
