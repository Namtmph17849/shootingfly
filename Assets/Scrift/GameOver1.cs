using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver1 : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LoadLevel(){
        Application.LoadLevel("SampleScene");
        Points2.dem1 = 0;
        Points.dem = 0;

    }
}
