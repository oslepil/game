using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Animator anime;
    private Rigidbody2D rb;
    public float speed = 0.5f;
    private Vector2 moveVector;
    private float maxY, minY;
    public GameObject Pistol;

    void Start()
    {
        minY = Camera.main.ScreenToWorldPoint(new Vector2(0f, 0f)).y + 1.5f;
        maxY = -minY;
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (transform.position.y > maxY) transform.position = new Vector2(transform.position.x, maxY);
        else if (transform.position.y < minY) transform.position = new Vector2(transform.position.x, minY);
        moveVector.y = Input.GetAxis("Vertical");
        rb.MovePosition(rb.position + moveVector * speed * Time.deltaTime);
        if (moveVector.y != 0)
        {
            Pistol.SetActive(false);
            anime.SetBool("stop", false);
        }
        else
        {
            Pistol.SetActive(true);
            
            anime.SetBool("stop", true);
        }
        
    }
}
