using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartikelSpawn : MonoBehaviour
{
    public GameObject partikel;
    private Vector2 screenBounds;
    public float spawnTime = 0.3f;


    private void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height,
                       Camera.main.transform.position.z));
        StartCoroutine(spawning());
    }

    private void spawnEnemy()
    {
        GameObject cloneEnemy = Instantiate(partikel) as GameObject;
        cloneEnemy.transform.position = new Vector2(Random.Range(screenBounds.x, -10), screenBounds.y);
        cloneEnemy.transform.eulerAngles = Vector3.forward * 70;
    }

    IEnumerator spawning()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnTime);
            spawnEnemy();

        }
    }
}
