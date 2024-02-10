using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtomSpawn : MonoBehaviour
{
    public GameObject enemy;
    public Transform enemiesParent;
    public float maxx=3000.0f;
    public float maxy=3000.0f;
    public float minx=0.0f;
    public float miny=0.0f;
    float randX;
    float randY;
    Vector2 whereToSpawn;
    public float SpawnRate = 6f;
    float nextSpawn = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > nextSpawn)
        {
            nextSpawn = Time.time + SpawnRate;
            randX = Random.Range(maxx, minx);
            randY = Random.Range(maxy, miny);
            whereToSpawn = new Vector2(randX, randY);
            GameObject newEnemy = Instantiate(enemy, whereToSpawn, Quaternion.identity);
            newEnemy.transform.parent = enemiesParent;
        }
        
    }
}
