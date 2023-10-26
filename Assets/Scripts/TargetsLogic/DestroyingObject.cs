using UnityEngine;

public class DestroyingObject : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Border>())
        {
            Destroy(gameObject);    
        }
    }
}
