using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    
    public GameObject enemyPrefab;
    public float timeSpawn = 4f;
    public float spawn = 4f;
    private float timer;
    private GameObject KillObj;
    private Kill KillComp;

    private void Start()
    {
        KillObj = GameObject.FindGameObjectWithTag("KillC");
        KillComp = KillObj.GetComponent<Kill>();
        timer = spawn;
    }

    private void Update()
    {
        if (KillObj != null && KillComp.DiffUp())
        {
            spawn /= 2f;
            KillObj = null; 
        }
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            timer = spawn;
            Instantiate(enemyPrefab, new Vector2(-9f, Random.Range(-3.5f, 3.5f)), Quaternion.identity);
                //enemyPrefab.transform.parent = null;
                //enemyPrefab.transform.position = new Vector2(12f, Random.Range(-3.5f, 3.5f));
        }
    }
}
