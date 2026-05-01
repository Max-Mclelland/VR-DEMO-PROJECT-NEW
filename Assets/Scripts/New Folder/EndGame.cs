using UnityEngine;

public class EndGame : MonoBehaviour
{
    
    private void OnCollisionEnter(Collision collision)
    {
            Application.Quit();
           Debug.Log("Game Ended");
        
    }


}
