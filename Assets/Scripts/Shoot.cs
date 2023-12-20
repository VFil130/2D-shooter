using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public float speed = 100;
    private float damage = 0.5f;

    private Rigidbody2D phys;

    public Playercontroller isRotated;
    private void Start()
    {
        phys = GetComponent<Rigidbody2D>(); 
        isRotated = GameObject.FindGameObjectWithTag("Player").GetComponent<Playercontroller>();// скрипт для стрельбы вправо, влево
        if (isRotated.isLeft)
        {
            GetComponent<SpriteRenderer>().flipX = true;
            phys.AddForce(new Vector2(-speed, 0));
        }
        else if (isRotated.isLeft == false)
        {
            GetComponent<SpriteRenderer>().flipX = false;
            phys.AddForce(new Vector2(speed, 0));
        }
        Destroy(gameObject, 2f); // уничтожение объекта
    }
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.name == "Rat")
        {
            other.GetComponent<RatStats>().TakeDamage(damage);
        }
        if (other.name == "Tilemap")
        {
            Destroy(gameObject);
        }
        if (other.name == "wizard")
        {
            other.GetComponent<Wizardstats>().TakeDamage(damage);
        }
    }
}
