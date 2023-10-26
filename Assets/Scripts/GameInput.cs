using UnityEngine;

public class GameInput : MonoBehaviour
{
    private PlayerInputActions _playerInputActions;
    private Camera _mainCamera;

    private void Awake()
    {
        _playerInputActions = new PlayerInputActions();
        _mainCamera = Camera.main;
        
    }

    private void OnEnable()
    {
        _playerInputActions.Enable();
    }

    private void OnDisable()
    {
        _playerInputActions.Disable();
    }

    private void Start()
    {
        _playerInputActions.Player.Click.performed += _ => EndedCLick();
    }
    private void EndedCLick()
    {
        DetectAndDestroyFlyingTarget();
    }

    private void DetectAndDestroyFlyingTarget()
    {
        Ray ray = _mainCamera.ScreenPointToRay(_playerInputActions.Player.Position.ReadValue<Vector2>());
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider && hit.collider.GetComponent<DestroyingObject>())
            {
                Destroy(hit.collider.gameObject);

                if (hit.collider.GetComponent<IncrementingPlayerDamage>())
                {
                    hit.collider.GetComponent<IncrementingPlayerDamage>().IncrementValue();
                }
                else if (hit.collider.GetComponent<DealingPlayerDamage>())
                {
                    hit.collider.GetComponent<DealingPlayerDamage>().DealPlayerDamage();
                }
            }

        }
    }
}

