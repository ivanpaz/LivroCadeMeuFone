using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene : MonoBehaviour
{
    [Header("Internos")]
    public Fade fade;
    public MenuOptions menuOptions;
    

    public static Scene scene { get; private set; }
    private void Awake()
    {
        if (scene == null)
        {
            scene = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    [Header("Externos")]
    public int numSCenes = 0;
    



    void Start()
    {
        fade = Fade.instance;
        menuOptions = MenuOptions.instance;
    }


    







    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("space"))
        {
            menuOptions.MenuManager();  
            
        }

    }

    
    
}
