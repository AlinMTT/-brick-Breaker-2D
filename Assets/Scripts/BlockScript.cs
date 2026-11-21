using Unity.AppUI.UI;
using UnityEngine;

public class BlockScript : MonoBehaviour
{
    public int healthPoints;
    public GameObject blocText;
    void Start()
    {
        healthPoints = Random.Range(1,30);
    }
    void Update()
    {
        blocText.GetComponent<Text>().text  = healthPoints.ToString();
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            healthPoints--;
        }
        if(healthPoints <1)
        {
            Destroy(gameObject);
        }
    }
}
