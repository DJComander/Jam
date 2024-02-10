using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level : MonoBehaviour
{
    public GameObject Atom;
    float level, plevel;
    private Text text;
   
    void Start()
    {
        text = GetComponent<Text>();
    }


    private void OnBecameVisible()
    {
        level = Atom.GetComponent<YourLevel>().level;
        text.text = level.ToString("#"); 
    }
}
