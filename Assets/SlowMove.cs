using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowMove : MonoBehaviour
{

    public GameObject Atom;
  
    void OnEnable()
    {
      
        StartCoroutine(MoveAtomLeft(250, 0.5f));
    }

    IEnumerator MoveAtomLeft(float distance, float time)
    {
        float timer = 0;
        Vector3 startPosition = Atom.transform.position;
        Vector3 destination = startPosition + Vector3.left * distance;
        while (timer < time)
        {
            timer += 0.01f;
            yield return new WaitForSeconds(0.01f);
            Atom.transform.position = Vector3.Lerp(startPosition, destination, timer / time); ;
        }

        Atom.transform.position = startPosition + Vector3.left * distance;
    }
}
