/*
*
*  Name: DWG Cursor
*  File: DWG_Cursor.cs
*  Author: Deathwatch Gaming
*  License: MIT
*
*/

// Using - Engine - UI
using UnityEngine;
using UnityEngine.UI;

// Namespace - DWG.UBRS.DWG_Cursor
namespace DWG.UBRS.DWG_Cursor
{
    // Public - Class - DWG_Cursor
    public class DWG_Cursor : MonoBehaviour
    {
        
        // Public - RawImage - CursorImage - Image
        public RawImage CursorImage;

        // Public - Bool - CursorEnabled - True
        public bool CursorEnabled = true;
        
        // Update Is Called Once Per Frame

        // Public - Void - Update
        public void Update()
        {

            // If CursorEnabled Is True
            if (CursorEnabled == true)
            {

                // RawImage - CursorImage - gameObject - SetActive - True
                CursorImage.gameObject.SetActive(true);

                // GetComponent - DWG_Cursor - Enabled - True
                GetComponent<DWG_Cursor>().enabled = true;

                // Debug - Log - Cursor Enabled
                Debug.Log("The Cursor is enabled.");

            } // Close - If CursorEnabled Is True

            // Else If CursorEnabled Is False
            else if (CursorEnabled == false) 
            {
                 
                // RawImage - CursorImage - gameObject - SetActive - False
                CursorImage.gameObject.SetActive(false);

                // GetComponent - DWG_Cursor - Enabled - False
                GetComponent<DWG_Cursor>().enabled = false;

                // Debug - Log - Cursor Disabled
                Debug.Log("The Cursor is disabled.");

            } // Close - Else If CursorEnabled Is False

        } // Close - Public - Void - Update

    } // Close - Public - Class - DWG_Cursor

} // Close - Namespace - DWG.UBRS.DWG_Cursor
