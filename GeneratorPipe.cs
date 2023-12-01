using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorPipe : MonoBehaviour
{
    [SerializeField] float mfRateSpawn = 1f;
    [SerializeField] GameObject mPipePrefab;
    [SerializeField] Transform mSpawnPipeLocation;
    [SerializeField] float mfHeight = 2.5f;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPipe", mfRateSpawn, mfRateSpawn);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnPipe()
    {
      

        Vector2 lvLocation = mSpawnPipeLocation.position;
        float lfRandomHight = Random.Range(-mfHeight, mfHeight);

        lvLocation.y += lfRandomHight;


        Instantiate(mPipePrefab, lvLocation, Quaternion.identity);
    }

}
