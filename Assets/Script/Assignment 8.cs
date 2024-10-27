using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start Exercise 1:");
        while (true)
        {
            int random = Random.Range(1,20);
            if(random == 5){
                continue;
            }
            Debug.Log(random);
            if(random == 15){
                break;
            }
           
        }  
        Debug.Log("Start Exercise 2:");
        string[] words  = {"Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird"};
        int counter = 0;
        string sentence = "";
        while (counter < 7)
        {
            sentence = sentence+" "+ words[Random.Range(1,8)];
            counter++;
        }
        Debug.Log(sentence);
    }

    
}
