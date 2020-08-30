using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char1 : Imagem
{
    public static Char1 instance { get; private set; }


    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
