using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    [SerializeField] List<AudioSource> soundSources;
    [SerializeField] AudioSource musicSource;

    [SerializeField] List<AudioClip> musics;

    UIController uiController;
    
    private void Start()
    {
        uiController = GetComponent<UIController>();

        uiController.RefreshSliders(AudioManager.soundVolume, AudioManager.musicVolume);

        StartCoroutine(PlayRandomMusic());
    }

    public void ChangeSoundVolume(float volume)
    {
        AudioManager.soundVolume = volume;

        foreach (var audioSource in soundSources)
        {
            audioSource.volume = volume;
        }

        uiController.RefreshSliders(AudioManager.soundVolume, AudioManager.musicVolume);
    }

    public void ChangeMusicVolume(float volume)
    {
        AudioManager.musicVolume = volume;
        musicSource.volume = AudioManager.musicVolume;

        uiController.RefreshSliders(AudioManager.soundVolume, AudioManager.musicVolume);
    }

    IEnumerator PlayRandomMusic()
    {
        while (musicSource.isPlaying) yield return null;

        int currentIndex = Random.Range(0, musics.Count);

        musicSource.clip = musics[currentIndex];
        musicSource.Play();

        yield break;
    }
}
