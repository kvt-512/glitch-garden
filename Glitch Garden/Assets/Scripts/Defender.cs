using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    [SerializeField] GameObject zucchini;
    [SerializeField] Transform firePoint;
    [SerializeField] AudioClip projectileReleaseSFX;
    float projectileReleaseSFXVol = 10F;
    private void Shoot() {
        GameObject zucchiniGameObject = Instantiate(zucchini, firePoint.position, Quaternion.identity);
        TriggerProjectileReleaseSFX();
    }

    private void TriggerProjectileReleaseSFX() {
        AudioSource.PlayClipAtPoint(projectileReleaseSFX, Camera.main.transform.position, projectileReleaseSFXVol);
    }
}
