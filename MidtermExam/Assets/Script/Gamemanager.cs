using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Gamemanager : MonoBehaviour
{
    public Text txtTime;
    public Text txtScore;
    public float Timecount;
    private float score ;

    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        Timecount = 30;
            score = 0;
        txtTime.text = Timecount.ToString("F2");
        txtScore.text = score.ToString("F2");
    }

    // Update is called once per frame
    void Update()
    {
        Timecount -= Time.deltaTime;
        txtTime.text = "Time:"+Timecount.ToString("F2");
        score = Timecount * 1000;
        txtScore.text = "Score:" + score.ToString("F2");
        if (player.position.y < -1 || Timecount<=0f)
        {

            SceneManager.UnloadSceneAsync("SceneStage1");
            SceneManager.LoadScene("SceneMainMenu");
        }

    }
}
