﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenuControlScript : MonoBehaviour
{
    [SerializeField] Button _startButton;
    [SerializeField] Button _howtoplayButton;
    [SerializeField] Button _scoreButton;
    [SerializeField] Button _optionsButton;
    [SerializeField] Button _exitButton;
    // Start is called before the first frame update
    void Start()
    {
        _startButton.onClick.AddListener(delegate { StartButtonClick(_startButton); });
        _optionsButton.onClick.AddListener(delegate { OptionsButtonClick(_optionsButton); });
        _howtoplayButton.onClick.AddListener(delegate {howtoplayButtonClick(_howtoplayButton); });
        _scoreButton.onClick.AddListener(delegate { scoreButtonClick(_scoreButton); });
        _exitButton.onClick.AddListener(delegate { ExitButtonClick(_exitButton); });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartButtonClick(Button button)
    {
        SceneManager.LoadScene("SceneGameplay");
    }
    public void howtoplayButtonClick(Button button)
    {
        SceneManager.LoadScene("SceneHowtoplay");
    }
    public void scoreButtonClick(Button button)
    {
        SceneManager.LoadScene("SceneScore");
    }
    public void OptionsButtonClick(Button button)
    {
       if (!SingletonGameApplicationManager.Instance.IsOptionMenuActive)
        {
            SceneManager.LoadScene("SceneOptions", LoadSceneMode.Additive);
            SingletonGameApplicationManager.Instance.IsOptionMenuActive = true;
        }
    }
    public void ExitButtonClick(Button button)
    {
        Application.Quit();
    }
}