using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.UI;



public class Playerstore : MonoBehaviour
{
    public GameObject score;
    public static int scoretext;

    public void Update()
    {
        score.GetComponent<Text>().text = "Score:" + scoretext;
    }

}
