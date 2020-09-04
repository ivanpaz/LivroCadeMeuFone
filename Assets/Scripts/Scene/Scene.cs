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
    

    

    [Header("Externos")]
    public int numSCenes = 0;


    [Header("Temporarios de Teste")]
    public AudioClip[] audioClips;


    void Start()
    {
        fade = Fade.instance;
        menuOptions = MenuOptions.instance;
        sceneCycle = (new GameObject("SceneCycleObject")).AddComponent<SceneCycle>();

                
        sceneCycle.SetAudioList(audioClips);
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

    public void PrepararCenaChar1()
    {

    }

    public void PrepareSceneChar2(Ator prefabChar2)
    {
        Char2.instance.ChangeImage(prefabChar2.spriteAtor);
        menuOptions.MenuManager("hide");
        sceneCycle.SetAudioList(prefabChar2.atorAudioList);

    }

    public void InitSceneCycle()
    {
        sceneCycle.PlayAudioList();
    }



    
    
}
