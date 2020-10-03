using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameWin : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Win")
        {
            SceneManager.UnloadSceneAsync("SceneStage1");
            SceneManager.LoadScene("SceneStage2");
        }
    }
}
