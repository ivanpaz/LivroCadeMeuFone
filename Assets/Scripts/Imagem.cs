using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Imagem : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeImage(Sprite img)
    {       
        GetComponentInChildren<SpriteRenderer>().sprite = img;
    }

    public void CleanImage()
    {
        GetComponentInChildren<SpriteRenderer>().sprite = null;
    }

    public string TesteSingle()
    {
        return "opa";
    }
}
