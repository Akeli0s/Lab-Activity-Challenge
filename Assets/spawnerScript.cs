using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class spawnerScript : MonoBehaviour
{
    public GameObject[] platformPrefabs;
    public int scoreCount = 300;
    public float maxHeight = 100f;
    public float minDIstanceBetweenPlatforms = 1.0f;

    private List<Vector3> spawnedPosition = new List<Vector3>();


void Start()
{
    if (platformPrefabs.Length == 0)
        {
            Debug.LogWarning("No Platform Prefabs assigned.");
            return;
        }
        for (int i = 0; i < scoreCount; i++)
    }

   

}