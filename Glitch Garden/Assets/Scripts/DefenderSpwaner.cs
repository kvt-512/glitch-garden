using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpwaner : MonoBehaviour
{
    Vector3 mousePosition;
    Vector3 gridPosition;
    int mousePositionZ = 0;
    [SerializeField] Defender defender;
    private void OnMouseDown() {
        SpwanDefenders(MouseToGirdPosition(GetMousePosition()));
    }

    public void SetSelectDefender(Defender defenderToSelect) {
        defender = defenderToSelect;
    }

    private Vector3 GetMousePosition() {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = mousePositionZ;

        return mousePosition;
    }

    private Vector3 MouseToGirdPosition(Vector3 mousePosition) {
        gridPosition.x = Mathf.RoundToInt(mousePosition.x);
        gridPosition.y = Mathf.RoundToInt(mousePosition.y);
        gridPosition.z = Mathf.RoundToInt(mousePosition.z);

        return gridPosition;
    }

    private void SpwanDefenders(Vector3 gridPosition) {
        Defender defenderGameObject = Instantiate(defender, gridPosition, Quaternion.identity) as Defender;
    }
}
