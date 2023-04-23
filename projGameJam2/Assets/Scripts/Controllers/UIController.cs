using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField] GameObject configPanel;
    [SerializeField] Slider soundVolumeSlider;
    [SerializeField] Slider musicVolumeSlider;

    bool isPanelActive;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && SceneManager.GetActiveScene().buildIndex != 0) ConfigPanel();
    }

    public void ChangeScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

    public void ConfigPanel()
    {
        isPanelActive = !isPanelActive;

        if (isPanelActive) Time.timeScale = 0;
        else Time.timeScale = 1;

        configPanel.SetActive(isPanelActive);
    }

    public void ExitButton()
    {
        Application.Quit();
    }  

    public void RefreshSliders(float soundVolume, float musicVolume)
    {
        soundVolumeSlider.value = soundVolume;
        musicVolumeSlider.value = musicVolume;
    }
}
