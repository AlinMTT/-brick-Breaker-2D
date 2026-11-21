using TMPro;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public int point;
    public int tempPoint;

    void Update()
    {
        GetComponent<TMP_Text>().text = "Scor : " + point;
    }
}
