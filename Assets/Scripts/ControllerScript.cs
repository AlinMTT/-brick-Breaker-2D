using System.Collections.Generic;
using UnityEngine;

public class ControllerScript : MonoBehaviour
{
    public GameObject blockPrefab;
    public List<GameObject> blocks;
    public GameManagerScript manager;
    Vector2 blockPos;
    int ammount =16;
    float xPos , screenX;
    void Start()
    {
        screenX = Vector2.Distance
        (
            Camera.main.ScreenToWorldPoint(new Vector2 (0,0)),
            Camera.main.ScreenToWorldPoint(new Vector2 (Screen.width,0))

        )*0.5f;
        SpawnBlocks();
    }
    public void SpawnBlocks()
    {
        xPos = (Camera.main.transform.position.x - screenX)+0.5f;
        blockPos = new Vector2(xPos,3f);
        blocks.Add(Instantiate(blockPrefab,blockPos, Quaternion.identity,transform));

        for(int i=0 ; i<ammount;i++)
        {
            xPos+=1f;
            if(Random.Range(1,100)>=30)
            {
                blockPos=new Vector3(xPos,3f);
                blocks.Add(Instantiate(blockPrefab,blockPos, Quaternion.identity,transform));

            }
        }
    }
    void Update()
    {
        
    }
}
