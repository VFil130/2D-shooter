using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public Image bar;
    [SerializeField]
    private float HP = 1f;
    public void TakeDmg(float damage) // получение урона игроком
    {
        HP -= damage;
        if(HP <= 0f)
        {
            Die();
        }
    }
     void Update() // полоса хп
    {
        bar.fillAmount = HP;
    }
    private void Die()// запускает игру сначала
    {
        SceneManager.LoadScene(0);
    }
}
