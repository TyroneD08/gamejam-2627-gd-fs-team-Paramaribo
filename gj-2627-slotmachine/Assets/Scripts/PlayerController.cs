using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    InputAction P1Roll;
    InputAction P2Roll;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        P1Roll = InputSystem.actions.FindAction("P1Roll");
        P2Roll = InputSystem.actions.FindAction("P2Roll");
    }

    // Update is called once per frame
    void Update()
    {
        if (P1Roll.IsPressed())
        {
            Debug.Log("Player 1 rolled.");
        }
        
        if (P2Roll.IsPressed())
        {
            Debug.Log("Player 2 rolled.");
        }
    }
}
