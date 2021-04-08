using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            StartCoroutine(CombatTransition());
            Time.timeScale = 0;
        }
    }

    IEnumerator CombatTransition()
    {
        SceneManager.LoadScene(1);
        yield return new WaitForSeconds(5f);
    }
}
