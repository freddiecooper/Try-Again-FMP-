using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCasts : MonoBehaviour
{

    public bool hit;
    public objectDamage _obj;
    public int Damage = 20;
    

    bool treeEnter;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider hitInfo)
    {
        objectDamage tree = hitInfo.GetComponent<objectDamage>();
        if(tree != null)
        {
            treeEnter = true;
        }
        else
        {
            treeEnter = false;
        }

        if (treeEnter == true && Input.GetButtonDown("Fire1"))
        {
            tree.TakeDamage(Damage);
        }
    }
}
