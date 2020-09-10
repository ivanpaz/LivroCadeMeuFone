using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene : MonoBehaviour
{
    public static Scene scene { get; private set; }
    private void Awake()
    {
        if (scene == null)
        {
            scene = this;
            DontDestroyOnLoad(gameObject);
        }
    }


    [Header("Internos")]
    public Fade fade;
    public MenuOptions menuOptions;
    public SceneCycle sceneCycle;
    public ScenesManager sceneManager;
    
    public IntroBackground introBack;

    [SerializeField]
    int[] scenesOrder; // 0 - Char; 1 - background; 2 - friends; 3 - Final
    





    
   
    




    void Start()
    {
       
        introBack = GetComponent<IntroBackground>();
        
        fade = Fade.instance;
        menuOptions = MenuOptions.instance;
        sceneCycle = (new GameObject("SceneCycleObject")).AddComponent<SceneCycle>();
        sceneManager = (new GameObject("ScenesManagerObject")).AddComponent<ScenesManager>();
        sceneManager.PrepareManager(scenesOrder);

       
    }


   


    public void PrepareSceneChar1(AtorPrincipal prefabChar1)
    {
        //Char1.instance.ChangeImage(prefabChar1.spriteAtor);
        Char1.instance.SetActor(prefabChar1);
        menuOptions.MenuManager("hide");
    }

    public void PrepareSceneChar2(Ator prefabChar2)
    {
        Char1.instance.PrepareActor(2);
        Char2.instance.ChangeImage(prefabChar2.spriteAtor);
        menuOptions.MenuManager("hide");
        //audioClips = GetActorAudioList(prefabChar2);
        sceneCycle.SetAudioList(GetAudioList(prefabChar2));


    }

    public void PrepareSceneBackground(AtorBackground background)
    {
        
        Fundo.instance.ChangeImage(background.spriteAtor);
        menuOptions.MenuManager("hide");
       
        sceneCycle.SetAudioList(GetAudioList(background));


    }

    AudioClip[] GetAudioList( Ator ator)
    {
        if (sceneManager.idioma == "pt")
        {
            return ator.atorAudioList;
        }

        if (sceneManager.idioma == "en")
        {
            return ator.atorAudiosList_Eng;
        }

        if (sceneManager.idioma == "sp")
        {
            return ator.atorAudiosList_Spa;
        }
        else
        {
            return ator.atorAudioList; ;
        }
    }

    AudioClip[] GetAudioList(AtorBackground ator)
    {
        if (sceneManager.idioma == "pt")
        {
            return ator.backgroundAudios;
        }
        else
        if (sceneManager.idioma == "en")
        {
            return ator.backgroundAudios_Eng;
        }
        else
        if (sceneManager.idioma == "sp")
        {
            return ator.backgroundAudios_Spa;
        }
        else
        {
            return ator.backgroundAudios; ;
        }
    }



    public void InitSceneCycle()
    {
        
        sceneCycle.PlayAudioList();
    }



    
    
}
