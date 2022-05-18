using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectDamage : MonoBehaviour
{

    public int health = 100;
    public int Damage = 20;
    public Transform objectPoint;
    public GameObject objects;

    void Start()
    {
        
    }

    void Update()
    {

    }

    public void TakeDamage (int Damage)//, GameObject objects)
    {
        health -= Damage;

        Debug.Log(health);
        if (health <= 0)
        {
            //Instantiate(objects, new Vector3(0, 0, 0), Quaternion.identity);
            Instantiate(objects, objectPoint.position, objectPoint.rotation);
            Destroy(gameObject);
        }
    }
}
