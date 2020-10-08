using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemu : MonoBehaviour
{
    public Text enemuText;
    public int enemuHealth;
    public int damage;
    void Start()
    {
        print("enemy");
    }

    public void Attack(int dam)
    {
        enemuHealth -= dam;
        enemuText.text =  "health " + enemuHealth;
        if (enemuHealth < 0)
        {
            enemuText.text = name + " enemy dead !!!";
        }
    }

    public int GetHealth()
    {
        return enemuHealth;
    }

   
}
