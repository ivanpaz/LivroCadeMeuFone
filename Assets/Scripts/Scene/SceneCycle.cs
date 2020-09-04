using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneCycle : MonoBehaviour
{
    [SerializeField]
    AudioClip[] audioList; 


   


    public void SetAudioList(AudioClip[] list)
    {
        audioList = list;

    }

    public void PlayAudioList()
    {
        StartCoroutine(PlayAudioClipList(0));
    }

    private IEnumerator PlayAudioClipList(int audioListCountPosition)
    {
        if (audioList[audioListCountPosition])
        {
            AudioController.audioController.PlayAudio(audioList[audioListCountPosition]);
            yield return new WaitForSeconds(audioList[audioListCountPosition].length);
            StartCoroutine(PlayAudioClipList(audioListCountPosition+1));
        }
        else
        {
            yield return true;
        }
    }

   

    // Update is called once per frame
    void Update()
    {
        
    }
}
