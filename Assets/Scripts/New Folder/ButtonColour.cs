using UnityEngine;

public class ButtonColour : MonoBehaviour
{
    BasketBallMakeShot basketBallMakeShot;
    
    public Renderer LeftBasketballButton;   // buttons renderers
    public Renderer RightBasketballButton;
    public Renderer LeftArcheryButton;
    public Renderer RightArcheryButton;
    public Renderer BowlingButton;

    public bool LeftBasketballHoop;     
    public bool RightBasketballHoop;
    public bool LeftArcheryTarget;
    public bool RightArcheryTarget;
    public bool BowlingLane;


    public Material RedButton; 
    public Material GreenButton; 

     public void ChangeColour()
     {
            if(LeftBasketballHoop == true)
                {
                    LeftBasketballButton.sharedMaterial = GreenButton;
                }
            if(RightBasketballHoop == true)
                {
                    RightBasketballButton.sharedMaterial = GreenButton;
                }
            if(LeftArcheryTarget == true)
                {
                    LeftArcheryButton.sharedMaterial = GreenButton;
                }
            if(RightArcheryTarget == true)
                {
                    RightArcheryButton.sharedMaterial = GreenButton;
                }
            if(BowlingLane == true)
                {
                    BowlingButton.sharedMaterial = GreenButton;
                }
     }
}
