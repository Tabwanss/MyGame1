using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{
    
    void Start()
{
    for (int n = 1 ; n <= 100 ; n++) 
    {
        print(n);
    }
    
    for (int n = 1 ; n <=100 ; n++)
    {
        if (n%2==0)
        {
            print(n);
        }
        
    
    }
        float x = 1.0f;
        float r = circle(x);
    float circle(float x)
    {
        float result;
        x= 3.0f;
        result =3.14f* (x*x);
        print (result);
        return result;
    }
    }


}
