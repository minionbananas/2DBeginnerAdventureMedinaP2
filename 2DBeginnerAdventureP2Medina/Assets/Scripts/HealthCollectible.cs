using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthColle : MonoBehaviour
{
    void OnTriggerStay2D(Collider2D other)
    {
        MarshmellowConsle controller = other.GetComponent<MarshmellowConsle>();
        if (controller != null)
        {
            if (controller.health < controller.maxHealth)
            {
                controller.ChangeHealth(1);
                Destroy(gameObject);
            }

        }

    }
}
