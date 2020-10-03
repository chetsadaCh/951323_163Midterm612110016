using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ScriptBTNStageSelectScene : MonoBehaviour, IPointerEnterHandler
{
    [SerializeField] Button _backButton;
    [SerializeField] Button buttonstage1;
    [SerializeField] Button buttonstage2;

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
        _backButton.onClick.AddListener(delegate { BackToMainMenuButtonClick(_backButton); });
        buttonstage1.onClick.AddListener(delegate {Stage1ButtonClick(_backButton); });
        buttonstage2.onClick.AddListener(delegate { Stage2ButtonClick(_backButton); });
    }
    // Update is called once per frame
    public void BackToMainMenuButtonClick(Button button)
    {
        SceneManager.UnloadSceneAsync("SceneStageSelect");
        SceneManager.LoadScene("SceneMainMenu");
    }
    public void Stage1ButtonClick(Button button)
    {
        SceneManager.UnloadSceneAsync("SceneStageSelect");
        SceneManager.LoadScene("SceneStage1");
    }
    public void Stage2ButtonClick(Button button)
    {
        SceneManager.UnloadSceneAsync("SceneStageSelect");
        SceneManager.LoadScene("SceneStage2");
    }
}
