using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spanwn : MonoBehaviour
{
    [SerializeField] GameObject[] weaponprefab;
    [SerializeField] float secondSpawn = 0.5f;
    [SerializeField] float minTras;
    [SerializeField] float maxTras;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(weaponSpawn());
    }

    // Update is called once per frame
    IEnumerator weaponSpawn()
    {
        while (true)
        {
            var wanted = Random.Range(minTras, maxTras);
            var position = new Vector3(wanted, transform.position.y);
            GameObject gameObject = Instantiate(weaponprefab[Random.Range(0, weaponprefab.Length)]
            , position, Quaternion.identity);
            yield return new WaitForSeconds(secondSpawn);
            Destroy(gameObject, 5f);
        }

    }
}
