using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dandocscript : MonoBehaviour
{
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(0,0,90);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.up * speed * Time.deltaTime;
    }
        private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Box")
        {
            Destroy(gameObject);
    	}
    }
}
