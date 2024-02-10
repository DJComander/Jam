using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUp : MonoBehaviour
{
    public Transform Atom;
    public float Level = 1f;
    public Sprite sprite1;
    public Sprite sprite2;

    private SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    
    void Update()
    {
       if(Atom.position.y> 600)
        {
            Level = 2;
            

        }
        if (Atom.position.y < -300)
        {
            Level = 2;
            
        }
        if (Atom)
        if (Atom.position.y > 2600)
        {
            Level = 3;
                
            }
        if (Atom.position.y < -2300)
        {
            Level = 3;
            
        }
        if (Atom.position.y > 4600)
        {
            Level = 4;
        }
        if (Atom.position.y < -2300)
        {
            Level = 4;
        }
        if (Atom.position.y > 6600)
        {
            Level = 5;
        }
        if (Atom.position.y < -2300)
        {
            Level = 5;
        }
    }
}

