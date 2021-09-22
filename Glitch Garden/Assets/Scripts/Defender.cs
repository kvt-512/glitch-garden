using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    [SerializeField] GameObject zucchini;
    [SerializeField] Transform firePoint;
    [SerializeField] float projetileSpeed;
    private void Shoot() {
        GameObject zucchiniGameObject = Instantiate(zucchini, firePoint.position, Quaternion.identity);
        Rigidbody2D rb = zucchiniGameObject.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.right * projetileSpeed, ForceMode2D.Impulse);
    }
}
