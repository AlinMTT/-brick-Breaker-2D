using System.Collections;
using System.Data.Common;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public int ammoAmmount = 50;
    public int currentAmmo=0;
    public float bulletSpeed=10f;
    Vector3 shootDirection;
    bool round =false;

    void Start()
    {
        round =true;
        currentAmmo = ammoAmmount;
    } 
    IEnumerator Shoot()
    {
        for( int i=1;i<=ammoAmmount; i++)
        {
            GameObject Bullet = Instantiate(bulletPrefab, transform.position 
            , Quaternion.identity, transform);
            Vector2 force = new Vector2(shootDirection.x,shootDirection.y).normalized * 3* bulletSpeed;
            Bullet.GetComponent<Rigidbody2D>().linearVelocity = force;
            yield return new WaitForSeconds(0.1f);
        }
    }

    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space) && round)
        {
            round =false;
            StartCoroutine(Shoot());
        }
        if(round)
        {
            Debug.DrawLine(shootDirection + transform.position , transform.position);
            shootDirection = Input.mousePosition;
            shootDirection.z =0;
            shootDirection = Camera.main.ScreenToWorldPoint(shootDirection);

            shootDirection -= transform.position;
        }
        if(transform.childCount <=0 && !round)
        {
            round =true;
            currentAmmo = ammoAmmount;
        }
    }

}
