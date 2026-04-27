using UnityEngine;

public class BowlingKnockDownPins : MonoBehaviour
{
    public ButtonColour buttonColour;
    public Renderer ButtonRenderer;
    private int counter = 0;
    void OnTriggerExit(Collider collision)
    {
        ButtonRenderer = collision.GetComponent<Renderer>();


        if(counter == 10)
        {
        buttonColour.LeftBasketballHoop = false;
        buttonColour.RightBasketballHoop = false;
        buttonColour.LeftArcheryTarget = false;
        buttonColour.RightArcheryTarget = false;
        buttonColour.BowlingLane = true;
        
        buttonColour.ChangeColour();

        }

        if(collision.CompareTag("bowlingPin")) // used tags and called this ball so i could not only have this be triggered by basketballs but any object with the tag ball.
            {
                counter--;
            }
    }


}
