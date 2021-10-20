using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : MonoBehaviour
{
    public float timeBtwShots;
    public float maxTimeBtwShots;

    public GameObject arrow;
    public bool enterZone;

    // Start is called before the first frame update
    private void Start()
    {
        timeBtwShots = maxTimeBtwShots;
    }

    // Update is called once per frame
    private void Update()
    {
        if(enterZone)
        {
            //trigger attack animation when time between shots reach 0
            if(timeBtwShots <= 0)
            {
                Shoot();
            }
            else
            {
                timeBtwShots -= Time.deltaTime;
            }
        }
    }

    public void Shoot()
    {
        //Spawn an arrow in the ennemy position, without rotation
        Instantiate(arrow, transform.position, Quaternion.identity);
        timeBtwShots = maxTimeBtwShots;
    }
}
