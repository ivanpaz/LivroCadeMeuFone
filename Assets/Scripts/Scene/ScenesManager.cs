using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenesManager : MonoBehaviour
{

    public string background;
    public string idioma;
    AudioClip introAudio;
    int[] scenesOrder; // 0 - Char; 1 - background; 2 - friends
    int actualScene = 0;


    public void PrepareManager(int[] parentSceneOrder)
    {
        scenesOrder = parentSceneOrder;
    }

    public void NextScene()
    {
        actualScene++;
    }

    public int ReturnTypScene()
    {
        return scenesOrder[actualScene];
    }

    public void PlayIntro(AudioClip audio)
    {
        StartCoroutine(PlayAudioClip(audio));
    }

    private IEnumerator PlayAudioClip(AudioClip audio)
    {
        AudioController.audioController.PlayAudio(audio);
        yield return new WaitForSeconds(audio.length);
        yield return true;
    }

    public void PlayScene()
    {
        if (scenesOrder[actualScene] == 0)
        {

        }
        if (scenesOrder[actualScene] == 1)
        {

        }

        if (scenesOrder[actualScene] == 2)
        {

        }

    }
   
}
