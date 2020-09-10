using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fundo : Imagem
{
    public static Fundo instance { get; private set; }
    Sprite backgroudDefault;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    // Start is called before the first frame update

    private void Start()
    {
        backgroudDefault = GetComponentInChildren<SpriteRenderer>().sprite;
    }

    public void RestartBackgroud()
    {
        ChangeImage(backgroudDefault);
    }

}
