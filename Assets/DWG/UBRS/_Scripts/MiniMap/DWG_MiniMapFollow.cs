// Using - Engine - UI
using UnityEngine;
using UnityEngine.UI;

// Namespace - UBRS.DWG_MiniMapFollow
namespace UBRS.DWG_MiniMapFollow
{
    // Public - Class - DWG_MiniMapFollow
    public class DWG_MiniMapFollow : MonoBehaviour
    {

        // Private - Game Object - Player
        private GameObject player;

        // Public - Bool - Rotate With Player - True
        public bool RotateWithPlayer = true;

        // Public - Float - MiniMap Height   
        public float MiniMapHeight = 1100;

        // Private - Transform - Original Parent    
        private Transform origParent;

        // Private - Transform - Player Parent    
        private Transform PlayerParent;

        // Public - Bool - MiniMapEnabled - True
        public bool MiniMapEnabled = true; 

        // RawImage(s)

        // Public - RawImage - Mask - Image
        public RawImage Mask;

        // Public - RawImage - MiniMap_Texture - Image
        public RawImage MiniMap_Texture;

        // Public - RawImage - MiniMapFrame - Image
        public RawImage MiniMapFrame;

        // Use this for initialization
        // Public - Void - Start
        public void Start()
        {

            // Player - Game Object - Find Game Object With Tag - Player
            player = GameObject.FindGameObjectWithTag ("Player");

            // Transform - Position - New Vector3 - Player - Transform - Position X - MiniMapHeight - Player - Transform - Position Z
            transform.position = new Vector3(player.transform.position.x, MiniMapHeight, player.transform.position.z);

            // Original Parent - Transform - Parent
            origParent = transform.parent;

            // Player Parent - Player - Transform
            PlayerParent = player.transform;

        } // Close - Public - Void - Start

        // Update is called once per frame
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

                // Debug - Log - Compass Enabled
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

                // Debug - Log - Compass Disabled
                Debug.Log("The MiniMap is disabled.");

            } // Close - Else If MiniMapEnabled Is False

        } // Close - Public - Void - Update
        
        // LateUpdate is called once per frame
        // Public - Void - LateUpdate
        public void LateUpdate ()
        {

            // If Rotate With Player Is True
            if (RotateWithPlayer == true)
            {

                // Transform - Set Parent - Player Parent
                transform.SetParent(PlayerParent);

                // Transform - Position - New Vector3 - Transform - Position X - MiniMapHeight - Player - Transform - Position Z
                transform.position = new Vector3(transform.position.x, MiniMapHeight, transform.position.z);

            } // Close - If Rotate With Player Is True

            // Else If Rotate With Player Is False
            else if (RotateWithPlayer == false)
            {

                // Transform - Set Parent - Original Parent
                transform.SetParent(origParent);

                // Transform - Position - New Vector3 - Player - Transform - Position X - MiniMapHeight - Player - Transform - Position Z
                transform.position = new Vector3(player.transform.position.x, MiniMapHeight, player.transform.position.z);

            } // Close - Set Parent - Original Parent

        }  // Close - Public - Void - LateUpdate

    } // Close - Public - Class - DWG_MiniMapFollow

} // Close - Namespace - UBRS.DWG_MiniMapFollow
