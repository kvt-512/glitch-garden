using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    [SerializeField] [Range(0,1)] float speed = 0.01F;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       this.transform.position = new Vector3(
           this.transform.position.x - speed,
           this.transform.position.y,
           this.transform.position.z
           );
    }
}
