using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meshCollider : MonoBehaviour
{
    public GameObject mesh;
    
    void Start()
    {
        //mesh.AddComponent<MeshCollider>();
    }

    public void GenerateCollider()
    {
        DestroyImmediate(GetComponent<MeshCollider>());
        mesh.AddComponent<MeshCollider>();
    }


}
