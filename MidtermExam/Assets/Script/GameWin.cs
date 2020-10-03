using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameWin : MonoBehaviour
{
    Gamemanager2 time;
    private void Start()
    {
        time = FindObjectOfType<Gamemanager2>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Win")
        {
            SceneManager.UnloadSceneAsync("SceneStage1");
            SceneManager.LoadScene("SceneStage2");
        }
        if (collision.collider.tag == "Green")
        {
            time.Timecount -= 3;
          
        }
        if (collision.collider.tag == "Red")
        {
            time.Timecount -= 5;
            
        }
        if (collision.collider.tag == "Blue")
        {
            time.score -= 500;
            
        }
    }
}
