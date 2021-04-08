using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject dialogueBox;
    public GameObject portal;
    public int goal;
    public PickUpCounter pickUpCounter;

    void Start()
    {
        dialogueBox.SetActive(false);
        portal.SetActive(false);
    }

    void Update()
    {
        if (pickUpCounter.keysCollected >= goal)
        {
            portal.SetActive(true);
        }
    }
}
