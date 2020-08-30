using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class MenuOptions : MonoBehaviour
{

    [Header("MenuOptions")]
    bool menuState = false;
    
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

    private void Update()
    {
        if (Input.GetKeyDown("up"))
        {
            AnimMenuOptions("hide");
        }

        if (Input.GetKeyDown("down"))
        {
            AnimMenuOptions("show");
        }
    }

    void ShowMenuOptions()
    {
        Scene.scene.fade.PlayAnimFadeOn();
    }

    void HideMenuOptions()
    {
        //Scene.scene.fade.PlayAnimFadeOff();
        AnimMenuOptions("hide");
    }

    public void AnimMenuOptions(string value)
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
    }

}
