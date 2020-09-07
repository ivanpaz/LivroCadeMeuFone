using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonOption : MonoBehaviour
{
    [SerializeField]
    Actor prefabAtor;

   



    public string name;
    public bool already = false;
   

    void Start()
    {
        GetComponent<Image>().sprite = prefabAtor.avatar;
        GetComponent<Button>().interactable = true;
    }

    public void OnClickedAvatar()
    {

        if (prefabAtor.typeChar == "Char1")
        {  //Avisar a cena
            Debug.Log("Char1111");
        }
        if (prefabAtor.typeChar == "Char2")
        {  //Avisar a cena
            Scene.scene.PrepareSceneChar2(prefabAtor.GetComponent<Ator>());
        }


        already = true;
        GetComponent<Image>().color = Color.grey;
        GetComponent<Button>().interactable = false;



    }

}
