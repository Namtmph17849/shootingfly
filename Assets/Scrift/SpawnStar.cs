using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnStar : MonoBehaviour
{
   public GameObject sao;
    // Start is called before the first frame update
    private float countdown;
    public float timeDuration;
    // Start is called before the first frame update
 void Awake() {
    countdown = timeDuration;
}

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        if(countdown <= 0){
            Instantiate(sao, new Vector3(20, Random.Range(3.1f, -1.1f),0),Quaternion.identity);
            countdown = timeDuration;
        }
    }
}
