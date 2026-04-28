using UnityEngine;

public class DayEnd : MonoBehaviour
{
    public ButtonColour buttonColour;
    public GameObject SpotlightParent;
    public float ChangedIntensity;
    private Light childLight;
    public GameObject LegoGuyToActivate;

    void Update()
    {
        Debug.Log("Is this called? frfr" + buttonColour.ButtonCounter);
        if(buttonColour.ButtonCounter == 5)
        {
            Debug.Log("Is this called?");
            EndDay();
        }
    }
    void EndDay()
    {
        foreach(Transform child in transform)
            {
                Light childLight = child.GetComponent<Light>();
                childLight.intensity = ChangedIntensity;
                //Dim Lights Bar Front Desk and front door
            }

        LegoGuyToActivate.SetActive(true);

        //Canvas World SpaceIn Front of you

        //If Interact with Door Knob End Game prob other script i will just set a bool to true
    }
}
