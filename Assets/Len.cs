using UnityEngine;
using System.Collections;

public class Len : MonoBehaviour
{
    public GameObject Atom;
    float lasthp = 50f;
    void Update()
    {
     
        YourLevel level = Atom.GetComponent<YourLevel>();
        if (level.HP != lasthp) {
            float size = level.HP / 50f;
            lasthp = level.HP;
            transform.localScale = new Vector3(transform.localScale.x * size, transform.localScale.y, transform.localScale.z);
        }
        if (level.HP == 50f)
        {
            transform.localScale = new Vector3(-100f, transform.localScale.y, transform.localScale.z);
        }


    }
}