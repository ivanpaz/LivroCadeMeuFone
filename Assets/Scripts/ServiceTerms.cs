using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServiceTerms : MonoBehaviour
{
    // Start is called before the first frame update
    public void OpenTerms()
    {
        Application.OpenURL("https://docs.google.com/document/d/18PmC5IyElv0lkRgdkqqCFSfWbM40dtWbuG3mw51fi3U/edit?usp=sharing");
    }
}
