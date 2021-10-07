using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderButtons : MonoBehaviour
{
    [SerializeField] Defender deferderPrefab;
    private void OnMouseDown() {
        var buttons = FindObjectsOfType<DefenderButtons>();
        foreach(DefenderButtons button in buttons) {
            button.GetComponent<SpriteRenderer>().color = new Color(0.3F, 0.3F, 0.3F, 1);
        }

        GetComponent<SpriteRenderer>().color = Color.white;
        FindObjectOfType<DefenderSpwaner>().SetSelectDefender(deferderPrefab);
    }
}
