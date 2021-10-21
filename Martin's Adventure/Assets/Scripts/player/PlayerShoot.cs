using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
   public GameObject bullet;
    private Vector2 bulletPos;
    public float fireRate = 1f;
    float nextFire = 0f;
    public SpriteRenderer spritePlayer;
    public Bullet boule;
    
    

    public static PlayerShoot instance;

    private void Awake()
    {
        if(instance != null)
        {
            
            return;
        }
        instance = this;

        
    }
   private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Fire();

        } 
    }

    private void Fire()
    {
        bulletPos = transform.position;
        if (spritePlayer.flipX == false)
        {
            bulletPos += new Vector2(+1.3f, 0f);
            boule.velX = +boule.velX;
            Instantiate(bullet, bulletPos, Quaternion.identity);
        }else if(spritePlayer.flipX == true)
        {
            bulletPos += new Vector2 (-1.3f, 0f);
            boule.velX = -boule.velX;
            Instantiate (bullet, bulletPos, Quaternion.identity);
        }
    }
}
