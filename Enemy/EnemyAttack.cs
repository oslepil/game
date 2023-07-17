using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    GameObject WallsObject;
    Walls WallsComponent;
    public Animator anime;
    public int PlayerHp = 10;
    public int EnemyDamage = 1;
    public float AttackSpeed = 1f;
    private float t = 0f;
    // Start is called before the first frame update
    void Start()
    {
        WallsObject = GameObject.FindGameObjectWithTag("Wall");
        if (WallsObject != null)
        {
            WallsComponent = WallsObject.GetComponent<Walls>();
        }
        anime = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((transform.position.x >= 6) && (WallsComponent != null)) 
        {
            anime.SetBool("Attack", true);

            t += Time.deltaTime;
            if (t >= AttackSpeed)
            {
                t = 0f;
                Damager();

            }
        }
        else
        {
            anime.SetBool("Attack" , false);
        }

    }

    void Damager()
    {
        if (WallsComponent != null && WallsComponent.Daaaaamn())
        {
            WallsComponent.TakeDam(EnemyDamage);
        }
        else
        {
            anime.SetBool("Attack", false);
        }
    }
}
