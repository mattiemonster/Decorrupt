using UnityEngine;

public class DebugExitKey : MonoBehaviour
{
    public KeyCode exitKey = KeyCode.Escape;

    void Start()
    {
        Debug.Log("Debug exit key enabled!");
    }

    void Update()
    {
        if (Input.GetKeyDown(exitKey))
        {
            Debug.Log("Debug exit key pressed, quitting.");
            Application.Quit();
        }
    }
}
