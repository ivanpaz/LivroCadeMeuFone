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
    SceneCycle sceneCycle;
    public ScenesManager sceneManager;
    [SerializeField]
    int[] scenesOrder; // 0 - Char; 1 - background; 2 - friends
    





    [Header("Externos")]

    public Hashtable gameConfig;


    [Header("Temporarios de Teste")]
    public AudioClip[] audioClips;


    void Start()
    {
        gameConfig = new Hashtable();

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

    public void PrepararCenaChar1()
    {

    }

    public void PrepareSceneChar2(Ator prefabChar2)
    {
        Char2.instance.ChangeImage(prefabChar2.spriteAtor);
        menuOptions.MenuManager("hide");
        //audioClips = GetActorAudioList(prefabChar2);
        sceneCycle.SetAudioList(GetActorAudioList(prefabChar2));


    }

    AudioClip[] GetActorAudioList( Ator ator)
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



    public void InitSceneCycle()
    {
        
        sceneCycle.PlayAudioList();
    }



    
    
}
