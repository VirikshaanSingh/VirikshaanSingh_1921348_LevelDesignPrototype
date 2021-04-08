using UnityEngine;
using UnityEngine.UI;

public class PickUpCounter : MonoBehaviour
{
    public Text pickupText;
    public int keysCollected;

    void Update()
    {
        pickupText.text = keysCollected.ToString();
    }
}
