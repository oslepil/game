using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Kill : MonoBehaviour
{
    public int kills = 0;
    public Text text;
    public GameObject Enemy;
    private DeathEnemy EnemyComp;

    void Start()
    {
        EnemyComp = Enemy.GetComponent<DeathEnemy>();
        text.text = "Kills: " + kills.ToString();
    }

    public void Killcount()
    {
        kills += 1;
        text.text = "Kills: " + kills.ToString();
    }
    public bool DiffUp()
    {
        if (kills % 50 == 0 && kills != 0)
        {
            return true;
        }
        else { return false; }
    }
    public void HpUp()
    {
        if (kills % 10 == 0 && kills != 0)
        {
            EnemyComp.hp += 2;
        }
    }
}
