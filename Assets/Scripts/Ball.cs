using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D rigidbody;

    // Start is called before the first frame update


    public void Respawn() {
        transform.position = Vector3.zero;
        rigidbody.velocity = Random.insideUnitCircle.normalized * speed;
    }

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        Respawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
