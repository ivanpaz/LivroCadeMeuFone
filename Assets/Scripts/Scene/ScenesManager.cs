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

    public void RestartSceneManager()
    {
        actualScene = 0;
        numAmigos = 0;
    }

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
        }else { 
            Debug.Log("Fim da historia");
            LastScene();
            
        }
        
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
                AudioController.audioController.PlayAudio(Scene.scene.introBack.introPt);                
            }
            if (Scene.scene.sceneManager.idioma == "sp")
            {
                AudioController.audioController.PlayAudio(Scene.scene.introBack.introSp);
            }

            if (Scene.scene.sceneManager.idioma == "en")
            {
                AudioController.audioController.PlayAudio(Scene.scene.introBack.introEn);
            }
            Scene.scene.menuOptions.MenuManager();


        }
        else

        if (scenesOrder[actualScene] == 2)
        {
            numAmigos++;

            //Verificar se é a primeira interação com os amigos
            if (scenesOrder[actualScene - 1] != 2)
            {
                Char1.instance.PrepareActor(2);


                Char2.instance.CleanImage();
                if (Scene.scene.sceneManager.idioma == "pt")
                {                    
                    Scene.scene.sceneCycle.SetAudioList(Char1.instance.GetActor().GetAudioClipScenaChar1(2));                    
                }

                if (Scene.scene.sceneManager.idioma == "sp")
                {
                    Scene.scene.sceneCycle.SetAudioList(Char1.instance.GetActor().GetAudioClipScenaChar1_sp(2));
                }

                if (Scene.scene.sceneManager.idioma == "en")
                {
                    Scene.scene.sceneCycle.SetAudioList(Char1.instance.GetActor().GetAudioClipScenaChar1_en(2));
                }
                Scene.scene.sceneCycle.PlayAudioListIntro();

            }
            else
                if (numAmigos == 2)
            {
                Char2.instance.CleanImage();
                Char1.instance.PrepareActor(3);

                if (Scene.scene.sceneManager.idioma == "pt")
                {
                    Scene.scene.sceneCycle.SetAudioList(Char1.instance.GetActor().GetAudioClipScenaChar1(3));
                }
                if (Scene.scene.sceneManager.idioma == "sp")
                {
                    Scene.scene.sceneCycle.SetAudioList(Char1.instance.GetActor().GetAudioClipScenaChar1_sp(3));
                }
                if (Scene.scene.sceneManager.idioma == "en")
                {
                    Scene.scene.sceneCycle.SetAudioList(Char1.instance.GetActor().GetAudioClipScenaChar1_en(3));
                }

                Scene.scene.sceneCycle.PlayAudioListIntro();
            }
            else
                if (numAmigos == 3)
            {
                Char2.instance.CleanImage();
                Char1.instance.PrepareActor(3);

                if (Scene.scene.sceneManager.idioma == "pt")
                {
                    Scene.scene.sceneCycle.SetAudioList(Char1.instance.GetActor().GetAudioClipScenaChar1(4));
                }
                if (Scene.scene.sceneManager.idioma == "sp")
                {
                    Scene.scene.sceneCycle.SetAudioList(Char1.instance.GetActor().GetAudioClipScenaChar1_sp(4));
                }
                if (Scene.scene.sceneManager.idioma == "en")
                {
                    Scene.scene.sceneCycle.SetAudioList(Char1.instance.GetActor().GetAudioClipScenaChar1_en(4));
                }

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
                if (Scene.scene.sceneManager.idioma == "pt")
                {
                    Scene.scene.sceneCycle.SetAudioList(Char1.instance.GetActor().GetAudioClipScenaChar1(5));
                }

                if (Scene.scene.sceneManager.idioma == "sp")
                {
                    Scene.scene.sceneCycle.SetAudioList(Char1.instance.GetActor().GetAudioClipScenaChar1_sp(5));
                }

                if (Scene.scene.sceneManager.idioma == "en")
                {
                    Scene.scene.sceneCycle.SetAudioList(Char1.instance.GetActor().GetAudioClipScenaChar1_en(5));
                }
                Scene.scene.sceneCycle.PlayAudioList();
            }
            else
            {
                Debug.Log("Ultima cena");
                Char1.instance.PrepareActor(3);
                if (Scene.scene.sceneManager.idioma == "pt")
                {
                    Scene.scene.sceneCycle.SetAudioList(Char1.instance.GetActor().GetAudioClipScenaChar1(6));
                }
                if (Scene.scene.sceneManager.idioma == "sp")
                {
                    Scene.scene.sceneCycle.SetAudioList(Char1.instance.GetActor().GetAudioClipScenaChar1_sp(6));
                }
                if (Scene.scene.sceneManager.idioma == "en")
                {
                    Scene.scene.sceneCycle.SetAudioList(Char1.instance.GetActor().GetAudioClipScenaChar1_en(6));
                }
                Scene.scene.sceneCycle.PlayAudioList();
            }
            
        }
        else
        {
            Debug.Log("Indicativo errado para cena");
        }

    }

    public void LastScene()
    {
        AudioController.audioController.PlayAudio(Char1.instance.GetActor().musicaFinal);
        StartCoroutine(ShowRestartButton());
    }

    IEnumerator ShowRestartButton()
    {
        
        yield return new WaitForSeconds(2);
        RestartController.instance.restartButton.SetActive(true);

    }

}
