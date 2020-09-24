using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MagicNum : MonoBehaviour
{
    public Text title;

    public int min;
    public int max;
    int guess;

    void Start()
    {
        //работа в сцене Текст 
        title.text = "magic Numbers";
        title.color = Color.red;
        title.fontSize = 12;

        print("Закадайте число от 1 до " + max);
        UpdateGuess();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) //нажатие клавишы вверх и вычитание среднеарефметичесткого
        {
            min = guess;
            UpdateGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow)) //нажатие клавишы вниз и вычитание среднеарефметичесткого
        {

            max = guess;
            UpdateGuess();
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            print("Поздравляем это ваше число " + guess + " !!!");
            Start();
        }
    }


    void UpdateGuess()
    {
        guess = (min + max) / 2;
        print("ваше число " + guess + " ?");

    }

}
