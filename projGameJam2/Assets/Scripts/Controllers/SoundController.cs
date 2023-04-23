using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] List<AudioClip> audioClips;

    public bool isMoving;

    public enum TipoAudio { Footsteps};

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (isMoving && !audioSource.isPlaying) PlayFootsteps();
        else if(!isMoving && audioSource.loop == true) audioSource.loop = false;
    }

    public void PlayFootsteps()
    {
        audioSource.clip = audioClips[0];
        audioSource.loop = true;
        audioSource.Play();
    }

    public void PlaySound(TipoAudio tipoAudio) 
    {
        
    }
}
