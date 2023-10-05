using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameInput : MonoBehaviour
{
    private PlayerInputActions playerInputActions;
    private Camera mainCamera;

    private void Awake()
    {
        playerInputActions = new PlayerInputActions();
        mainCamera = Camera.main;
        
    }

    private void OnEnable()
    {
        playerInputActions.Enable();
    }

    private void OnDisable()
    {
        playerInputActions.Disable();
    }

    private void Start()
    {
        playerInputActions.Player.Click.performed += _ => EndedCLick();
    }
    private void EndedCLick()
    {
        DetectAndDestroyFlyingTarget();
    }

    private void DetectAndDestroyFlyingTarget()
    {
        Ray ray = mainCamera.ScreenPointToRay(playerInputActions.Player.Position.ReadValue<Vector2>());
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit))
        {
            if (hit.collider)
            {
                if (hit.collider.GetComponent<DestroyingObject>())
                {
                    Destroy(hit.collider.gameObject);

                    if (hit.collider.GetComponent<IncrementingValue>())
                    {
                        hit.collider.GetComponent<IncrementingValue>().IncrementValue();
                    }
                    else if (hit.collider.GetComponent<DealingPlayerDamage>())
                    {
                        hit.collider.GetComponent<DealingPlayerDamage>().DealPlayerDamage();
                    }
                }

            }

        }
    }
}
