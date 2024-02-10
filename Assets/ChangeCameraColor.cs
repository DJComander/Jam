using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCameraColor : MonoBehaviour
{
    void OnEnable()
    {
        Camera.main.backgroundColor = Color.grey;
    }
}
