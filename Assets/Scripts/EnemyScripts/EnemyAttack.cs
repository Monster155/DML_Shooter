using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public GameObject eBullet;
    public GameObject muzzle;
    public GameObject bulletsContainer;

    public float shootingRate = 2;
    public float bulletSpeed = 1000;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Shoot", shootingRate, shootingRate);
    }

    private void Shoot()
    {
        GameObject bullet = Instantiate(eBullet,
            muzzle.transform.position,
            muzzle.transform.rotation,
            bulletsContainer.transform);
        bullet.GetComponent<Rigidbody>().AddForce(bullet.transform.forward * bulletSpeed);
    }
}