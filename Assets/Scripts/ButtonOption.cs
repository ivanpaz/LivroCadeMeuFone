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

        if (already)
        {
            DesableButton();
        }
    }

    public void OnClickedAvatar()
    {

        if (prefabAtor.typeChar == "Char1")
        {  //Avisar a cena
            Scene.scene.PrepareSceneChar1(prefabAtor.GetComponent<AtorPrincipal>());
        }
        if (prefabAtor.typeChar == "Char2")
        {  //Avisar a cena
            Scene.scene.PrepareSceneChar2(prefabAtor.GetComponent<Ator>());
        }


        DesableButton();



    }

    void DesableButton()
    {
        already = true;
        GetComponent<Image>().color = Color.grey;
        GetComponent<Button>().interactable = false;
    }

}
