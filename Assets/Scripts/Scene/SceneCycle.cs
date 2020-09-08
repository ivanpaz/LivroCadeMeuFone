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

    public void PlayAudioListIntro()
    {
        StartCoroutine(PlayAudioClipListIntro(0));
    }

    private IEnumerator PlayAudioClipList(int audioListCountPosition)
    {
        //if (audioList[audioListCountPosition])
        //Debug.Log("Lengh " + audioList.Length + "   Count  " + audioListCountPosition);
        if(audioList.Length > audioListCountPosition)
        {
            
            AudioController.audioController.PlayAudio(audioList[audioListCountPosition]);
            yield return new WaitForSeconds(audioList[audioListCountPosition].length);
            StartCoroutine(PlayAudioClipList(audioListCountPosition+1));
        }
        else
        {
            Debug.Log("nonooooooooo");
            Scene.scene.sceneManager.NextScene();
            yield return true;
        }
    }


    private IEnumerator PlayAudioClipListIntro(int audioListCountPosition)
    {
        //if (audioList[audioListCountPosition])
        //Debug.Log("Lengh " + audioList.Length + "   Count  " + audioListCountPosition);
        if (audioList.Length > audioListCountPosition)
        {

            AudioController.audioController.PlayAudio(audioList[audioListCountPosition]);
            yield return new WaitForSeconds(audioList[audioListCountPosition].length);
            StartCoroutine(PlayAudioClipListIntro(audioListCountPosition + 1));
        }
        else
        {

            Scene.scene.menuOptions.MenuManager();
            yield return true;
        }
    }
}
