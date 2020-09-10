using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartController : MonoBehaviour
{
    public static RestartController instance { get; private set; }
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    [Header("ButtonRestart")]
    [SerializeField]
    public GameObject restartButton;

    [Header("Buttons")]
    [SerializeField]
    ButtonOption[] buttons;

    


    public void RestartGame()
    {
        AudioController.audioController.StopAll();
        RestartButtons();
        Scene.scene.sceneManager.RestartSceneManager();
        RestartImages();
        MenuOptions.instance.DesactiveMenus();
        GetComponent<Intro>().ActivateMenuIntro();
    }

    void RestartButtons()
    {
        foreach(ButtonOption b in buttons)
        {
            b.EnableButton();
        }
    }

    void RestartImages()
    {
        Fundo.instance.RestartBackgroud();
        Char1.instance.CleanImage();
        Char2.instance.CleanImage();
    }


}
