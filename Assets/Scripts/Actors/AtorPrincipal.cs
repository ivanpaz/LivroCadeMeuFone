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

    

    [Header("SP")]
    public AudioClip eraUmaVez01_sp;

    public AudioClip OndeEsta02_sp;

    public AudioClip procurar03_espaco_sp;
    public AudioClip procurar03_mar_sp;

    public AudioClip encontrou04_sp;

    public AudioClip continuouProcurar05_sp;
    public AudioClip encontrou06_sp;

    public AudioClip desanimada07_sp;
    public AudioClip encontrou08_sp;

    public AudioClip ningume09_sp;
    public AudioClip encontrou10_sp;
    public AudioClip naoAcredito11_sp;
    public AudioClip comemorar12_sp;

    [Header("EN")]
    public AudioClip eraUmaVez01_en;

    public AudioClip OndeEsta02_en;

    public AudioClip procurar03_espaco_en;
    public AudioClip procurar03_mar_en;

    public AudioClip encontrou04_en;

    public AudioClip continuouProcurar05_en;
    public AudioClip encontrou06_en;

    public AudioClip desanimada07_en;
    public AudioClip encontrou08_en;

    public AudioClip ningume09_en;
    public AudioClip encontrou10_en;
    public AudioClip naoAcredito11_en;
    public AudioClip comemorar12_en;


    public AudioClip musicaFinal;








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



    //ESPANHOL

    public AudioClip[] GetAudioClipScenaChar1_sp(int momento)
    {

        switch (momento)
        {
            case 1:
                AudioClip[] audios1 = new AudioClip[] { eraUmaVez01_sp };
                return audios1;
                ;

            case 2:
                AudioClip[] audios2 = new AudioClip[3];
                audios2[0] = OndeEsta02_sp;
                if (Scene.scene.sceneManager.background == "espaco")
                {
                    audios2[1] = procurar03_espaco_sp;
                }
                if (Scene.scene.sceneManager.background == "mar")
                {
                    audios2[1] = procurar03_mar_sp;
                }
                audios2[2] = encontrou04_sp;
                return audios2;


            case 3:
                AudioClip[] audios3 = new AudioClip[] { continuouProcurar05_sp, encontrou06_sp };
                return audios3;

            case 4:
                AudioClip[] audios4 = new AudioClip[] { desanimada07_sp, encontrou08_sp };
                return audios4;

            case 5:
                AudioClip[] audios5 = new AudioClip[] { ningume09_sp, encontrou10_sp };
                return audios5;

            case 6:
                AudioClip[] audios6 = new AudioClip[] { naoAcredito11_sp, comemorar12_sp };
                return audios6;


            default:
                Debug.Log("Sem audio nessa posicao");
                return null;
        }
    }


    // Ingles
    public AudioClip[] GetAudioClipScenaChar1_en(int momento)
    {

        switch (momento)
        {
            case 1:
                AudioClip[] audios1 = new AudioClip[] { eraUmaVez01_en };
                return audios1;
                ;

            case 2:
                AudioClip[] audios2 = new AudioClip[3];
                audios2[0] = OndeEsta02_en;
                if (Scene.scene.sceneManager.background == "espaco")
                {
                    audios2[1] = procurar03_espaco_en;
                }
                if (Scene.scene.sceneManager.background == "mar")
                {
                    audios2[1] = procurar03_mar_en;
                }
                audios2[2] = encontrou04_en;
                return audios2;


            case 3:
                AudioClip[] audios3 = new AudioClip[] { continuouProcurar05_en, encontrou06_en };
                return audios3;

            case 4:
                AudioClip[] audios4 = new AudioClip[] { desanimada07_en, encontrou08_en };
                return audios4;

            case 5:
                AudioClip[] audios5 = new AudioClip[] { ningume09_en, encontrou10_en };
                return audios5;

            case 6:
                AudioClip[] audios6 = new AudioClip[] { naoAcredito11_en, comemorar12_en };
                return audios6;


            default:
                Debug.Log("Sem audio nessa posicao");
                return null;
        }
    }

}
