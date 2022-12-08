using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class door1 : MonoBehaviour
{
    public int ana;

    private void OnTriggerEnter2D (Collider2D cool)
    {
        SceneManager.LoadScene(ana);
    }
}
