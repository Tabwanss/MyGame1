using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public Button okbutton;

    public Button restartbutton;

    public InputField answerInputbox;

    public Text displayText;

    string[] answers;

    string[] questions;

    int currentQuestionNumber = 0;

    void Start()
    {
        restartbutton.gameObject.SetActive(false);
        answers = new string[3];
        questions = new string[]{
            "what is your name ?",
            "What is your fav food ?",
            "what do you like to do ?"
        };

        displayText.text = questions[currentQuestionNumber];
    }

   public void printName()


    {


        answers[currentQuestionNumber] = answerInputbox.text;

        answerInputbox.text = "";

        currentQuestionNumber =currentQuestionNumber + 1;

        if(currentQuestionNumber <= 2)
        {

        displayText.text = questions[currentQuestionNumber];

        }
        else
        {
            displayText.text = answers[0] + " like " + answers[1] + " and he Always like to " + answers[2];

            okbutton.gameObject.SetActive(false);
            answerInputbox.gameObject.SetActive(false);
            restartbutton.gameObject.SetActive(true);
        }
    }

    public void restart(){

       SceneManager.LoadScene("SampleScene");

    }

    void Update()
    {


    }
}
