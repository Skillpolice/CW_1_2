using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestText : MonoBehaviour
{
    public Text titleText;
    public Text contentText;

    public Step startStep;

    public Step currentStep;

    

    void Start()
    {
        titleText.text = "Давай сыграем в игру !!!";
        titleText.fontSize = 45;


        currentStep = startStep;
        contentText.text = startStep.stepContent;

       
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            //Scens1();
            //string stepOne = "Вы пришли в пещеру иуды";

            currentStep = currentStep.newxtSteps[0];
            contentText.text = currentStep.stepContent;
        }
        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            //Scens2();
            //contentText.text = "Вы откозали!!!";
            currentStep = currentStep.newxtSteps[1];
            contentText.text = currentStep.stepContent;
        }
        if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            //Scens3();
            contentText.text = "Вы мертвы!!!";
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Start();
        }
    }

    //public void Scens1()
    //{
    //    contentText.text = "Вы пришли в пещеру иуды";
    //}
    //public void Scens2()
    //{
    //    contentText.text = "Вы откозали!!!";
    //}
    //public void Scens3()
    //{
    //    contentText.text = "Вы мертвы!!!";
    //}


}
