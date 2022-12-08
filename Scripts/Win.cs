using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    public int gameWinScene;
    



    private void OnTriggerEnter2D(Collider2D other) {

        SceneManager.LoadScene(gameWinScene);
        
    }
}
