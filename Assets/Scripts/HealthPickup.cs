using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{

    public int healthAmount = 50;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player") {
            if(PlayerController.instance.currentHealth < 100) {
            PlayerController.instance.AddHealth(healthAmount);            
            Destroy(gameObject);
            }
        }
    }
}
