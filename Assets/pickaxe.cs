using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickaxe : MonoBehaviour
{

    public GameObject Pickaxe;
    public GameObject Axe;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            Pickaxe.SetActive(true);
            Axe.SetActive(false);
        }
        if (Input.GetKeyDown("2"))
        {
            Pickaxe.SetActive(false);
            Axe.SetActive(true);
        }
        if (Input.GetKeyDown("3"))
        {
            Pickaxe.SetActive(false);
            Axe.SetActive(false);
        }
    }
}
