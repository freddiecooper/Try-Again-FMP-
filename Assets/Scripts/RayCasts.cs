using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCasts : MonoBehaviour
{

    public bool hit;
    public int Damage = 20;
    public GameObject objects;
    public bool hPick;
    public bool hAxe;

    private Animator anim;

    bool treeEnter;

    bool allowDamage;
    bool allowDamageA;


    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            hPick = true;
            hAxe = false;
        }
        if (Input.GetKeyDown("2"))
        {
            hPick = false;
            hAxe = true;
        }
        if (Input.GetKeyDown("3"))
        {
            hPick = false;
            hAxe = false;
        }
        
        if (Input.GetButtonDown("Fire1") && hPick == true)
        {
            anim.SetBool("Pickaxe swing",true);
        }
        else
        {
            anim.SetBool("Pickaxe swing",false);
            allowDamage = false;
        }

        if (Input.GetButtonDown("Fire1") && hAxe == true)
        {
            anim.SetBool("Axe swing",true);
        }
        else
        {
            anim.SetBool("Axe swing",false);
            allowDamageA = false;
        }
    }

    void OnTriggerStay(Collider hitInfo)
    {
        objectDamage tree = hitInfo.GetComponent<objectDamage>();
        if(tree != null && allowDamageA == true)
        {
            tree.TakeDamage(Damage);
        }

        rockDamage rock = hitInfo.GetComponent<rockDamage>();
        if(rock != null && allowDamage == true)
        {
            rock.TakeDamageA(Damage);
        }
    }

    void AD()
    {
        allowDamage = true;
        Debug.Log(allowDamage);
    }

    void ADA()
    {
        allowDamageA = true;
        Debug.Log(allowDamage);
    }

    void DAD()
    {
        //allowDamage = false;
        Debug.Log(allowDamage);
    }
}
