using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemu : MonoBehaviour
{
    public int enemuHealth;
    public int damage;
    void Start()
    {
        print("enemy");
    }

    public void Attack(int dam)
    {
        enemuHealth -= dam;
        print("health " + enemuHealth);
        if (enemuHealth < 0)
        {
            print(name + " enemy dead !!!");
        }
    }

    public int GetHealth()
    {
        return enemuHealth;
    }

   
}
