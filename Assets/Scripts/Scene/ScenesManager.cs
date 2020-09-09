using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenesManager : MonoBehaviour
{

    public string background;
    public string idioma;
    public int numAmigos = 0;
    AudioClip introAudio;
    int[] scenesOrder; // 0 - Char; 1 - background; 2 - friends
    int actualScene = 0;

    public AudioClip audioChamada;


    public void PrepareManager(int[] parentSceneOrder)
    {
        scenesOrder = parentSceneOrder;
    }

    public void NextScene()
    {
        actualScene++;
        if (actualScene < scenesOrder.Length)
        {
            StartScene();
        }else { Debug.Log("Fim da historia"); }
        
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

    public void StartScene()
    {


        if (scenesOrder[actualScene] == 0)
        {

        }
        else
        if (scenesOrder[actualScene] == 1)
        {
            if (Scene.scene.sceneManager.idioma == "pt")
            {

                //StartCoroutine(PlayAudioClip(Scene.scene.introBack.introPt));
                AudioController.audioController.PlayAudio(Scene.scene.introBack.introPt);
                Scene.scene.menuOptions.MenuManager();
            }


        }
        else

        if (scenesOrder[actualScene] == 2)
        {
            numAmigos++;

            //Verificar se é a primeira interação com os amigos
            if (scenesOrder[actualScene - 1] != 2)
            {
                Char1.instance.PrepareActor(2);



                if (Scene.scene.sceneManager.idioma == "pt")
                {
                    Char2.instance.CleanImage();
                    Scene.scene.sceneCycle.SetAudioList(Char1.instance.GetActor().GetAudioClipScenaChar1(2));
                    Scene.scene.sceneCycle.PlayAudioListIntro();

                }


            }
            else
                if (numAmigos == 2)
            {
                Char2.instance.CleanImage();
                Char1.instance.PrepareActor(3);
                Scene.scene.sceneCycle.SetAudioList(Char1.instance.GetActor().GetAudioClipScenaChar1(3));
                Scene.scene.sceneCycle.PlayAudioListIntro();
            }
            else
                if (numAmigos == 3)
            {
                Char2.instance.CleanImage();
                Char1.instance.PrepareActor(3);
                Scene.scene.sceneCycle.SetAudioList(Char1.instance.GetActor().GetAudioClipScenaChar1(4));
                Scene.scene.sceneCycle.PlayAudioListIntro();
            }


        }
        else

        if (scenesOrder[actualScene] == 3)
        {
            Char2.instance.CleanImage();
            if (scenesOrder[actualScene-1] != 3)
            {
                Char1.instance.PrepareActor(3);
                Scene.scene.sceneCycle.SetAudioList(Char1.instance.GetActor().GetAudioClipScenaChar1(5));
                Scene.scene.sceneCycle.PlayAudioList();
            }
            else
            {
                Debug.Log("Ultima cena");
                Char1.instance.PrepareActor(3);
                Scene.scene.sceneCycle.SetAudioList(Char1.instance.GetActor().GetAudioClipScenaChar1(6));
                Scene.scene.sceneCycle.PlayAudioList();
            }
            
        }
        else
        {
            Debug.Log("Indicativo errado para cena");
        }

    }
   
}
