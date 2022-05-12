using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Best1 : MonoBehaviour
{
    int best1;
    Text best;
    // Start is called before the first frame update
    void Start()
    {
        best = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        best1 = Points.dem;
        if(Points.dem >= best1){
            best.text = "" + Points.dem;
        }
    }
}
