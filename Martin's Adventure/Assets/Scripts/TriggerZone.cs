using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZone : MonoBehaviour
{
    private Archer archer;
    // Start is called before the first frame update
    void Start()
    {
        archer = this.gameObject.GetComponentInChildren<Archer>();
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.CompareTag("Player"))
        {
            archer.enterZone = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if(collider.CompareTag("Player"))
        {
            archer.enterZone = false;
        }
    }
}
