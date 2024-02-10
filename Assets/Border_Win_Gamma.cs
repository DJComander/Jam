using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Border_Win_Gamma : MonoBehaviour
{
   private YourLevel you;
    public GameObject Atom;
   void Start()
    {
        you = Atom.GetComponent<YourLevel>();
    }
    
    void Update()
    {
       
        if(you.level == 12f)
        {
            //win
        }
        if(Atom.transform.position.x >= 1500)
        {
            Atom.transform.position = new Vector3(-1500, Atom.transform.position.y, Atom.transform.position.z);
        }
        if (Atom.transform.position.x <= -1500)
        {
            Atom.transform.position = new Vector3(1500, Atom.transform.position.y, Atom.transform.position.z);
        }
    }
  
}
