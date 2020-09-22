using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumbersTest : MonoBehaviour
{
    int number; 

    // Start is called before the first frame update
    void Start()
    {
        number = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        // number = number + 1;
        //number += 1; // -= 1
        number++; //number--

        print(number);
    }
}
