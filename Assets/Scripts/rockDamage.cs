using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rockDamage : MonoBehaviour
{
    public int health = 100;
    public int Damage = 20;
    public Transform objectPointR;
    public GameObject objectsR;

    void Start()
    {
        
    }

    void Update()
    {

    }

    public void TakeDamageA (int Damage)
    {
        health -= Damage;

        Debug.Log(health);
        if (health <= 0)
        {
            Instantiate(objectsR, objectPointR.position, objectPointR.rotation);
            Instantiate(objectsR, objectPointR.position, objectPointR.rotation);
            Instantiate(objectsR, objectPointR.position, objectPointR.rotation);
            Instantiate(objectsR, objectPointR.position, objectPointR.rotation);
            Instantiate(objectsR, objectPointR.position, objectPointR.rotation);
            Destroy(gameObject);
        }
    }
}
