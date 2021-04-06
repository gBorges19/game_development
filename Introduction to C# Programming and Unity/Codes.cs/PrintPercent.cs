using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
 
    void Start()
    {
        const int MaxScore = 100;
        int score = 37;

        // calculate and print percent
        float percent = ((float)score / MaxScore) * 100;
        print("Percent: " + percent + "%");

    }


}
