using UnityEngine;
using System.Collections;

public class Len2 : MonoBehaviour
{
    public GameObject enemy;
    public float it;
    float c = 0f;
    float time = 0f;
    void OnEnable()
    {
        c = 0f;
    }
    void Update()
    {
        time += Time.deltaTime;
        if (time > 1.5f)
        {
          
            float d = Input.GetAxis("Mouse ScrollWheel");
            time = 0f;
            if (d > 0)
            {
                c += d * 100f;

            }
            else if (d < 0)
            {
                c -= d * 100f;

            }

            if (it < 4)
            {
                c -= it * 2f;
            }
            else if (it < 8)
            {
                c -= it * 1.2f;
            }
            else
            {
                c -= it * 0.8f;
            }
            if (c < 100f && c > -100f)
            {
                transform.localScale = new Vector3(transform.localScale.x - c, transform.localScale.y, transform.localScale.z);
            }
        }

     

    }
}