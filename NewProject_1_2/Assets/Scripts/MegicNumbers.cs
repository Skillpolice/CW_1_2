using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MegicNumbers : MonoBehaviour
{
    [Header("Ui Elements")]
    public Text title;
    public Text gameText;

    [Header("MIN MAX")]
    public int min;
    public int max;

    int guees;
    int ct;

    void Start()
    {
        min = 1;
        max = 1000;
        ct = 0;

        title.text = "magic numbers";
        title.text = "Загадай число от " + min + " до " + max;
        UpdateGuees();
    }


    public void UpNum()
    {
        min = guees;
        UpdateGuees();
    }
    public void DownNum()
    {
        max = guees;
        UpdateGuees();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            UpNum();
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            DownNum();
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {

            gameText.text = "Поздравляем это ваше число " + guees.ToString() + "\n" + "Кол-во потраченых шагов " + ct;
            gameText.fontSize = 25;
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            
            Start();
        }

    }

    public void UpdateGuees()
    {
        ct++;
        guees = (min + max) / 2;
        gameText.text = "You number " + guees.ToString() + " ?";
    }
}
