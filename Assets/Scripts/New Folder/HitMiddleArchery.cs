using UnityEngine;

public class HitMiddleArchery : MonoBehaviour
{

 public ButtonColour buttonColour;

    public GameObject ArcheryCentre;
    public Renderer ButtonRenderer;

    void OnTriggerEnter(Collider collision)
    {
        ButtonRenderer = collision.GetComponent<Renderer>();

        if(ArcheryCentre.CompareTag ("left"))  //set which machine it is therefore which button
            {
                buttonColour.LeftBasketballHoop = false;
                buttonColour.RightBasketballHoop = false;
                buttonColour.LeftArcheryTarget = true;
                buttonColour.RightArcheryTarget = false;
                buttonColour.BowlingLane = false;
            }
        else
            {
                buttonColour.LeftBasketballHoop = false;
                buttonColour.RightBasketballHoop = false;
                buttonColour.LeftArcheryTarget = false;
                buttonColour.RightArcheryTarget = true;
                buttonColour.BowlingLane = false;
            }
                buttonColour.ChangeColour();
    }


}
