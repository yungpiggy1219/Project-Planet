using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCredits : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rb;
    public float speed;
    void Start()
    {
        rb.velocity = new Vector3(speed, 0, 0);
    }

    
}
