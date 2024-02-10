using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levb : MonoBehaviour
{
    public GameObject b2, me;
    // Start is called before the first frame update
    void Update()
    {
        if (me.activeSelf)
            Visible();
        else
            Invisible();
    }
    void Visible()
    {
        b2.SetActive(true);
    }

    void Invisible()
    {
        b2.SetActive(false);
    }
    // Update is called once per
}
