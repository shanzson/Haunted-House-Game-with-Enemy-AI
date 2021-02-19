using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class KillPlayer : MonoBehaviour
{
    public GameObject playAgainButtons;
    public GameObject mainMenuButtons;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            Destroy(gameObject);
            if (playAgainButtons)
                playAgainButtons.SetActive(true);
            if (mainMenuButtons)
                mainMenuButtons.SetActive(true);
        }
    }

}
