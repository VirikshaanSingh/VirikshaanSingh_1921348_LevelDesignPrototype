using UnityEngine;

public class PickUp : MonoBehaviour
{
    public bool interactable;
    public PickUpCounter pickUpCounter;

    void Start()
    {
        interactable = false;
    }

    private void Update()
    {
        if (interactable && Input.GetKeyDown(KeyCode.Mouse0))
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

    public void PickUpObject()
    {
        pickUpCounter.keysCollected += 1;
        Destroy(gameObject);
    }
}
