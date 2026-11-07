using UnityEngine;

public class BulletScript : MonoBehaviour
{
    private int bounces=0;

    void Update()
    {
        if(transform.position.y <= -5)
        {
            Destroy(gameObject);
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag != "Block")
        {
            bounces++;
            if(bounces>=9)
            {
                Destroy(gameObject);
            }
        }
    }
}
