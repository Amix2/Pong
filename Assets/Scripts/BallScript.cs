using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    //[SerializeField]
    public float forceValue = 4.5f;
    Rigidbody2D myBody;

    // Start is called before the first frame update
    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();
        myBody.AddForce(new Vector2(forceValue * 50, 50));
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    public void Reset()
    {
        // reset the ball position and restart the ball movement
        myBody.velocity = Vector2.zero;
        transform.position = new Vector2(0, 0);
        Start(); // restart the ball 
    }
}
