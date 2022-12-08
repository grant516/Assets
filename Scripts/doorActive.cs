using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class doorActive : MonoBehaviour
{
    private bool nearDoor;
    public int ana;

    // private void OnTriggerEnter2D (Collider2D cool)
    // {
    //     SceneManager.LoadScene(ana);
    // }

    void Start()
    {
        nearDoor = false;
    }

    public void OpenDoor()
    {
        if (nearDoor) 
        {
            gameObject.SetActive(false);
        }
    }

    public void ClosedDoor()
    {
        gameObject.SetActive(true);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(ana);
            nearDoor = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        nearDoor = false;
    }
}
