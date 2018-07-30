using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour {
    public GameObject[] tilePrefabs;

    private Transform playerTransform;
    private float spawnZlocation = 0.0f;
    private float tileLength = 5.0f;
    private int tilesVisible = 7;

    private void Start()
    {
        playerTransform = GameObject.Find("Player").transform;

        SpawnTile();
        SpawnTile();
        SpawnTile();
    }

    private void SpawnTile()
    {
        GameObject go;
        go = Instantiate(tilePrefabs[0]) as GameObject;
        go.transform.SetParent(transform); // Make tilemanager the parent of new tiles
        // spawn new tile at spawnlocation
        go.transform.position = Vector3.forward * spawnZlocation;
        // set new spawn location
        spawnZlocation += tileLength;
    }

}
