using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarTextDisplay : MonoBehaviour
{
    [SerializeField] int starCount = 100;
    Text starText;
    // Start is called before the first frame update
    void Start()
    {
        starText = GetComponent<Text>();
        UpdateDisplay();
    }

    // Update is called once per frame
    private void UpdateDisplay() {
        starText.text = starCount.ToString();
    }

    public void AddStars(int amount) {
        starCount += amount;
        UpdateDisplay();
    }

    public void SpendStars(int amount) {
        if(starCount !<= 0) {
            starCount -= amount;
            UpdateDisplay();
        }
    }
}
