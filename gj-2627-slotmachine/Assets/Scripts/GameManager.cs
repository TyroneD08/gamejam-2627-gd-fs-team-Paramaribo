using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("Player 1 rolled");
        }

        if(Input.GetKeyDown(KeyCode.R)) 
        {
            Debug.Log("Player 2 rolled");
        }
    }
}
