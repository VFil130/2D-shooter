using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody2D phys;

    public Transform player;

    public float speedx;
    public float speedy;
    public float agroDistance;
    void Start()
    {
        phys = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float distToPlayer = Vector2.Distance(transform.position, player.position); // подсчёт растояния до игрока
        if(distToPlayer < agroDistance)
        {
            Hunt();
        }
        else
        {
            StopHunt();
        }
    }
    void Hunt()
    {
        if(player.position.x < transform.position.x) //идёт влево
        {
            phys.velocity = new Vector2(-speedx, -speedy);
            transform.localScale=new Vector2(4,4);
        }
        else if (player.position.x > transform.position.x)// идёт впрво
        {
            phys.velocity = new Vector2(speedx, speedy);
            transform.localScale =new Vector2(-4, 4);
        }
    }
    void StopHunt() //прекращает преследование персонажа
    {
        phys.velocity = new Vector2(0,0);
    }
}
