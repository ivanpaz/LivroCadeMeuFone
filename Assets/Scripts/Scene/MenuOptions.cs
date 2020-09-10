using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class MenuOptions : MonoBehaviour
{

    [Header("MenuOptions")]
    bool menuState = false;

    [SerializeField]
    GameObject menuButtonsChar1;
    [SerializeField]
    GameObject menuButtonsChar2;
    [SerializeField]
    GameObject menuButtonsBackground;


    // Start is called before the first frame update

    public static MenuOptions instance { get; private set; }
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
     void Start()
    {
        DesactiveMenus();

    }

    public void MenuManager()
    {
        if (menuState)
        {
            menuState = false;
            HideMenuOptions();
        }
        else
        {
            menuState = true;
            ShowMenuOptions();
        }
    }

    public void MenuManager(string command)
    {
        switch (command)
        {
            case "show":
                menuState = true;
                ShowMenuOptions();
            break;

            case "hide":
                menuState = false;
                HideMenuOptions();
            break;

            default:
                Debug.Log("Comando errado");
                break;


        }
    }

   public void ActivationMenu(int typeMenuScene )
    {
        ActiveMenuScene(typeMenuScene);
    }

    public void ActivationMenu(bool a)
    {
        DesactiveMenus();
    }

    void ActiveMenuScene(int type)
    {
        if (type == 0)
        {
            menuButtonsChar1.SetActive(true);
        }
        if (type == 1)
        {
            menuButtonsBackground.SetActive(true);
        }
        if (type == 2)
        {
            menuButtonsChar2.SetActive(true);
        }
    }

    public void DesactiveMenus()
    {
        menuButtonsChar1.SetActive(false);
        menuButtonsBackground.SetActive(false);
        menuButtonsChar2.SetActive(false);
        //RestartController.instance.restartButton.SetActive(false);
    }

    void ShowMenuOptions()
    {
        Scene.scene.fade.PlayAnimFadeOn();
    }



    void HideMenuOptions()
    {
        Scene.scene.fade.PlayAnimFadeOff();
        //AnimMenuOptions("hide");
    }






   /* public void AnimMenuOptions(string value)
    {
        if( value == "show")
        {
            
            gameObject.GetComponentInChildren<Animator>().SetBool("menuActive", true);
            gameObject.GetComponentInChildren<Animator>().SetBool("action", true);
        }
        if(value == "hide")
        {
            gameObject.GetComponentInChildren<Animator>().SetBool("menuActive", false);
            gameObject.GetComponentInChildren<Animator>().SetBool("action", true);
        }
    }*/

}
