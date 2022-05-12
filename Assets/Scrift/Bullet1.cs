using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet1 : MonoBehaviour
{
    public float speed; 
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,2);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    private void Move(){
        transform.position += Vector3.right * speed * Time.deltaTime;
    }
    // void OnCollisionEnter2D(Collision2D collision) //Make sure to put this out of Voids
    // {
    //     if (collision.gameObject.tag == "Box")
    //     {
    //         Debug.Log ("Collided");
    // 	}
    // }
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Box")
        {
            Destroy(gameObject);
    	}
    }
}