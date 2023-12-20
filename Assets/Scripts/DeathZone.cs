using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    private float D = 1000;
    void OnTriggerEnter2D(Collider2D other)
    {
        other.GetComponent<PlayerStats>().TakeDmg(D);
    }
}
