using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathEnemy : MonoBehaviour
{
    public int StartHp = 5;
    public int hp;
    public Animator anime;
    private Rigidbody2D rb;
    private Vector2 stay ;
    private GameObject Score;
    private ScoreCounter sc;
    private GameObject KillObj;
    private Kill KillComp;
    private int counter = 0;

    void Start()
    {
        Score = GameObject.FindGameObjectWithTag("Canvas");
        KillObj = GameObject.FindGameObjectWithTag("KillC");
        KillComp = KillObj.GetComponent<Kill>();
        stay.x = 0f;
        stay.y = 0f;
        rb = GetComponent<Rigidbody2D>();
        anime = GetComponent<Animator>();
        sc = Score.GetComponent<ScoreCounter>();
    }

    void Update()
    {
        if (KillComp != null&& counter == 0)
        {
            KillComp.HpUp();
            counter++;  
        }
    }

    public void TakeDamage(int damage)
    {
        hp -= damage;

        if (hp <= 0) {
            anime.SetBool("Death", true);
            rb.velocity = stay ;
            Dead();
                }

    }
    void Dead()
    {
        if (sc != null)
        {
            sc.GetScore();
            sc = null;
        }
        if (KillComp != null)
        {
            KillComp.Killcount();
            KillComp = null;
        }
        counter = 0;    

        Destroy(this.gameObject,1f);
    }
}
