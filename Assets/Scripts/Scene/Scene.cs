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
    





    [Header("Externos")]

    public Hashtable gameConfig;


    [Header("Temporarios de Teste")]
    public AudioClip[] audioClips;


    void Start()
    {
        gameConfig = new Hashtable();
        introBack = GetComponent<IntroBackground>();
        
        fade = Fade.instance;
        menuOptions = MenuOptions.instance;
        sceneCycle = (new GameObject("SceneCycleObject")).AddComponent<SceneCycle>();
        sceneManager = new ScenesManager();
        sceneManager.PrepareManager(scenesOrder);

        //sceneCycle.SetAudioList(audioClips);
    }



    // Update is called once per frame
    void Update()
    {
        InputsTests();

    }

    void InputsTests()
    {

        if (Input.GetKeyDown("space"))
        {
            
            menuOptions.MenuManager();

        }

        if (Input.GetKeyDown("p"))
        {
            sceneCycle.PlayAudioList();
        }
    }


    public void prepareGame(string language)
    {
        //pt - en - sp
        switch (language)
        {
            case "pt":
                gameConfig.Add("Language", "pt");
                break;

            case "en":
                gameConfig.Add("Language", "en");
                break;

            case "sp":
                gameConfig.Add("Language", "sp");
                break;

            default:
                gameConfig.Add("Language", "pt");
                break;

        }

    }

    public void PrepareSceneChar1(AtorPrincipal prefabChar1)
    {
        //Char1.instance.ChangeImage(prefabChar1.spriteAtor);
        Char1.instance.SetActor(prefabChar1);
        menuOptions.MenuManager("hide");
    }

    public void PrepareSceneChar2(Ator prefabChar2)
    {
        Char2.instance.ChangeImage(prefabChar2.spriteAtor);
        menuOptions.MenuManager("hide");
        //audioClips = GetActorAudioList(prefabChar2);
        sceneCycle.SetAudioList(GetAudioList(prefabChar2));


    }

    public void PrepareSceneBackground(AtorBackground background)
    {
        Debug.Log(background.spriteAtor.name);
        Char2.instance.ChangeImage(background.spriteAtor);
        menuOptions.MenuManager("hide");
       
        sceneCycle.SetAudioList(GetAudioList(background));


    }

    AudioClip[] GetAudioList( Ator ator)
    {
        if (gameConfig["Language"].ToString() == "pt")
        {
            return ator.atorAudioList;
        }
        else
        if (gameConfig["Language"].ToString() == "en")
        {
            return ator.atorAudiosList_Eng;
        }
        else
        if (gameConfig["Language"].ToString() == "pt")
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
        if (gameConfig["Language"].ToString() == "pt")
        {
            return ator.backgroundAudios;
        }
        else
        if (gameConfig["Language"].ToString() == "en")
        {
            return ator.backgroundAudios_Eng;
        }
        else
        if (gameConfig["Language"].ToString() == "pt")
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
