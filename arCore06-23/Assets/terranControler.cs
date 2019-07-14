using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class terranControler : MonoBehaviour
{
    private Terrain terrain;


    public Vector3 TerrainSize;

    void start()
    {
        terrain = GetComponent<Terrain>();
        terrain.terrainData.size = TerrainSize;

    }
}
