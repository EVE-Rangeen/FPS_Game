/* 
    ------------------- Code Monkey -------------------

    Thank you for downloading this package
    I hope you find it useful in your projects
    If you have any questions let me know
    Cheers!

               unitycodemonkey.com
    --------------------------------------------------
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace CodeMonkey.KeyDoorSystemCM
{

    public class DoorKeyUI : MonoBehaviour
    {
        [Tooltip("The Prefab for a single UI Key")]
        public Transform keyUISinglePrefab;
        [Tooltip("The Key Holder that will be displayed")]
        public DoorKeyHolder doorKeyHolder;

        void Start()
        {
            if (doorKeyHolder == null)
            {
                Debug.LogError("You need to set the DoorKeyHolder field on the DoorKeyUI! Drag the Player Game Object onto it.");
                return;
            }
            // Ensure doorKeyHolder is assigned before subscribing to events
            doorKeyHolder.OnDoorKeyAdded += DoorKeyHolder_OnDoorKeyAdded;
            doorKeyHolder.OnDoorKeyUsed += DoorKeyHolder_OnDoorKeyUsed;
        }

        private void DoorKeyHolder_OnDoorKeyAdded(object sender, System.EventArgs e)
        {
            // Handle the event when a key is added
        }

        private void DoorKeyHolder_OnDoorKeyUsed(object sender, System.EventArgs e)
        {
            // Handle the event when a key is used
        }
    }
}