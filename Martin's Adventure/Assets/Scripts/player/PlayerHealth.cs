using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int playerLife = 1;
    
    public static PlayerHealth instance;
    public CapsuleCollider2D capsuleCollider;
    public SpriteRenderer spriteRenderer;
    public Rigidbody2D rb;



    private void Awake(){
        if(instance != null)
        {
            Debug.LogWarning("Il y a plus d'une instance de PlayerHealth dans la scène");
            return;
        }

        instance = this;
        
    }
    void Start()
    {
        capsuleCollider = GetComponent<CapsuleCollider2D>();
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.K))
       {
        TakeDamage(6);
        
       }

    }

    
    public void TakeDamage(int damage){
        playerLife -=damage;
        
 
        if(playerLife <= 0) 
        {
            Die();
            return;
        }
    }

    public void Die(){
        
        Debug.Log("Mort");
        playerController.instance.enabled = false;
        spriteRenderer.enabled = false;
        rb.isKinematic = true;
        rb.velocity = new Vector2(0,0);
        capsuleCollider.enabled = false;
        
    }
    public void Respawn()
    {
        
        playerLife = 1;
        
    }
}
