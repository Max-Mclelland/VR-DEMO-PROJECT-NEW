//======= Copyright (c) Valve Corporation, All rights reserved. ===============

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;

namespace Valve.VR.InteractionSystem.Sample
{
    public class ButtonEffect : MonoBehaviour
    {
            //script for bascketball

        public GameObject ResetablePrefab;    // main gameobjects
        public GameObject secondResetablePrefab;

        public List<Transform> resetable = new List<Transform>();
        public List<Transform> resetable = new List<Transform>();

        private int i = 0;
        private int j = 0;


        Awake() //get the children of the prefab stored as part of the array
        {
            foreach(Transform child in ResetablePrefab)
            {
                resetable.Adds(child);
            }
        }


        public void OnButtonDown(Hand fromHand)
        {
                 foreach(Transform child in ResetablePrefab)
            {
                resetable[i] = ResetablePrefab.transform.GetChild(i);
            }


            if(secondResetablePrefab != null)
                {
                    foreach(Transform child in secondResetablePrefab)
                        {
                            secondResetable[j] = secondResetablePrefab.transform.GetChild(j);
                        }
                }
        }
        
    }
}