using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int damage = 5;
    public float speed = 1.5f;

    public EnemyData data;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        SetEnemyValues();
    }

    // Update is called once per frame
    void Update()
    {
        Swarm();
    }
    private void Swarm()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position,speed * Time.deltaTime);
    }
    private void SetEnemyValues()
    {
        GetComponent<Health>().SetHealth(data.hp, data.hp);

    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.CompareTag("Player"))
        {
            if(collider.GetComponent<Balloon>() != null)
            {
                collider.GetComponent<health>().Damage(damage);
                this.GetComponent<health>().Damage(10000);
            }
        }
    }
}
