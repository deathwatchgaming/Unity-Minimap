/*
*
*  Name: DWG Minimap
*  File: DWG_MiniMapFollow.cs
*  Author: Deathwatch Gaming
*  License: MIT
*
*/

// Using - Engine - UI
using UnityEngine;
using UnityEngine.UI;

// Namespace - DWG.UBRS.DWG_MiniMapFollow
namespace DWG.UBRS.DWG_MiniMapFollow
{
    // Public - Class - DWG_MiniMapFollow
    public class DWG_MiniMapFollow : MonoBehaviour
    {

        // Private - GameObject - Player
        private GameObject player;

        // Public - Bool - RotateWithPlayer - True
        public bool RotateWithPlayer = true;

        // Public - Float - MiniMapHeight   
        public float MiniMapHeight = 1100;

        // Private - Transform - Original Parent    
        private Transform origParent;

        // Private - Transform - PlayerParent    
        private Transform PlayerParent;

        // Public - Bool - MiniMapEnabled - True
        public bool MiniMapEnabled = true; 

        // Public - RawImage - Mask - Image
        public RawImage Mask;

        // Public - RawImage - MiniMap_Texture - Image
        public RawImage MiniMap_Texture;

        // Public - RawImage - MiniMapFrame - Image
        public RawImage MiniMapFrame;

        // Use This For Initialization

        // Public - Void - Start
        public void Start()
        {

            // Player - GameObject - FindGameObjectWithTag - Player
            player = GameObject.FindGameObjectWithTag ("Player");

            // Transform - Position - New Vector3 - Player - Transform - Position X - MiniMapHeight - Player - Transform - Position Z
            transform.position = new Vector3(player.transform.position.x, MiniMapHeight, player.transform.position.z);

            // OriginalParent - Transform - Parent
            origParent = transform.parent;

            // PlayerParent - Player - Transform
            PlayerParent = player.transform;

        } // Close - Public - Void - Start

        // Update Is Called Once Per Frame

        // Public - Void - Update
        public void Update()
        {

            // If MiniMapEnabled Is True
            if (MiniMapEnabled == true)
            {

                // RawImage - Mask - gameObject - SetActive - True
                Mask.gameObject.SetActive(true);

                // RawImage - MiniMap_Texture - gameObject - SetActive - True
                MiniMap_Texture.gameObject.SetActive(true);

                // RawImage - MiniMapFrame- gameObject - SetActive - True
                MiniMapFrame.gameObject.SetActive(true);

                // GetComponent - DWG_MiniMapFollow  - Enabled - True
                GetComponent<DWG_MiniMapFollow>().enabled = true;

                // Debug - Log - MiniMap Enabled
                Debug.Log("The MiniMap is enabled.");

            } // Close - If MiniMapEnabled Is True

            // Else If MiniMapEnabled Is False
            else if (MiniMapEnabled == false) 
            {

                // RawImage - Mask - gameObject - SetActive - False
                Mask.gameObject.SetActive(false);

                // RawImage - MiniMap_Texture - gameObject - SetActive - False
                MiniMap_Texture.gameObject.SetActive(false);

                // RawImage - MiniMapFrame- gameObject - SetActive - False
                MiniMapFrame.gameObject.SetActive(false);

                // GetComponent - DWG_MiniMapFollow - Enabled - False
                GetComponent<DWG_MiniMapFollow>().enabled = false;

                // Debug - Log - MiniMap Disabled
                Debug.Log("The MiniMap is disabled.");

            } // Close - Else If MiniMapEnabled Is False

        } // Close - Public - Void - Update
        
        // LateUpdate Is Called Once Per Frame
        
        // Public - Void - LateUpdate
        public void LateUpdate ()
        {

            // If RotateWithPlayer Is True
            if (RotateWithPlayer == true)
            {

                // Transform - SetParent - PlayerParent
                transform.SetParent(PlayerParent);

                // Transform - Position - New Vector3 - Transform - Position X - MiniMapHeight - Player - Transform - Position Z
                transform.position = new Vector3(transform.position.x, MiniMapHeight, transform.position.z);

            } // Close - If RotateWithPlayer Is True

            // Else If RotateWithPlayer Is False
            else if (RotateWithPlayer == false)
            {

                // Transform - SetParent - OriginalParent
                transform.SetParent(origParent);

                // Transform - Position - New Vector3 - Player - Transform - Position X - MiniMapHeight - Player - Transform - Position Z
                transform.position = new Vector3(player.transform.position.x, MiniMapHeight, player.transform.position.z);

            } // Close - SetParent - OriginalParent

        }  // Close - Public - Void - LateUpdate

    } // Close - Public - Class - DWG_MiniMapFollow

} // Close - Namespace - DWG.UBRS.DWG_MiniMapFollow
