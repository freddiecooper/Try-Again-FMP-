using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class RockGenerator : MonoBehaviour
{
    [SerializeField] GameObject prefab;

    [Header("Raycast Settings")]
    [SerializeField] int density;
    [SerializeField] float minHeight;
    [SerializeField] float maxHeight;
    [SerializeField] Vector2 xRange;
    [SerializeField] Vector2 zRange;

    public bool autoUpdate;

    void Start()
    {
        //GenerateRock();
    }

#if UNITY_EDITOR

    public void GenerateRock()
    {
        Clear();

        for (int i = 0; i < density; i++)
        {
            float sampleX = Random.Range(xRange.x, xRange.y);
            float sampleY = Random.Range(zRange.x, zRange.y);
            Vector3 rayStart = new Vector3(sampleX, maxHeight, sampleY);

            if (!Physics.Raycast(rayStart, Vector3.down, out RaycastHit hit, Mathf.Infinity))
                continue;

            if (hit.point.y < minHeight)
                continue;

            GameObject instantiatedPrefab = (GameObject)PrefabUtility.InstantiatePrefab(this.prefab, transform);
            instantiatedPrefab.transform.position = hit.point;
        }
    }

    public void Clear()
    {
        while (transform.childCount != 0)
        {
            DestroyImmediate(transform.GetChild(0).gameObject);
        }
    }
#endif
}

