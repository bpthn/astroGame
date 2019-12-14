using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public int damage = 40;
    public GameObject impactEffect;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("Shooting");
            //StartCoroutine(Shoot());
            StartCoroutine(Shoot());
            //Shoot();
        }
    }

    public IEnumerator Shoot()
    {
        yield return new WaitForSeconds(0.4f);
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
       
    }
}
