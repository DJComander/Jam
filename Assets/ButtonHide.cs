using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHide : MonoBehaviour
{

    public GameObject Image;
    public GameObject Canvas;
    public GameObject Button;
    public GameObject Atom;
    void Start()
    {
        
    }
    public void Disappear()
    {
        Button.SetActive(false);
        Image.SetActive(false);
        Canvas.SetActive(false);
        Atom.SetActive(true);
    }

}
