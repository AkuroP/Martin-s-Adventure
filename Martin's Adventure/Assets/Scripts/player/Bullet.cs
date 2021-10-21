using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float velX = 5f;
    private float velY = 0f;
    public Rigidbody2D rb;
    public static Bullet instance;
    public CircleCollider2D bulletCollider;
    public int damageToGive = 1;
    public SpriteRenderer spritePlayer;

    private void Awake(){
        if(instance != null)
        {
            return;
        }

        instance = this;
    }
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        bulletCollider = GetComponent<CircleCollider2D>();
        spritePlayer = GameObject.FindGameObjectWithTag("Player").GetComponent<SpriteRenderer>();
    }

   
    private void Update()
    {
        
        rb.velocity = new Vector2 (velX, velY);
        Destroy(gameObject, 3f); //detruit l'objet au bout de 3s

    }

    public void Destroy(){
        
        //bloquer les movement de bull
        velX = 0f;
        bulletCollider.enabled = false;
    }
}
