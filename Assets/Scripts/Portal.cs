using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    public int loc;
    private void OnTriggerEnter2D(Collider2D other) // переход в другую сцену
    {
        if (other.name == "Player")
        {
            SceneManager.LoadScene(loc);
        }
    }
}
