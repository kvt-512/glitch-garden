using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float startingHealth = 100F;
    [SerializeField] GameObject explosionVFX;
    [SerializeField] AudioClip explosionSFX;
    float destoryExplosionVFXDelay = 1F;
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
            TriggerExplosionVFX();
            Destroy(this.gameObject);
            TriggerExplosionSFX();
        } 
    }

    private void TriggerExplosionVFX() {
        GameObject explosionVFXGameObject =  Instantiate(explosionVFX, this.transform.position, Quaternion.identity) as GameObject;
        Destroy(explosionVFXGameObject, destoryExplosionVFXDelay);
    }

    private void TriggerExplosionSFX() {
        AudioSource.PlayClipAtPoint(explosionSFX, this.transform.position);
    }
}
