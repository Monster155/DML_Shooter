using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    public float hp = 100;
    public TextMesh textMesh;

    private void Start()
    {
        textMesh.text = hp + "";
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            hp -= 10;
            textMesh.text = hp + "";
            Destroy(other.gameObject);
        }
    }
}