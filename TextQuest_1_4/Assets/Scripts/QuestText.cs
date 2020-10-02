using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;

public class QuestText : MonoBehaviour
{
    public Text titleText;
    public Text contentText;

    public Step startStep;
    public Step currentStep;

    string race;
    string classPlayer;

    int ct;
    

    

    void Start()
    {
        ct = 0;

        titleText.text = "Давай сыграем в игру !!!" + "\n" + "Создайте персонажа";
        titleText.fontSize = 45;

        currentStep = startStep;
        contentText.text = startStep.stepContent;
 
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            //Scens1();
            ct++;
            currentStep = currentStep.nextSteps[0];
            contentText.text = currentStep.stepContent;
            if(ct == 2)
            {
                race =  currentStep.name;
            }
            if(ct ==3)
            {
                classPlayer = currentStep.name;
            }

            titleText.text = "Ваш персонаж: " + "Класс- " + race + " Раса- " + classPlayer;
        }
        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            //Scens2();
            ct++;
            currentStep = currentStep.nextSteps[1];
            contentText.text = currentStep.stepContent;
            if (ct == 2)
            {
                race = currentStep.name;
            }
            if (ct == 3)
            {
                classPlayer = currentStep.name;
            }

            titleText.text = "Ваш персонаж: " + "Класс- " + race + " Раса- " + classPlayer;
        }
        if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            //Scens3();
            ct++;
            currentStep = currentStep.nextSteps[2];
            //currentStep = currentStep.startPlayer[2];
            contentText.text = currentStep.stepContent;
            if (ct == 2)
            {
                race = currentStep.name;
            }
            if (ct == 3)
            {
                classPlayer = currentStep.name;
            }

            titleText.text = "Ваш персонаж: " + "Класс- " + race + " Раса- " + classPlayer;
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
