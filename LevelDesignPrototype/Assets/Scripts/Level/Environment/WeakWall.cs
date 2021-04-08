using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeakWall : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            StartCoroutine(BreakWall());
        }
    }

    IEnumerator BreakWall()
    {
        Destroy(gameObject);
        yield return new WaitForSeconds(2f); 
    }
}
