using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBox : MonoBehaviour
{
    public GameObject box1,box2,box3,box4,box5;
    public Transform s1,s2,s3,s4,s5;
    // Start is called before the first frame update

    public float spawnRate = 5f;
    float nextSpawn = 0f;
    int whatToSpawn;


    // Update is called once per frame
    void Update()
    {
        if(Time.time > nextSpawn){
            whatToSpawn = Random.Range(1,6);
            Debug.Log(whatToSpawn);

            switch(whatToSpawn){
                case 1:
                Instantiate(box1,s1.position, Quaternion.identity);
                Instantiate(box2,s2.position, Quaternion.identity);
                Instantiate(box3,s3.position, Quaternion.identity);
                Instantiate(box5,s4.position, Quaternion.identity);
                Instantiate(box4,s5.position, Quaternion.identity);
                break;
                case 2:
                Instantiate(box1,s1.position, Quaternion.identity);
                Instantiate(box3,s2.position, Quaternion.identity);
                Instantiate(box2,s3.position, Quaternion.identity);
                Instantiate(box4,s4.position, Quaternion.identity);
                Instantiate(box5,s5.position, Quaternion.identity);
                break;
                case 3:
                Instantiate(box5,s1.position, Quaternion.identity);
                Instantiate(box2,s2.position, Quaternion.identity);
                Instantiate(box5,s3.position, Quaternion.identity);
                Instantiate(box1,s4.position, Quaternion.identity);
                Instantiate(box4,s5.position, Quaternion.identity);
                break;
                case 4:
                Instantiate(box4,s1.position, Quaternion.identity);
                Instantiate(box3,s2.position, Quaternion.identity);
                Instantiate(box5,s3.position, Quaternion.identity);
                Instantiate(box2,s4.position, Quaternion.identity);
                Instantiate(box1,s5.position, Quaternion.identity);
                break;
                case 5:
                Instantiate(box3,s1.position, Quaternion.identity);
                Instantiate(box2,s2.position, Quaternion.identity);
                Instantiate(box4,s3.position, Quaternion.identity);
                Instantiate(box5,s4.position, Quaternion.identity);
                Instantiate(box1,s5.position, Quaternion.identity);
                break;
                case 6:
                Instantiate(box5,s1.position, Quaternion.identity);
                Instantiate(box2,s2.position, Quaternion.identity);
                Instantiate(box4,s3.position, Quaternion.identity);
                Instantiate(box3,s4.position, Quaternion.identity);
                Instantiate(box1,s5.position, Quaternion.identity);
                break;
            } 
            nextSpawn = Time.time + spawnRate;
        }






        // countdown -= Time.deltaTime;
        // if(countdown <=0){
            
        //     Instantiate(box1,s1.position, Quaternion.identity);
        //     Instantiate(box2,s2.position, Quaternion.identity);
        //     Instantiate(box3,s3.position, Quaternion.identity);
        //     Instantiate(box4,s4.position, Quaternion.identity);
        //     Instantiate(box5,s5.position, Quaternion.identity);
            
        //     countdown = timeDuration;
        // }
    }
}
