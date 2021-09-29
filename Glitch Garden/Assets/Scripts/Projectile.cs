using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float damage;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Attacker") {
            other.GetComponent<Health>().DealDamage(damage);
            Destroy(this.gameObject);
        }
    }
}
