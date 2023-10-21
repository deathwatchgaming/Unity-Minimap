// Using - Engine - UI
using UnityEngine;
using UnityEngine.UI;

// Namespace - UBRS.DWG_TacticalMarker
namespace UBRS.DWG_TacticalMarker
{

    // Public - Class - DWG_TacticalMarker
    public class DWG_TacticalMarker : MonoBehaviour
    {

        // Public - GameObject - TacticalMarker
        public GameObject TacticalMarker;

        // Private - Float - MarkerOffset
        private float markerOffset;

        // Private - FPCamera
        private Camera FPCamera;

        // Private - Float - MinimapCamHeight
        private float MinimapCamHeight;

        // Private - Ray - Ray
        private Ray ray;

        // Private - RaycastHit - Hit
        private RaycastHit hit;

        // Private - String - Marker ID - None
        private string MARKER_ID = "*NONE*"; // This Is How We Keep Track Of Its existence In The World

        // Public - Bool - TacticalMarkerEnabled - True
        public bool TacticalMarkerEnabled = true; 

        // Use This For Initialization

        // Void - Start
        void Start()
        {

            // FPCamera - GetComponentInChildren - Camera
            FPCamera = GetComponentInChildren<Camera>();

            // MinimapCamHeight - GameObject Find - MiniMap Camera - Transform Position Y
            MinimapCamHeight = GameObject.Find("MiniMap Camera").transform.position.y;

            // MarkerOffset - MinimapCamHeight - 10.0f
            markerOffset = MinimapCamHeight - 10.0f;

        } // Close - Void - Start

        // Update is called once per frame

        // Void - Update
        void Update()
        {

            // If TacticalMarkerEnabled Is True
            if (TacticalMarkerEnabled == true)
            {

                // GetComponent - DWG_TacticalMarker - Enabled - True
                GetComponent<DWG_TacticalMarker>().enabled = true;

                // Debug - Log - Compass Enabled
                Debug.Log("Tactical Markers is enabled.");

                // If Input - GetKeyUp - KeyCode T
                if (Input.GetKeyUp(KeyCode.T))
                {

                    // PlaceMarker
                    PlaceMarker();

                } // close - If Input - GetKeyUp - KeyCode T

            } // Close - If TacticalMarkerEnabled Is True

            // Else If TacticalMarkerEnabled Is False
            else if (TacticalMarkerEnabled == false) 
            {

                // GetComponent - DWG_TacticalMarker - Enabled - False
                GetComponent<DWG_TacticalMarker>().enabled = false;

                // Debug - Log - Disabled
                Debug.Log("Tactical Markers is disabled.");

            } // Close - Else If TacticalMarkerEnabled Is False


        } // Close - Void - Update

        // Private - Void - Place Marker
        private void PlaceMarker()
        {

            // Ray - New Ray - FPCamera - Transform Position - FPCamera - Transform Forward
            ray = new Ray(FPCamera.transform.position, FPCamera.transform.forward);

            // Are We Pointing At something In The World?

            // If - Physics - Raycast - Ray - Out Hit
            if (Physics.Raycast(ray, out hit))
            {

                // Vector3 - Marker Location - New Vector3 - HitPoint X - MarkerOffset - HitPoint Z
                Vector3 markerLocation = new Vector3(hit.point.x, markerOffset, hit.point.z);

                // If Marker ID Is None
                if (MARKER_ID == "*NONE*") // No Marker On The Map
                {

                    // GameObject Marker - Instantiate - TacticalMarker - MarkerLocation - Quaternion Identity - Null
                    GameObject marker = Instantiate(TacticalMarker, markerLocation, Quaternion.identity, null);

                    // Marker ID - Marker Name
                    MARKER_ID = marker.name;  // Remember This For The Next Time

                } // Close - If Marker ID Is None

                // Else 
                else
                {

                    // Find The Marker That Exists And Relocate It

                    // GameObject - Marker - GameObject - Find - Marker ID
                    GameObject marker = GameObject.Find(MARKER_ID);

                    // Destroy Marker
                    Destroy(marker);

                    // Marker - Instantiate - TacticalMarker - MarkerLocation - Quaternion Identity - Null
                    marker = Instantiate(TacticalMarker, markerLocation, Quaternion.identity, null);

                    // Marker ID - Marker Name
                    MARKER_ID = marker.name;  // Remember This For The Next Time

                } // Close - Else

            } // Close - If - Physics - Raycast - Ray - Out Hit

        } // Close - Private - Void - Place Marker

    } // Close - Public - Class - DWG_TacticalMarker

} // Close - Namespace - UBRS.DWG_TacticalMarker
