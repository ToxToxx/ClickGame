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
        DetectObject();
    }

    private void DetectObject()
    {
        Ray ray = mainCamera.ScreenPointToRay(playerInputActions.Player.Position.ReadValue<Vector2>());
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit))
        {
            if (hit.collider != null)
            {
                Debug.Log(hit.collider.name);
                if (hit.collider.GetComponent<IncrementingValue>())
                {
                    Destroy(hit.collider.gameObject);
                }
            }
        }
    }
}
