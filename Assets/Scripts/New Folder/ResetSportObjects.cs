//======= Copyright (c) Valve Corporation, All rights reserved. ===============

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

namespace Valve.VR.InteractionSystem.Sample
{   
    public class TransformSnapshot
    {
    public Transform target;
    public Vector3 savedPosition;
    public Quaternion savedRotation;
    }
    
    public class ResetSportObjects : MonoBehaviour
    {
            //script for bascketball

        public Transform target;
        public List<TransformSnapshot> snapshots = new List<TransformSnapshot>();

        private int i = 0;

        void Awake() //get the children of the prefab stored as part of the array
        {
            foreach(Transform child in transform)
            {
                snapshots.Add(new TransformSnapshot
                {
                    target = child,
                    savedPosition = child.localPosition,
                    savedRotation = child.localRotation
                });
            }
        }

        public void resetObjects()
        {
            foreach(var snapshot in snapshots)
            {
                snapshot.target.localPosition = snapshot.savedPosition;
                snapshot.target.localRotation = snapshot.savedRotation;
            }
        }
    }
}