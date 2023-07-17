using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Sprite sprite1;
    public float timeDestroy = 3f;
    public float speed = 3f;
    public int damage = 1;
    public Rigidbody2D rb;
    private SpriteRenderer sr;
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();

        Destroy(this.gameObject, timeDestroy);
        rb.velocity = -transform.right * speed;
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        DeathEnemy en = hitInfo.GetComponent<DeathEnemy>();
        if (en != null)
        {
            en.TakeDamage(damage);
            Hit();
        }

    }

    void Hit()
    {
        rb.velocity = -transform.right * speed + transform.right * speed;
        sr.sprite = sprite1;
        Destroy(this.gameObject, 0.1f);
    }

}
