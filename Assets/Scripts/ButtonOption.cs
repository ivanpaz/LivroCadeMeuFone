using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonOption : MonoBehaviour
{
    [SerializeField]
    Ator prefabAtor;

   



    public string name;
    public bool already = false;
   

    void Start()
    {
        GetComponent<Image>().sprite = prefabAtor.avatar;
        GetComponent<Button>().interactable = true;
    }

    public void OnClickedAvatar()
    {
        if (prefabAtor.typeChar == "Char2")
        {
            //Avisar a cena
            Scene.scene.PrepareSceneChar2(prefabAtor);

            already = true;

            GetComponent<Button>().interactable = false;
        }
        

    }

}
