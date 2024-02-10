using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Photon : MonoBehaviour
{

    public GameObject Atom;
    public GameObject ww;
    public float speed;

    private bool active = false;
    private float timeSinceHiden = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Show()
    {
        gameObject.transform.position = new Vector3(Atom.transform.position.x, Atom.transform.position.y + 300, Atom.transform.position.z);
        active = true;
        ww.SetActive(true);
    }

    void Hide()
    {
        gameObject.transform.position = new Vector3(Atom.transform.position.x - 10000, Atom.transform.position.y + 300, Atom.transform.position.z);
        active = false;
        timeSinceHiden = 0;
        ww.SetActive(false);
    }


    void OnCollisionEnter2D(Collision2D col)
    {
        if (active)
        {
            if (col.gameObject == Atom)
            {
                YourLevel playerLevel = Atom.GetComponent<YourLevel>();
                playerLevel.HP -= 10f;
                Hide();
            }
           
        }
       
    }


    void Update()
    {

        if (active)
        {
            gameObject.transform.position += Vector3.down * (speed * Time.deltaTime);
            if(Vector3.Distance(gameObject.transform.position, Atom.transform.position) > 350f)
            {
                Hide();
            }
        }
        else
        {
            if (timeSinceHiden >= 10)
            {
                Show();
            }
            else
            {
                timeSinceHiden += Time.deltaTime;
            }
        }
    }
}
