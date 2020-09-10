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
    [SerializeField]
    Animator animMenuCredits;

    [Header("ButtonRestart")]
    [SerializeField]
    public GameObject restartButton;
    

    [Header("Buttons")]
    [SerializeField]
    ButtonOption[] buttons;

    private void Update()
    {
        if (Input.GetKeyDown("left"))
        {
            ShowMenu();
        }

        if (Input.GetKeyDown("right"))
        {
            HideMenu();
        }
    }

    public void ShowMenu()
    {
        animMenuCredits.SetBool("show", true);
    }

    public void HideMenu()
    {
        animMenuCredits.SetBool("hide", true);
    }

    public void RestartGame()
    {

        HideMenu();
        StartCoroutine(BackMenu());

        
    }

    IEnumerator BackMenu()
    {

        yield return new WaitForSeconds(0.8f);
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
