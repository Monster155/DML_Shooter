using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingController : MonoBehaviour
{
    public GameObject pBullet;
    public GameObject muzzle;
    public GameObject bulletsContainer;

    public float bulletSpeed = 10000;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject bullet = Instantiate(pBullet,
                muzzle.transform.position,
                muzzle.transform.rotation,
                bulletsContainer.transform);
            bullet.GetComponent<Rigidbody>().AddForce(bullet.transform.forward * bulletSpeed);
        }
    }
}