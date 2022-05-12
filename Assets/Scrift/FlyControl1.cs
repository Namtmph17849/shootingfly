using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class FlyControl1 : MonoBehaviour
{
    private Rigidbody2D rigidbody;
    public float jumpForce;
    public Transform s;
    public GameObject dan;
    public GameObject dandoc;
    public GameObject danngang;
    public GameObject danduoi;

    public Transform s1;
    public Transform s2;
    public Transform s3;

    private float countdown;
    public float timeDuration;
        private float countdown1;
    public float timeDuration1;
        private float countdown2;
    public float timeDuration2;
        private float countdown3;
    public float timeDuration3;

    // Start is called before the first frame update

    private void Awake() {
        countdown = timeDuration;
        countdown1 = timeDuration1;
        countdown2 = timeDuration2;
        countdown3 = timeDuration3;

        
    }

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        // Points.dem = 0;
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        if(countdown <= 0){
            Instantiate(dan,s.position, Quaternion.identity);
            countdown = timeDuration;
        }
                countdown1 -= Time.deltaTime;
        if(countdown1 <= 0){
            Instantiate(dandoc,s1.position, Quaternion.identity);
            countdown1 = timeDuration1;
        }
                countdown2 -= Time.deltaTime;
        if(countdown2 <= 0){
            Instantiate(danngang,s2.position, Quaternion.identity);
            countdown2 = timeDuration2;
        }
                countdown3 -= Time.deltaTime;
        if(countdown3 <= 0){
            Instantiate(danduoi,s3.position, Quaternion.identity);
            countdown3 = timeDuration3;
        }
        if(Input.GetMouseButtonDown(0)){
            rigidbody.velocity = Vector2.up * jumpForce;
        }
    }
    // private void OnTriggerEnter2D(Collider2D other) {
    //     if (other.gameObject.tag == "Box")
    //     {
    //         Destroy(gameObject);
    // 	}
    // }
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Ground"){
            Application.LoadLevel("Gameover");
            Destroy(gameObject);
        }
        if(other.gameObject.tag == "Box"){
            Application.LoadLevel("Gameover");
            Destroy(gameObject);
        }
        if(other.gameObject.tag == "Star"){
            Destroy(other.gameObject);
            Points.dem += 1;
        }
    }
}
