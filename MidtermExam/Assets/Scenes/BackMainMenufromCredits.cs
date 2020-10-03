﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class BackMainMenufromCredits : MonoBehaviour, IPointerEnterHandler
{
    [SerializeField] Button _backButton;

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
    }
    // Update is called once per frame
    public void BackToMainMenuButtonClick(Button button)
    {
        SceneManager.UnloadSceneAsync("SceneCredits");
        SceneManager.LoadScene("SceneMainMenu");
    }
}
