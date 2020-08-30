using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade : MonoBehaviour
{
    public static Fade instance { get; private set; }


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void PlayAnimFadeOn()
    {        
        GetComponent<Animator>().SetBool("FadeOn", true);
        
    }

    public void PlayAnimFadeOff()
    {
            GetComponent<Animator>().SetBool("FadeOff", true);
        
    }

    public void FadeAnimEnded(string anim )
    {
        if (anim  == "in")
        {
            
            Scene.scene.menuOptions.AnimMenuOptions("show");
        }
        if (anim == "out")
        {
            
            //Scene.scene.menuOptions.AnimMenuOptions("hide");
        }
    }

}
