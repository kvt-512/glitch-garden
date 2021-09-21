using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    [SerializeField] [Range(0F, 0.05F)] float currentSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       this.transform.Translate(Vector3.left * currentSpeed * Time.deltaTime);
    }

    private float SetMovementSpeed(float speed) {
        currentSpeed = speed;
        return currentSpeed;
    }
}
