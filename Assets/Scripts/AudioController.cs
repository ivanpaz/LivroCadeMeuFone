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
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {

            StartCoroutine(PlayAudios(audioPlaying));
        }

    }

    IEnumerator PlayAudios(int nextAudio)
    {       
         audioSource.PlayOneShot(clip1);
         yield return new WaitForSeconds(clip1.length);
        audioSource.PlayOneShot(clip2);

    }
}
