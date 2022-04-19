using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    public int mapWidth;
    public int mapHeight;
    public float noiseScale;

    public void GenerateMap() 
    {
        float[,] noiseMap = Noise.GenerateNoiseMap (mapWidth, mapHeight, noiseScale);

        MapDisplay display = FindObjectOfType<MapDisplay> ();
        display.DrawNoiseMap (noiseMap);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
