using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCasts : MonoBehaviour
{

    public bool hit;
    public objectDamage _obj;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast (transform.position,transform.TransformDirection (Vector3.forward), out RaycastHit hitinfo, 20f))
        {
            hit = true;
        }
        else
        {
            hit = false;
        }

        
        if (hit == true && Input.GetButton("Fire1"))
        {
            _obj.TakeDamage();
            //_obj.GetComponent<objectDamage>().TakeDamage();
            //objectDamage.TakeDamage(Damage);
            
        }

        //Debug.Log(hit);
    }
}
