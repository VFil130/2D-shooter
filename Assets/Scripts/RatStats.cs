using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatStats : MonoBehaviour
{
    private float HP = 8f;
    private float damage = 0.2f;
    private void OnTriggerEnter2D(Collider2D other) // скрипт взаимодействия объектов
    {
        if(other.name == "Player")
        {
            other.GetComponent<PlayerStats>().TakeDmg(damage);
        }
    }
    public void TakeDamage(float amount) //уменьшение хп при получении урона
    {
        HP -= amount; 
        if(HP <= 0f)
        {
            Die();
        }
    }
    void Die() //удаление объекта из сцены
    {
        Destroy(gameObject);
    }
}
