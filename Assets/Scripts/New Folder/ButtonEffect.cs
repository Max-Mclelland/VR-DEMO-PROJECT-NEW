//======= Copyright (c) Valve Corporation, All rights reserved. ===============

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;

namespace Valve.VR.InteractionSystem.Sample
{
    public class ButtonEffect : MonoBehaviour
    {

        private Renderer Button; 
        public GameObject ResetablePrefab;
        private GameObject currentPrefab;
        public ButtonColour buttonColour;

    void Start()
        {
            Button = GetComponent<Renderer>();
            currentPrefab = Instantiate(ResetablePrefab);
                Debug.Log("ResetablePrefab is: " + ResetablePrefab);  // is it null?
    Debug.Log("currentPrefab is: " + currentPrefab); 
        }


        public void OnButtonEngage(Hand fromHand)
        {
                Debug.Log("Button pressed");                          // is this being called?
    Debug.Log("currentPrefab is: " + currentPrefab);
            ResetComponents();
            fromHand.TriggerHapticPulse(1000);
        }

        void ResetComponents()
        {
                Debug.Log("Destroying: " + currentPrefab);
            Destroy(currentPrefab);
                currentPrefab = Instantiate(ResetablePrefab);   
            Instantiate(ResetablePrefab);
        }
        
        
    }
}