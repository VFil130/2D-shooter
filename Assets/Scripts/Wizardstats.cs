using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizardstats : MonoBehaviour
{
    private float interval = 2f;// интервал ударов
    private float timer = 0f; // переменная для отсчета времени
    private float HP = 10f;
    private float damage = 0.2f;
    private void OnTriggerEnter2D(Collider2D other) // скрипт взаимодействия объектов
    {
        if (other.name == "Player")
        {
            other.GetComponent<PlayerStats>().TakeDmg(damage);
        }
    }
    private void OnTriggerStay2D(Collider2D other) // скрипт взаимодействия объектов
    {

        if (other.name == "Player") // задержка удара
        {
            timer += Time.deltaTime;
            if(timer>=interval)
            {
                other.GetComponent<PlayerStats>().TakeDmg(damage);
                timer=0f;
            }
        }
    }
    public void TakeDamage(float amount) //уменьшение хп при получении урона
    {
        HP -= amount;
        if (HP <= 0f)
        {
            Die();
        }
    }
    void Die() //удаление объекта из сцены
    {
        Destroy(gameObject);
    }
}
