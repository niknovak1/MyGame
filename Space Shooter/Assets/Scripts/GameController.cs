using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public GameObject hazard;
    public Vector3 spawnValue;
    public int hazardcount;
    public float spawnWait;
    public float startWait;
    public float wavewait;

    void Start()
    {
        StartCoroutine(SpawnWaves());
    }

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);
        while(true){
            for (int i = 0; i < hazardcount; i++)
            {
                Vector3 spawnpossition = new Vector3(UnityEngine.Random.Range(-spawnValue.x, spawnValue.x), spawnValue.y, spawnValue.z);
                Quaternion spawnrotation = Quaternion.identity;
                Instantiate(hazard, spawnpossition, spawnrotation);
                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds(wavewait);
        }
        
    }
}
