using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthColle : MonoBehaviour
{
     void OnTriggerEnter2D(Collider2D other)
    {
        MarshmellowController controller = other.GetComponent<MarshmellowController>();
        if (controller != null)
        {
            controller.ChangeHeaalth(1);
            Destroy(gameObject);
        }

    }
}
