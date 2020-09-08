using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char1 : Imagem
{
    public static Char1 instance { get; private set; }
    AtorPrincipal atorPrincipal;
    int atual;


    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

   


    public void SetActor(AtorPrincipal ator)
    {
        atorPrincipal = ator;
        PrepareActor(0);
    }

    public void PrepareActor(int momento)// 0 - Char; 1 - background; 2 - friends; 3 - Final; 
    {
        if (momento == 0)
        {
            atual = 0;
            ChangeImage(atorPrincipal.GetSprite(1));
            Scene.scene.sceneCycle.SetAudioList(atorPrincipal.GetAudioClipScenaChar1(1));

        }
        if (momento == 1)
        {
            atual = 1;
            ChangeImage(atorPrincipal.GetSprite(1));
            //Scene.scene.sceneCycle.SetAudioList
        }
        if (momento == 2)
        {
            atual = 2;
            ChangeImage(atorPrincipal.GetSprite(2));
        }
        if (momento == 3)
        {
            if(atual != 3)
            {
                ChangeImage(atorPrincipal.GetSprite(3));
            }
            else
            {
                ChangeImage(atorPrincipal.GetSprite(4));
            }
            atual = 3;
        }
    }


    

    private IEnumerator PlayAudio(AudioClip[] audios, int i)
    {
        if (i<audios.Length)
        {
            AudioController.audioController.PlayAudio(audios[i]);
            yield return new WaitForSeconds(audios[i].length);
            StartCoroutine(PlayAudio(audios, i++));
        }
        else
        {

        }
        
       
        //Scene.scene.menuOptions.MenuManager();
    }


}
