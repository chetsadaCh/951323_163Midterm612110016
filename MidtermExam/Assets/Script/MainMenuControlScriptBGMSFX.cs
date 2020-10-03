using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class MainMenuControlScriptBGMSFX : MonoBehaviour,IPointerEnterHandler{
    [SerializeField] Button buttonStart;
    [SerializeField] Button buttonOptions;
    [SerializeField] Button buttonCredits;
    [SerializeField] Button buttonExit;
   

    AudioSource audiosourceButtonUI;
    [SerializeField] AudioClip audioclipHoldOver;
    // Start is called before the first frame update
    void Start()
    {
        this.audiosourceButtonUI = this.gameObject.AddComponent<AudioSource>();
        this.audiosourceButtonUI.outputAudioMixerGroup = SingletonSoundManager.Instance.Mixer.FindMatchingGroups("Ui")[0];
        SetupButtonsDelegate();
        
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        if (audiosourceButtonUI.isPlaying)
            audiosourceButtonUI.Stop();
        audiosourceButtonUI.PlayOneShot(audioclipHoldOver);
    }
    void SetupButtonsDelegate()
    {
        buttonStart.onClick.AddListener(delegate { SelectedStageButtonClick(buttonStart); });
        buttonCredits.onClick.AddListener(delegate { CreditsButtonClick(buttonOptions); });
        buttonOptions.onClick.AddListener(delegate { OptionsButtonClick(buttonOptions); });
       buttonExit.onClick.AddListener(delegate { ExitButtonClick(buttonExit); });
       

    }
    public void SelectedStageButtonClick(Button button)
    {
         SceneManager.LoadScene("SceneStageSelect");
    }
    public void OptionsButtonClick(Button button)
    {
        if (!SingletonGameApplicationManager.Instance.IsOptionMenuActive)
             {
             SceneManager.LoadScene("SceneOptions", LoadSceneMode.Additive);
             SingletonGameApplicationManager.Instance.IsOptionMenuActive = true;
             }
         }
    public void CreditsButtonClick(Button button)
    {
        SceneManager.LoadScene("SceneCredits");
    }
    public void ExitButtonClick(Button button)
    {
         Application.Quit();
         }

}
