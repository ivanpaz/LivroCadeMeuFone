using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioClip clip1;
    public AudioClip clip2;
    int audioCount = 2;
    int audioPlaying = 1;
    private AudioSource audioSource;

    public static AudioController audioController { get; private set; }
    private void Awake()
    {
        if (audioController == null)
        {
            audioController = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

   

    IEnumerator PlayAudios(int nextAudio)
    {       
         audioSource.PlayOneShot(clip1);
         yield return new WaitForSeconds(clip1.length);
        audioSource.PlayOneShot(clip2);

    }


    public void PlayAudio(AudioClip audio)
    {
        audioSource.PlayOneShot(audio);
    }

    public void StopAll()
    {
        audioSource.Stop();
    }

}
