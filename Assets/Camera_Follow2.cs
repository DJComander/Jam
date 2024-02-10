using UnityEngine;

public class Camera_Follow2 : MonoBehaviour
{
    private Vector3 TargetPosition;
    public Transform player;
    public Vector3 offset;
    public float speed;
    private Camera cam;
    //Color coll = new Color(21f, 26f, 58f, 255f);
    private void Start()
    {
        //cam = GetComponent<Camera>();
        
       
        
    }
    void Update()
    {
       // cam.backgroundColor = coll;
    }
    
    void FixedUpdate()
    {
       TargetPosition = player.position + offset;
        transform.position = Vector3.Lerp(transform.position, TargetPosition, Time.deltaTime * speed);
        
    }
}
