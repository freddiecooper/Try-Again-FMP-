using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meshCollider : MonoBehaviour
{
    public GameObject mesh;
    
    void Start()
    {
        mesh.AddComponent<MeshCollider>();
    }
}
