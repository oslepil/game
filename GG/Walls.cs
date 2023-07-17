using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Walls : MonoBehaviour
{
    public GameObject hpText;
    public int hp = 10;
    public GameObject Lose;
    public GameObject Enemy;
    private DeathEnemy EnemyComp;
    public GameObject Spawner;
    private SpawnEnemy SpawnC;

    void Start()
    {
        SpawnC = Spawner.GetComponent<SpawnEnemy>();
        EnemyComp = Enemy.GetComponent<DeathEnemy>();
    }

public void TakeDam(int damage)
    {
        hp -= damage;
    }

    void Update()
    {
        if (hp <= 0)
        {
            Destroy(this.gameObject);
            LooseWarning();
        }
        hpText.GetComponent<Text>().text = "Your HP:" + hp.ToString();
    }

    public bool Daaaaamn()
    {
        if (hp <= 0) { return false; }
        else { return true; }
    }


    void LooseWarning()
    {
        EnemyComp.hp = EnemyComp.StartHp;
        SpawnC.spawn = SpawnC.timeSpawn;
        Lose.SetActive(true);
        Time.timeScale = 0f;
    }
}
