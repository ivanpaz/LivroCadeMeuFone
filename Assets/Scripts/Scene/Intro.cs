using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro : MonoBehaviour
{
    public AudioClip introPt;
    public AudioClip introEn;
    public AudioClip introSp;

    [SerializeField]
    GameObject menuIntro;

    private void Start()
    {
        ActivateMenuIntro();
    }


    public void ChoosePt()
    {
        Scene.scene.sceneManager.idioma = "pt";
        StartCoroutine(PlayIntro(introPt));
        menuIntro.SetActive(false);
    }

    public void ChooseSp()
    {
        Scene.scene.sceneManager.idioma = "sp";
        StartCoroutine(PlayIntro(introSp));
        menuIntro.SetActive(false);
    }

    public void ChooseEn()
    {
        Scene.scene.sceneManager.idioma = "en";
        StartCoroutine(PlayIntro(introEn));
        menuIntro.SetActive(false);
    }


    private IEnumerator PlayIntro(AudioClip audio)
    {
        AudioController.audioController.PlayAudio(audio);
        yield return new WaitForSeconds(0.1f);
        //Scene.scene.menuOptions.ActivationMenu(Scene.scene.sceneManager.ReturnTypScene());
        Scene.scene.menuOptions.MenuManager();
    }

    public void ActivateMenuIntro()
    {
        menuIntro.SetActive(true);
    }
}
