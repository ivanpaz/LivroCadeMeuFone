using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtorPrincipal : Actor
{

    [Header("Sprites")]
    [SerializeField]
    Sprite spriteAtor_1;
    [SerializeField]
    Sprite spriteAtor_2;
    [SerializeField]
    Sprite spriteAtor_3;
    [SerializeField]
    Sprite spriteAtor_4;


    //AudioClip[] audios;


    [Header("Clips")]
    [Header("PT")]  
    public AudioClip eraUmaVez01;

    public AudioClip OndeEsta02;

    public AudioClip procurar03_espaco;
    public AudioClip procurar03_mar;

    public AudioClip encontrou04;

    public AudioClip continuouProcurar05;
    public AudioClip encontrou06;

    public AudioClip desanimada07;
    public AudioClip encontrou08;

    public AudioClip ningume09;
    public AudioClip encontrou10;
    public AudioClip naoAcredito11;
    public AudioClip comemorar12;






   



    //---------------------------------//


    public Sprite GetSprite (int a)
    {
        if (a == 1)
        {
            return spriteAtor_1;
        }

        if (a == 2)
        {
            return spriteAtor_2;
        }

        if (a == 3)
        {
            return spriteAtor_3;
        }

        if (a == 4)
        {
            return spriteAtor_4;
        }
        return spriteAtor;
    }

    public AudioClip[] GetAudioClipScenaChar1(int momento)
    {
        
        switch (momento)
        {
            case 1:
                AudioClip[] audios1 = new AudioClip[] { eraUmaVez01 };
                return audios1;
                ;

            case 2:
                AudioClip[] audios2 = new AudioClip[3];
                audios2[0] = OndeEsta02;
                if (Scene.scene.sceneManager.background == "espaco")
                {
                    audios2[1] = procurar03_espaco;
                }
                if (Scene.scene.sceneManager.background == "mar")
                {
                    audios2[1] = procurar03_mar;
                }
                audios2[2] = encontrou04;
                return audios2;
                

            case 3:
                AudioClip[] audios3 = new AudioClip[] { continuouProcurar05, encontrou06 };
                return audios3;

            case 4:
                AudioClip[] audios4 = new AudioClip[] { desanimada07, encontrou08 };
                return audios4;

            case 5:
                AudioClip[] audios5 = new AudioClip[] { ningume09, encontrou10 };
                return audios5;

            case 6:
                AudioClip[] audios6 = new AudioClip[] { naoAcredito11  , comemorar12 };
                return audios6;


            default:
                Debug.Log("Sem audio nessa posicao");
                return null;
        }
    }
}
