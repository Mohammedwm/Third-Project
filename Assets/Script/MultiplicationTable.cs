using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int number = 5;
        for (int i = 1; i <= 10; i++)
        {
            Debug.Log(number+" x "+i+" = "+number*i);
        }
        
    }
    int Multiply (int num1, int num2)
    {
        int result = num1 * num2;
        return result;
    }
}
