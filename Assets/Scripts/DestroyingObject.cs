using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyingObject : MonoBehaviour
{
    [SerializeField] private GameObject heroHealthObject;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Border>())
        {
            Destroy(gameObject);
            heroHealthObject.GetComponent<HealthPoints>().TakeDamage(5);
        }
    }
}
