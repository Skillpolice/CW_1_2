using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;


public class QuestText : MonoBehaviour
{
    [Header("Text")]
    public Text titleText;
    public Text contentText;

    public Step startStep;
    public Step currentStep;

    [Header("Image")]
    public Image backgroundImage;
    public Image textImage;



    string race;
    string classPlayer;

    int ct;


    void Start()
    {
        ct = 0;
        race = " ";
        classPlayer = " ";

        titleText.text = "Давай сыграем в игру !!!" + "\n" + "Создайте персонажа";
        titleText.fontSize = 45;

        currentStep = startStep;
        contentText.text = currentStep.stepContent;


        textImage.sprite = currentStep.nextSpriteImageText;
        backgroundImage.sprite = currentStep.nextSpriteImage;

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1))
        {
            currentStep = currentStep.nextSteps[0];
            MetodElements();
            //Scens1();
        }
        if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2))
        {
            //Scens2();
            currentStep = currentStep.nextSteps[1];
            MetodElements();

        }
        if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3))
        {
            //Scens3();
            currentStep = currentStep.nextSteps[2];
            MetodElements();
        }
        if (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4))
        {
            //Scens3();
            currentStep = currentStep.nextSteps[3];
            MetodElements();
        }
        if (Input.GetKeyDown(KeyCode.Keypad5) || Input.GetKeyDown(KeyCode.Alpha5))
        {
            // Scens3();
            currentStep = currentStep.nextSteps[4];
            MetodElements();
        }
        if (Input.GetKeyDown(KeyCode.Keypad6) || Input.GetKeyDown(KeyCode.Alpha6))
        {
            //Scens3();
            currentStep = currentStep.nextSteps[5];
            MetodElements();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Start();
        }
    }

    private void MetodElements()
    {
        contentText.text = currentStep.stepContent;
        backgroundImage.sprite = currentStep.nextSpriteImage;
        textImage.sprite = currentStep.nextSpriteImageText;

        ct++;
        if (ct == 2)
        {
            race = currentStep.name;
        }
        if (ct == 3)
        {
            classPlayer = currentStep.name;
        }
        titleText.text = "Ваш персонаж: " + "Класс- " + race + " || Раса- " + classPlayer;

       // GetCount();
    }

    //public void Scens1()
    //{
    //    currentStep = currentStep.nextSteps[0];
    //    contentText.text = currentStep.stepContent;
    //    backgroundImage.sprite = currentStep.nextSpriteImage;
    //    textImage.sprite = currentStep.nextSpriteImageText;

    //    ct++;
    //    if (ct == 2)
    //    {
    //        race = currentStep.name;
    //    }
    //    if (ct == 3)
    //    {
    //        classPlayer = currentStep.name;
    //    }
    //    titleText.text = "Ваш персонаж: " + "Класс- " + race + " || Раса- " + classPlayer;

    //}
    //public void Scens2()
    //{
    //    currentStep = currentStep.nextSteps[1];
    //    contentText.text = currentStep.stepContent;
    //    backgroundImage.sprite = currentStep.nextSpriteImage;
    //    textImage.sprite = currentStep.nextSpriteImageText;
    //    GetCount();
    //}
    //public void Scens3()
    //{
    //    currentStep = currentStep.nextSteps[2];
    //    contentText.text = currentStep.stepContent;
    //    backgroundImage.sprite = currentStep.nextSpriteImage;
    //    textImage.sprite = currentStep.nextSpriteImageText;
    //    GetCount();
    //}


}
