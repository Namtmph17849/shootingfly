using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box13 : MonoBehaviour
{
    public float speed;
    public GameObject notung;
        public float timeDuration;
    private float countdown;
    public GameObject danthung;
    // Start is called before the first frame update
    void Start()
    {
        countdown = timeDuration;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.F)){
            Destroy(gameObject);
            Instantiate(notung, transform.position, Quaternion.identity);
        }
        Move();
         countdown -= Time.deltaTime;
        if(countdown <=0){
            Instantiate(danthung, transform.position, Quaternion.identity);
            countdown = timeDuration;
        }
    }
    private void Move(){
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
