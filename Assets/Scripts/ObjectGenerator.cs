using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ObjectGenerator : MonoBehaviour
{
    public GameObject treePrefab;
    public GameObject rockPrefab;

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

    }

    public void Generate()
    {
        Clear();

        for (int i = 0; i < densityR; i++)
        {
            float sampleX = Random.Range(xRangeR.x, xRangeR.y);
            float sampleY = Random.Range(zRangeR.x, zRangeR.y);
            Vector3 rayStart = new Vector3(sampleX, maxHeightR, sampleY);

            if (!Physics.Raycast(rayStart, Vector3.down, out RaycastHit hit, Mathf.Infinity))
                continue;

            if (hit.point.y < minHeightR)
                continue;

            Quaternion spawnRotation = Quaternion.FromToRotation(Vector3.up, hit.normal);

            GameObject clone = Instantiate(rockPrefab, hit.point, spawnRotation);

            clone.transform.parent = gameObject.transform;
        }
    

        for (int i = 0; i < density; i++)
        {
            float sampleX = Random.Range(xRange.x, xRange.y);
            float sampleY = Random.Range(zRange.x, zRange.y);
            Vector3 rayStart = new Vector3(sampleX, maxHeight, sampleY);

            if (!Physics.Raycast(rayStart, Vector3.down, out RaycastHit hit, Mathf.Infinity))
                continue;

            if (hit.point.y < minHeight)
                continue;

            Quaternion spawnRotation = Quaternion.FromToRotation(Vector3.up, Vector3.up);

            GameObject clone = Instantiate(treePrefab, hit.point, spawnRotation);

            clone.transform.parent = gameObject.transform;
        }

    }  

    public void Clear()
    {
        while (transform.childCount != 0)
        {
            DestroyImmediate(transform.GetChild(0).gameObject);
        }
    }
}

