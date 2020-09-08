using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonOption : MonoBehaviour
{
    [SerializeField]
    Actor prefabAtor;

   



    public string nameButton;
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

        if (prefabAtor.typeChar == "Background")
        {  //Avisar a cena
            Scene.scene.PrepareSceneBackground(prefabAtor.GetComponent<AtorBackground>());
            Scene.scene.sceneManager.background = nameButton;
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
