using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCasts : MonoBehaviour
{

    public bool hit;
    public int Damage = 20;
    public GameObject objects;

    bool treeEnter;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    /*void OnTriggerStay(Collider hitInfo)
    {
        objectDamage tree = hitInfo.GetComponent<objectDamage>();
        if(tree != null && Input.GetButton("Fire1"))
        {
            tree.TakeDamage(Damage);
        }     
    }*/
}
