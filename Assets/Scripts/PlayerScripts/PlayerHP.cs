using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour
{
    public float hp = 10;
    public Text hpText;

    private void Start()
    {
        hpText.text = hp + "";
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("EnemyBullet"))
        {
            hp -= 1;
            hpText.text = hp + "";
            Destroy(other.gameObject);
        }
    }
}