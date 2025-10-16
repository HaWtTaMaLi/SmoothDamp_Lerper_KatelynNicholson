using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    //game object 1 moves position A to B using vector3.lerp
    //setup a timer
    //game object 2 moves from position C to D using vevtor3.smoothdamp

    public Transform objectOne;
    private Vector3 startPosOne = new Vector3(-4, 0, 5.5f);
    private Vector3 endPosOne = new Vector3(4, 0, 5.5f);

    public Transform objectTwo;
    private Vector3 startPosTwo = new Vector3(4, 1.5f, 5.5f);
    private Vector3 endPosTwo = new Vector3(-4, 1.5f, 5.5f);


    private Vector3 velocity = Vector3.zero;
    public float moveDuration = 3f; //how long lerp movement lasts
    public float smoothTime = 1f; //how smooth feels
    public float timer = 0f;


    void Start()
    {
        //set positions
        objectOne.position = startPosOne;
        objectTwo.position = endPosOne;
        
    }

    
    void Update()
    {
        
    }
}
