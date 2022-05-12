using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heath2 : MonoBehaviour
{
    private int mau = 3;
    public Sprite anh2,anh1;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if(mau == 2){
            this.gameObject.GetComponent<SpriteRenderer>().sprite = anh2;
        }
        if(mau == 1){
            this.gameObject.GetComponent<SpriteRenderer>().sprite = anh1;
        }
        if(mau == 0){
            Destroy(gameObject);
            Points.dem += 1;
            Points2.dem1 +=1;
        }
}
private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Player"){
            Destroy(other.gameObject);
        }
        if(other.gameObject.tag == "Bullet"){
            mau -= 1;
        }
    }
}
