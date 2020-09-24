using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour 
{
    public Enemu enemy;

    public int playerHealth;
    public int damage;

    void Start()
    {
        print("player " + name );
        //enemy.enemuHealth -= damage;
        //enemy.Attack(damage);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int enemyHealth = enemy.GetHealth();
            enemy.Attack(damage);
            //print(name + " enemy dead !!!");
        }
    }
}
