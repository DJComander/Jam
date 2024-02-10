using UnityEngine;
using System.Collections;

public class Hit : MonoBehaviour
{
    public GameObject Travelmode;
    public GameObject Battlemode;
    public GameObject Atom;
    public GameObject Enemy;
    public GameObject GameOver;
    public GameObject BattleMusic;
    public GameObject GoMusic;
    public GameObject DeathMusic;
    public GameObject WinMusic;
    public GameObject WinScreen;
    public AudioSource HitSound;
    float d = 0f;
    float c = 0f;
    public GameObject bar;
    public GameObject barrr;

    private Camera cam;
    private YourLevel you;
    private EnemyLevel it;
    private GameObject enemy;

    private move moveComponent;
    private Camera_Follow2 fcomp;
    private SlowMove fightmove;
    private bool inBattle = false;

    public void Start()
    {
        moveComponent = GetComponent<move>();
        fcomp = Camera.main.GetComponent<Camera_Follow2>();
        fightmove = GetComponent<SlowMove>();
        fightmove.enabled = false;
        you = GetComponent<YourLevel>();
        cam = Camera.main;

    }

    void OnCollisionEnter2D(Collision2D col)
    {
     
        enemy = col.gameObject;
        if (col.gameObject.name == "EAtom1(Clone)")
        {
            it = col.gameObject.GetComponent<EnemyLevel>();
            barrr.GetComponent<Len2>().it = it.level;
            enemy = col.gameObject;
            if (you.level == 1f)
            {
                you.level = 2f;
                TransitionToBattleMode();
            }
            else if (you.level < 1f)
            {
                Atom.transform.parent = GameOver.transform;
                Atom.transform.position = new Vector2(-129f, -180f);
                GameOver.SetActive(true);
                Travelmode.SetActive(false);
                Battlemode.SetActive(false);
                GoMusic.SetActive(false);
                BattleMusic.SetActive(false);
                DeathMusic.SetActive(true);

            }
            else if (you.level > 1f)
            {
                you.HP -= 2;
                Destroy(col.gameObject);
                if (you.HP < 0)
                {
                    Atom.transform.parent = GameOver.transform;
                    Atom.transform.position = new Vector2(-129f, -180f);
                    GameOver.SetActive(true);
                    Travelmode.SetActive(false);
                    Battlemode.SetActive(false);
                    GoMusic.SetActive(false);
                    BattleMusic.SetActive(false);
                    DeathMusic.SetActive(true);
                }

            }
        }












        if (col.gameObject.name == "EAtom2(Clone)")
        {
            it = col.gameObject.GetComponent<EnemyLevel>();
            if(you.level == 2f)
            {
                you.level = 3f;
                TransitionToBattleMode();
               
            }
            else if (you.level < 2f)
            {
                Atom.transform.parent = GameOver.transform;
                Atom.transform.position = new Vector3(-129f, -180f , 0f);
                GameOver.SetActive(true);
                Travelmode.SetActive(false);
                Battlemode.SetActive(false);
                GoMusic.SetActive(false);
                BattleMusic.SetActive(false);
                DeathMusic.SetActive(true);

            }
            else if (you.level > 2f)
            {
                you.HP -= 4;
                Destroy(col.gameObject);
                if (you.HP < 0)
                {
                    Atom.transform.parent = GameOver.transform;
                    Atom.transform.position = new Vector2(-129f, -180f);
                    GameOver.SetActive(true);
                    Travelmode.SetActive(false);
                    Battlemode.SetActive(false);
                    GoMusic.SetActive(false);
                    BattleMusic.SetActive(false);
                    DeathMusic.SetActive(true);
                }
            }
        }











        if (col.gameObject.name == "EAtom3(Clone)")
        {
            it = col.gameObject.GetComponent<EnemyLevel>();
            if (you.level == 3f)
            {
                you.level = 4f;
                TransitionToBattleMode();
               
            }
            else if (you.level < 3f)
            {
                Atom.transform.parent = GameOver.transform;
                GameOver.SetActive(true);
                Travelmode.SetActive(false);
                Battlemode.SetActive(false);
                GoMusic.SetActive(false);
                BattleMusic.SetActive(false);
                DeathMusic.SetActive(true);

            }
            else if (you.level > 3f)
            {
                you.HP -= 6;
                Destroy(col.gameObject);
                if (you.HP < 0)
                {
                    Atom.transform.parent = GameOver.transform;
                    Atom.transform.position = new Vector2(-129f, -180f);
                    GameOver.SetActive(true);
                    Travelmode.SetActive(false);
                    Battlemode.SetActive(false);
                    GoMusic.SetActive(false);
                    BattleMusic.SetActive(false);
                    DeathMusic.SetActive(true);
                }
            }
        }
        if (col.gameObject.name == "EAtom4(Clone)")
        {
            it = col.gameObject.GetComponent<EnemyLevel>();
            if (you.level == 4f)
            {
                you.level = 5f;
                TransitionToBattleMode();
               
            }
            else if (you.level < 4f)
            {
                Atom.transform.parent = GameOver.transform;
                GameOver.SetActive(true);
                Travelmode.SetActive(false);
                Battlemode.SetActive(false);
                GoMusic.SetActive(false);
                BattleMusic.SetActive(false);
                DeathMusic.SetActive(true);

            }
            else if (you.level > 4f)
            {
                you.HP -= 8;
                Destroy(col.gameObject);
                if (you.HP < 0)
                {
                    Atom.transform.parent = GameOver.transform;
                    Atom.transform.position = new Vector2(-129f, -180f);
                    GameOver.SetActive(true);
                    Travelmode.SetActive(false);
                    Battlemode.SetActive(false);
                    GoMusic.SetActive(false);
                    BattleMusic.SetActive(false);
                    DeathMusic.SetActive(true);
                }
            }
        }
        if (col.gameObject.name == "EAtom5(Clone)")
        {
            it = col.gameObject.GetComponent<EnemyLevel>();
            if (you.level == 5f)
            {
                you.level = 6f;
                TransitionToBattleMode();
               
            }
            else if (you.level < 5f)
            {
                Atom.transform.parent = GameOver.transform;
                GameOver.SetActive(true);
                Travelmode.SetActive(false);
                Battlemode.SetActive(false);
                GoMusic.SetActive(false);
                BattleMusic.SetActive(false);
                DeathMusic.SetActive(true);

            }
            else if (you.level > 5f)
            {
                you.HP -= 10;
                Destroy(col.gameObject);
                if (you.HP < 0)
                {
                    Atom.transform.parent = GameOver.transform;
                    Atom.transform.position = new Vector2(-129f, -180f);
                    GameOver.SetActive(true);
                    Travelmode.SetActive(false);
                    Battlemode.SetActive(false);
                    GoMusic.SetActive(false);
                    BattleMusic.SetActive(false);
                    DeathMusic.SetActive(true);
                }
            }
        }
        if (col.gameObject.name == "EAtom6(Clone)")
        {
            it = col.gameObject.GetComponent<EnemyLevel>();
            if (you.level == 6f)
            {
                you.level = 7f;
                TransitionToBattleMode();
                
            }
            else if (you.level < 6f)
            {
                Atom.transform.parent = GameOver.transform;
                GameOver.SetActive(true);
                Travelmode.SetActive(false);
                Battlemode.SetActive(false);
                GoMusic.SetActive(false);
                BattleMusic.SetActive(false);
                DeathMusic.SetActive(true);

            }
            else if (you.level > 6f)
            {
                you.HP -= 12;
                Destroy(col.gameObject);
                if (you.HP < 0)
                {
                    Atom.transform.parent = GameOver.transform;
                    Atom.transform.position = new Vector2(-129f, -180f);
                    GameOver.SetActive(true);
                    Travelmode.SetActive(false);
                    Battlemode.SetActive(false);
                    GoMusic.SetActive(false);
                    BattleMusic.SetActive(false);
                    DeathMusic.SetActive(true);
                }
            }
        }
        if (col.gameObject.name == "EAtom7(Clone)")
        {
            it = col.gameObject.GetComponent<EnemyLevel>();
            if (you.level == 7f)
            {
                you.level = 8f;
                TransitionToBattleMode();
                
            }
            else if (you.level < 7f)
            {
                Atom.transform.parent = GameOver.transform;
                GameOver.SetActive(true);
                Travelmode.SetActive(false);
                Battlemode.SetActive(false);
                GoMusic.SetActive(false);
                BattleMusic.SetActive(false);
                DeathMusic.SetActive(true);

            }
            else if (you.level > 7f)
            {
                you.HP -= 14;
                Destroy(col.gameObject);
                if (you.HP < 0)
                {
                    Atom.transform.parent = GameOver.transform;
                    Atom.transform.position = new Vector2(-129f, -180f);
                    GameOver.SetActive(true);
                    Travelmode.SetActive(false);
                    Battlemode.SetActive(false);
                    GoMusic.SetActive(false);
                    BattleMusic.SetActive(false);
                    DeathMusic.SetActive(true);
                }
            }
        }
        if (col.gameObject.name == "EAtom8(Clone)")
        {
            it = col.gameObject.GetComponent<EnemyLevel>();
            if (you.level == 8f)
            {
                you.level = 9f;
                TransitionToBattleMode();
                
            }
            else if (you.level < 8f)
            {
                Atom.transform.parent = GameOver.transform;
                GameOver.SetActive(true);
                Travelmode.SetActive(false);
                Battlemode.SetActive(false);
                BattleMusic.SetActive(false);
                DeathMusic.SetActive(false);
                GoMusic.SetActive(true);

            }
            else if (you.level > 8f)
            {
                you.HP -= 16;
                Destroy(col.gameObject);
                if (you.HP < 0)
                {
                    Atom.transform.parent = GameOver.transform;
                    Atom.transform.position = new Vector2(-129f, -180f);
                    GameOver.SetActive(true);
                    Travelmode.SetActive(false);
                    Battlemode.SetActive(false);
                    GoMusic.SetActive(false);
                    BattleMusic.SetActive(false);
                    DeathMusic.SetActive(true);
                }
            }
        }
        if (col.gameObject.name == "EAtom9(Clone)")
        {
            it = col.gameObject.GetComponent<EnemyLevel>();
            if (you.level == 9f)
            {
                /*Atom.transform.parent = WinScreen.transform;
                Travelmode.SetActive(false);
                GoMusic.SetActive(false);
                WinScreen.SetActive(true);

                WinMusic.SetActive(true);*/
                you.level = 10f;
                TransitionToBattleMode();


            }
            else if (you.level < 9f)
            {
                Atom.transform.parent = GameOver.transform;
                GameOver.SetActive(true);
                Travelmode.SetActive(false);
                Battlemode.SetActive(false);
                GoMusic.SetActive(false);
                BattleMusic.SetActive(false);
                DeathMusic.SetActive(true);

            }
            else if (you.level > 9f)
            {
                you.HP -= 18;
                Destroy(col.gameObject);
                if (you.HP < 0)
                {
                    Atom.transform.parent = GameOver.transform;
                    Atom.transform.position = new Vector2(-129f, -180f);
                    GameOver.SetActive(true);
                    Travelmode.SetActive(false);
                    Battlemode.SetActive(false);
                    GoMusic.SetActive(false);
                    BattleMusic.SetActive(false);
                    DeathMusic.SetActive(true);
                }
            }
        }
        
        
       
    }

    void TransitionToBattleMode()
    {
        Travelmode.SetActive(false);
        Battlemode.SetActive(true);
        Atom.transform.parent = Battlemode.transform;
        enemy.transform.parent = Battlemode.transform;
        you.HP = 50;


        enemy.transform.position = new Vector3(Atom.transform.position.x + 175, Atom.transform.position.y, enemy.transform.position.z);
        fightmove.enabled = true;
        Battlemode.SetActive(true);

        moveComponent.enabled = false;

        fcomp.enabled = false;
        inBattle = true;
        BattleMusic.SetActive(true);
        GoMusic.SetActive(false);
        bar.SetActive(true);


    }
    void Update()
    {
        Debug.Log(you.level);
        if (inBattle)
        {
            float d = Input.GetAxis("Mouse ScrollWheel");
            if (d > 0)
            {
                c += d * 5f * you.level;
                if (!HitSound.isPlaying)
                    HitSound.Play();
            }
            else if (d < 0)
            {
                c -= d * 5f * you.level;
                if (!HitSound.isPlaying)
                    HitSound.Play();
            }
            c = Mathf.Abs(c);
            /*if (it.level < 4)
            {
                c -= it.level * 0.01f;
            }
            else if (it.level < 8)
            {
                c -= it.level * 0.4f;
            }
            else
            {
                c -= it.level * 0.3f;
            }*/
            c -= it.level * 0.01f;
            you.HP += c;
            c = 0;

            if (you.HP> it.level*55)
            {
                inBattle = false;
                Destroy(enemy);
                BattleMusic.SetActive(false);
                GoMusic.SetActive(true);
                Travelmode.SetActive(true);

                Atom.transform.parent = Travelmode.transform;

                Battlemode.SetActive(false);
                fightmove.enabled = false;
                moveComponent.enabled = true;

                fcomp.enabled = true;
                cam.backgroundColor = new Color32(29 , 26 , 63 , 255);
                bar.SetActive(false);
                
            }

        }
        else if (you.level == 10f)
        {
            Atom.transform.parent = WinScreen.transform;
            Travelmode.SetActive(false);
            GoMusic.SetActive(false);
            WinScreen.SetActive(true);

            WinMusic.SetActive(true);
        }
        if(you.HP < 0.1f)
        {
            Atom.transform.parent = GameOver.transform;
            GameOver.SetActive(true);
            Travelmode.SetActive(false);
            Battlemode.SetActive(false);
            GoMusic.SetActive(false);
            BattleMusic.SetActive(false);
            DeathMusic.SetActive(true);
        }
    }
}
  
