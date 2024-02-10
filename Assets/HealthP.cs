using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthP : MonoBehaviour
{
    //public Hit iop
    private YourLevel you;
    private float hp;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hp = you.HP;

    }
}
