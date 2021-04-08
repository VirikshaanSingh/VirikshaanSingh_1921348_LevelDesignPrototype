using System.Collections;
using UnityEngine;

public class WeakWall : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            StartCoroutine(BreakWall());
        }
    }

    IEnumerator BreakWall()
    {
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }
}
