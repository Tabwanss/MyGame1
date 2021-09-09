using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Button okBotton;

    public InputField answerField;

    void Start()
    {
      print ("hell");   
    }
    public void printName()
    {
        print(answerField.text);
    }
      
   
    void Update()
    {
        
    }
}
