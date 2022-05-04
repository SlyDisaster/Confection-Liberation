using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployZombies : MonoBehaviour
{
    public GameObject [] zombiePrefab;
    public float respawnTime = 1.0f;
    public float YValue = 1f;
    

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(zombieWave());
        
    }
        

      // Update is called once per frame
    private void spawnEnemy() 
    {
        GameObject a = Instantiate(zombiePrefab[(Random.Range(0, zombiePrefab.Length))]) as GameObject;
        a.transform.position = new Vector3(Random.Range(-5.0f, 10.0f), YValue, Random.Range(-5.0f, 10.0f));
        Debug.Log("Spawn");
    }
    IEnumerator zombieWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
        }
    }
}
