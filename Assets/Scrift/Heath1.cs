using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heath1 : MonoBehaviour
{
    private int mau = 2;
    public Sprite anh1;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
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
