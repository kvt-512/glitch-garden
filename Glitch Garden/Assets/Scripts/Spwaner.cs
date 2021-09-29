using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spwaner : MonoBehaviour
{
    bool spwan = true;
    float rangeMin = 1F;
    float rangeMax = 10F;
    [SerializeField] Attacker attackerPrefab;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (spwan)
        {
            yield return new WaitForSeconds(Random.Range(rangeMin, rangeMax));
            SpwanAttacker();
        }
    }

    private void SpwanAttacker()
    {
        Instantiate(attackerPrefab, this.transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
