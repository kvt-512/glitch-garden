using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    [SerializeField] GameObject zucchini;
    [SerializeField] Transform firePoint;
    private void Shoot() {
        GameObject zucchiniGameObject = Instantiate(zucchini, firePoint.position, Quaternion.identity);
    }
}
