using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float startingHealth = 100F;
    float noHealth = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DealDamage(float damage) {
        startingHealth = startingHealth - damage;
        if (startingHealth <= noHealth) {
            Destroy(this.gameObject);
        } 
    }
}
