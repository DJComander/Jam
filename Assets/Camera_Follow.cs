using UnityEngine;

public class Camera_Follow : MonoBehaviour
{
    
    public Transform player;
    public Vector3 offset;
  

    void Update()
    {

    }

    void FixedUpdate()
    {
        transform.position = player.position + offset;
       
    }
}
