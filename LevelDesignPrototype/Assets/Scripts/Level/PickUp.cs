using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUp : MonoBehaviour
{
    public Text circleCounter;
    public int circlesCollected;
    public bool interactable;

    void Start()
    {
        interactable = false;
        circlesCollected = 0;
        circleCounter.text = ": " + circlesCollected.ToString();
    }

    void Update()
    {
        if (interactable && Input.GetKeyDown(KeyCode.E))
        {
            PickUpObject();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            interactable = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            interactable = false;
        }
    }

    private void PickUpObject()
    {
        Destroy(gameObject);
        circlesCollected += 1;
        circleCounter.text = ": " + circlesCollected.ToString();
    }
}
