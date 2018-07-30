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
    }

}
