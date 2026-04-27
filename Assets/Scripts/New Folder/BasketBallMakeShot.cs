using UnityEngine;

public class BasketBallMakeShot : MonoBehaviour
{
    public ButtonColour buttonColour;

    public GameObject BasketballHoop;
    public Renderer ButtonRenderer;

    void OnTriggerEnter(Collider collision)
    {
        ButtonRenderer = collision.GetComponent<Renderer>();

        if(BasketballHoop.CompareTag ("left"))  //set which machine it is therefore which button
            {
                buttonColour.LeftBasketballHoop = true;
                buttonColour.RightBasketballHoop = false;
                buttonColour.LeftArcheryTarget = false;
                buttonColour.RightArcheryTarget = false;
                buttonColour.BowlingLane = false;
            }
        else
            {
                buttonColour.LeftBasketballHoop = false;
                buttonColour.RightBasketballHoop = true;
                buttonColour.LeftArcheryTarget = false;
                buttonColour.RightArcheryTarget = false;
                buttonColour.BowlingLane = false;
            }

        if(collision.CompareTag("ball")) // used tags and called this ball so i could not only have this be triggered by basketballs but any object with the tag ball.
            {
                Debug.Log("Ball Entered Basketball Collider");

                buttonColour.ChangeColour();
            }
    }


}
