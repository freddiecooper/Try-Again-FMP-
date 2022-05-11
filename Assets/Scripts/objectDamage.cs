using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectDamage : MonoBehaviour
{

    public int health = 100;
    public int Damage = 20;
    //public RayCasts RC;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (RC.hit == true)
        //{
        //   TakeDamage();
        //}
        //TakeDamage();
    }

    public void TakeDamage ()
    {
        health -= Damage;

        if (health <= 0)
        {
            DestroyImmediate(gameObject);
        }
    }
}
