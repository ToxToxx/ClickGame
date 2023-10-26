using UnityEngine;

public class PauseUI : MonoBehaviour, IUserInterfaceWindow
{
    private void Start()
    {
        Hide();
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }

    public void Show()
    {
        gameObject.SetActive(true);
    }
}
