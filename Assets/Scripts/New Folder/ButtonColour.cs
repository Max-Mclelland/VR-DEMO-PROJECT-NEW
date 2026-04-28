using UnityEngine;

public class ButtonColour : MonoBehaviour
{
    BasketBallMakeShot basketBallMakeShot;
    
    public Renderer LeftBasketballButton;   // buttons renderers
    public Renderer RightBasketballButton;
    public Renderer LeftArcheryButton;
    public Renderer RightArcheryButton;
    public Renderer BowlingButton;
    public int ButtonCounter = 0;

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
                     if(LeftBasketballButton.sharedMaterial != GreenButton)
                        {
                            ButtonCounter++;
                        }

                LeftBasketballButton.sharedMaterial = GreenButton;
                }
            if(RightBasketballHoop == true)
                {
                    if(RightBasketballButton.sharedMaterial != GreenButton)
                        {
                            ButtonCounter++;
                        }

                    RightBasketballButton.sharedMaterial = GreenButton;
                }
            if(LeftArcheryTarget == true)
                {
                    if(LeftArcheryButton.sharedMaterial != GreenButton)
                        {
                            ButtonCounter++;
                        }
                        
                    LeftArcheryButton.sharedMaterial = GreenButton;
                }
            if(RightArcheryTarget == true)
                {
                    if(RightArcheryButton.sharedMaterial != GreenButton)
                        {
                            ButtonCounter++;
                        }

                    RightArcheryButton.sharedMaterial = GreenButton;
                }
            if(BowlingLane == true)
                {
                    if(BowlingButton.sharedMaterial != GreenButton)
                        {
                            ButtonCounter++;
                        }

                    BowlingButton.sharedMaterial = GreenButton;
                }
     }
}
