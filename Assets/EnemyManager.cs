using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject Enemy;

    private GameObject spawnedEnemy;

    public float speed = 10f;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("spawn", 2f, 5f);
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    private void spawn()
    {
        Vector3 origin = Enemy.transform.position;
        SpawnEnemy(new Vector3(Random.Range(origin.x - 1, origin.x + 1), origin.y, origin.z));

    }

    private void SpawnEnemy(Vector3 position)
    {
        var enemy = GameObject.FindGameObjectWithTag("Orc").transform;
        spawnedEnemy = Instantiate(Enemy, position, enemy.rotation) as GameObject;
    }

    private void OnCollisionEnter(Collision colision)
    {
        if (colision.gameObject.tag == "Orc")
        {
            gameObject.GetComponent<Animation>().Play("Attack");
        }
    }


}