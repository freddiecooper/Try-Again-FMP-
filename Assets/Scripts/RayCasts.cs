using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCasts : MonoBehaviour
{

    public bool hit;
    public int Damage = 20;
    public GameObject objects;

    private Animator anim;

    bool treeEnter;

    bool allowDamage;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetButtonDown("Fire1"))
        {
            anim.SetBool("Pickaxe swing",true);
        }
        else
        {
            anim.SetBool("Pickaxe swing",false);
            allowDamage = false;
            //Debug.Log(allowDamage);
        }
    }

    void OnTriggerStay(Collider hitInfo)
    {
        objectDamage tree = hitInfo.GetComponent<objectDamage>();
        if(tree != null && allowDamage == true)
        {
            tree.TakeDamage(Damage);
        }     
    }

    void AD()
    {
        allowDamage = true;
        Debug.Log(allowDamage);
    }

    void DAD()
    {
        //allowDamage = false;
        Debug.Log(allowDamage);
    }
}
