using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Gamemanager : MonoBehaviour
{
    public Text txtTime;
    public float Timecount=30;
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        txtTime.text = Timecount.ToString("F2");
    }

    // Update is called once per frame
    void Update()
    {
        Timecount -= Time.deltaTime;
        txtTime.text = "Time:"+Timecount.ToString("F2");
       if(player.position.y < -1)
        {
            SceneManager.UnloadSceneAsync("SceneStage1");
            SceneManager.LoadScene("SceneMainMenu");
        }

    }
}
