using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectorScript : MonoBehaviour
{
    public delegate void ScoreCount();
    public static event ScoreCount Score;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Bomb")
        {
            collision.gameObject.SetActive(false);

            if(Score != null)
            {
                Score();
            }
        }
    }
}
