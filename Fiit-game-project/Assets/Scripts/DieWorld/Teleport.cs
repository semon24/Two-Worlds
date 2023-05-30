using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleport : MonoBehaviour
{
    public string LoadScene;
    public GameObject Player; 
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == Player)
            SceneManager.LoadScene(LoadScene);
    }
}
