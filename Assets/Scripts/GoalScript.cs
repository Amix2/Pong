using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript : MonoBehaviour
{

    [SerializeField]
    int attackingPlayer; // which player scores into this goal
    [SerializeField]
    GameManagerScript gameMan; // this will hold a reference to the game manager script

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.name == "Ball")
        {
            gameMan.GoalScored(attackingPlayer);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
