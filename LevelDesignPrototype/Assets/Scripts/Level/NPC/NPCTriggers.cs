using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCTriggers : MonoBehaviour
{
    public NPC npc;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            npc.TriggerDialogue();
        }
    }
}
