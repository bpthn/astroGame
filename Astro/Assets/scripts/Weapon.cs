using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public int damage = 40;
    public GameObject impactEffect;
    public LineRenderer lineRenderer;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("Shooting");
            //StartCoroutine(Shoot());
            Shoot();
        }
    }

    IEnumerator Shoot()
    {
        //Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        RaycastHit2D hitInfo = Physics2D.Raycast(firePoint.position, firePoint.right);

        if (hitInfo)
        {
            enemy enemy = hitInfo.transform.GetComponent<enemy>();
            if (enemy != null)
            {
                enemy.TakeDamage(damage);
            }

            Instantiate(bulletPrefab, hitInfo.point, Quaternion.identity);

            lineRenderer.SetPosition(0, firePoint.position);
            lineRenderer.SetPosition(1, hitInfo.point);

        }
        else
        {
            lineRenderer.SetPosition(0, firePoint.position);
            lineRenderer.SetPosition(1, firePoint.position + firePoint.right * 100);
        }

        lineRenderer.enabled = true;

        yield return new WaitForSeconds(0.02f);

        lineRenderer.enabled = false;
    }
}
