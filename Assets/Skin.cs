using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skin : MonoBehaviour
{
    private YourLevel level;
    SpriteRenderer spriteRenderer;
    public GameObject mode;
    public Sprite[] imageList = new Sprite[10];
    void Start()
    {
       level =  GetComponent<YourLevel>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    
    void Update()
    {
        if (mode.active && (spriteRenderer.sprite != imageList[(int)level.level - 1]))
        {
            spriteRenderer.sprite = imageList[(int)level.level - 1];
            level.HP = 50f;

        }
    }
}
