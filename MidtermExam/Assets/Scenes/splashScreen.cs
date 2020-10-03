using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class splashScreen : MonoBehaviour
{
    Image anim;
    public float delay;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Image>();
        StartCoroutine("playAnim");
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("SceneMainMenu");
        }
      
        
    }
    IEnumerator playAnim()
    {
        var result = SceneManager.LoadSceneAsync("SceneMainMenu");
        result.allowSceneActivation = false;
        yield return new WaitForSeconds(delay);
        result.allowSceneActivation = true;
        
    }
}
