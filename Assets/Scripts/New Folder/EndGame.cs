using UnityEngine;

public class EndGame : MonoBehaviour
{
    
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == ("ExitTag"))
        {
            Application.Quit();
        }
    }


}
