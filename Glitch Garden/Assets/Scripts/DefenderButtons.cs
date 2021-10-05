using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderButtons : MonoBehaviour
{
    [SerializeField] bool isWhite = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown() {
        if(!isWhite) {
            this.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
            isWhite = true;
        }
        else if(isWhite) {
            this.GetComponent<SpriteRenderer>().color = new Color(0.3F, 0.3F, 0.3F, 1);
            isWhite = false;
        }
    }
}
