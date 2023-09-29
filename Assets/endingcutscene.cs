using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endingcutscene : MonoBehaviour
{
    bool TouchedPlayer;
    private void Update()
    {
        if (TouchedPlayer)
        {
            SceneManager.LoadScene(6);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {

            TouchedPlayer = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            TouchedPlayer = false;
        }
    }
}


    /*
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                PlayerScript.TommyEquipped = true;
                gameObject.SetActive(false);
            }
        }
    }
    */
