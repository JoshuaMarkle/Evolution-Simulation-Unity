using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Master : MonoBehaviour {

    public static Master Instance;

    // Scripts
    [Header("Scripts")]
    public GenerateMap generateMapScript;
    public UI uiScript;

    // GameObjects
    [Header("GameObjects")]
    public GameObject cellPrefab;
    public GameObject foodPrefab;
    public GameObject wallPrefab;
    
    // Initial Map
    [Header("Initial Map")]
    public float worldSize = 100f;
    public int startingCells = 10;
    public int startingFood = 20;

    // World Information
    [Header("World Information")]
    public int cellCount = 0;
    public int foodCount = 0;
    public float foodGain = 0.5f;
    public float foodSpawnRate = 0.5f;
    public float mutationFrequency = 0.01f;

    // UI State
    [Header("UI State")]
    public bool globalView;
    public bool cellView;

    void Awake()
    {
        if (Instance != null && Instance != this) 
        {
            Destroy(gameObject);
            return;
        } else 
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}
