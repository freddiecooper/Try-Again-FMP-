using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ObjectGenerator : MonoBehaviour
{

    [SerializeField] GameObject prefab;
    [SerializeField] GameObject prefabR;

    [Header("Raycast Settings")]
    [SerializeField] int density;

    [Space]

    [SerializeField] float minHeight;
    [SerializeField] float maxHeight;
    [SerializeField] Vector2 xRange;
    [SerializeField] Vector2 zRange;

    [Space]

    [SerializeField] int densityR;

    [Space]

    [SerializeField] float minHeightR;
    [SerializeField] float maxHeightR;
    [SerializeField] Vector2 xRangeR;
    [SerializeField] Vector2 zRangeR;

    public bool autoUpdate;

    void Start()
    {
        //Generate();
    }

#if UNITY_EDITOR

    public void Generate()
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

        for (int i = 0; i < densityR; i++)
        {
            float sampleX = Random.Range(xRangeR.x, xRangeR.y);
            float sampleY = Random.Range(zRangeR.x, zRangeR.y);
            Vector3 rayStart = new Vector3(sampleX, maxHeightR, sampleY);

            if (!Physics.Raycast(rayStart, Vector3.down, out RaycastHit hit, Mathf.Infinity))
                continue;

            if (hit.point.y < minHeightR)
                continue;

            GameObject instantiatedPrefab = (GameObject)PrefabUtility.InstantiatePrefab(this.prefabR, transform);
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

