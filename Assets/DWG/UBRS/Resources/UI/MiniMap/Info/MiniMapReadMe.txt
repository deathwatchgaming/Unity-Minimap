MiniMap
----------------------------------------------------------------------------------

Description:

Create a Minimap for your Unity projects.


Manual Setup Instruction:
-------------------------

* Simply follow the instruction for manual setup found below.

-----------------------------------------------------------------------------------

Step 1: Import Images:
___________________________________________________________________________________

Import Images and select them and modify settings for each as found below:

Texture Type: Sprite (2D and UI)
Compression: None

Select "Apply" to apply the changes.

-----------------------------------------------------------------------------------

Step 2: Add Tag: "Player" to PlayerController and also create new layer: "MiniMap"
___________________________________________________________________________________


2.A) Add the Tag: "Player" to your PlayerController unless this is already applied.

Note: The next step "2.B" is completely unrelated from the last step "2.A", but, 
let us get it out of the way now just to be prepared.

2.B) Add a new layer called: "MiniMap" * this will be used later


-----------------------------------------------------------------------------------

Step 3: Create Empty -> UI 
___________________________________________________________________________________


3.A) Create Empty and Rename it to: "UI"

3.B) Add Layer: "UI"

Modify as follows as this is simply a "holder":

Position: X: 0  Y: 0  Z: 0
Rotation: X: 0  Y: 0  Z: 0
Scale:    X: 1  Y: 1  Z: 1


-----------------------------------------------------------------------------------

Step 4: Create in UI -> Canvas
___________________________________________________________________________________

4.A) Inside the Holder called: "UI" that you just created go ahead and create a
     "Canvas"

4.B) Make sure the "Layer" is set as: "UI"

Modify:

Canvas
-------

Render Mode: Screen Space - Overlay
Pixel Perfect: Selected

Canvas Scaler
-------------

UI Scale Mode: Scale with Screen Size
Reference Resolution: X: 1920  Y: 1080
Match: Width
Reference Pixels Per: 1920


-----------------------------------------------------------------------------------

Step 5: Create in UI -> Create Empty -> MiniMap (Holder)
___________________________________________________________________________________


5.A) Inside "Canvas", create an "Empty" and rename it to "MiniMap"

Note: this will be our Minimap "holder".

5.B) Make sure the "Layer" is set as: "UI"

Modify:

Rect Transform
---------------

Anchors: Bottom & Right

Position: X: -155  Y: 250  Z: 0
Width: 256
Height: 256


-----------------------------------------------------------------------------------

Step 6: Create in MiniMap -> Create Mask (RawImage)
___________________________________________________________________________________


6.A) Inside "MiniMap", create a new: "RawImage" and name it "Mask"

6.B) Make sure the "Layer" is set as: "UI"

Modify:

Rect Transform
---------------

Anchors: Middle & Center

Position: X: 0  Y: 0  Z: 0
Width: 256
Height: 256

6.C) Add Component: Mask

Modify:

Mask (Script)
-------------

Show Mask Graphic: "Un-check this"


-----------------------------------------------------------------------------------

Step 7: Create in MiniMap -> MiniMapFrame (RawImage)
___________________________________________________________________________________


7.A) Inside "MiniMap", create a new: "RawImage" and name it "MiniMapFrame"

7.B) Make sure the "Layer" is set as: "UI"

Modify:

Rect Transform
---------------

Anchors: Middle & Center

Position: X: 0  Y: 0  Z: 0
Width: 256
Height: 256

Modify:

Raw Image (Script)
------------------

Texture: DWG_MM_Outer


-----------------------------------------------------------------------------------

Step 8: Create in Mask -> MiniMap_Texture (RawImage) & Render "MiniMapTexture"
___________________________________________________________________________________


8.A) Inside "Mask, create a new: "RawImage" and name it: "MiniMap_Texture"

8.B) Make sure the "Layer" is set as: "UI"

Modify:

Rect Transform
---------------

Anchors: Middle & Center

Position: X: 0  Y: 0  Z: 0
Width: 256
Height: 256

8.C) Create a new Render Texture called: "MiniMapTexture"

Now, go back into "MiniMap_Texture" inspector and...

Modify:

Raw Image (Script)
------------------

Texture: MiniMapTexture


-----------------------------------------------------------------------------------

Step 9: Create in Canvas -> Cursor (RawImage)
___________________________________________________________________________________


9.A) Go back into "Canvas" and create "RawImage" and name it: "Cursor"

9.B) Make sure the "Layer" is set as: "UI"

Modify:

Rect Transform
---------------

Anchors: Middle & Center

Position: X: 0  Y: 0  Z: 0
Width: 64
Height: 64


Raw Image (Script)
------------------

Texture: DWG_CursorA


-----------------------------------------------------------------------------------

Step 10: Create in PlayerController -> PlayerIcon
___________________________________________________________________________________


10.A) Inside your "PlayerController", create an "Empty" & rename it to "PlayerIcon"

10.B) Make sure the "Layer" is set as: "MiniMap"

Modify:

Transform:
----------

Position: X: 0    Y: 6   Z: 0
Rotation: X: 0    Y: 0   Z: 0
Scale:    X: 1    Y: 1   Z: 1

10.C) Inside "PlayerIcon", create a 3D Object: "Plane" & rename it to "Icon"

10.D) Make sure the "Layer" is set as: "MiniMap"

Modify:

Transform:
----------

Position: X: 0    Y:   0    Z: 0
Rotation: X: 0    Y: -90    Z: 0
Scale:    X: 1.5  Y: 1.5    Z: 1.5

Mesh Renderer:
--------------

In Lighting:

Cast Shadows: Off
Recieve Shadows: Un-check

10.E) Add material by dragging "DWG_PlayerIcon.png" onto Inspector below component
      button.

Modify:

DWG_PlayerIcon
--------------

Rendering Mode: Cutout
Alpha Cutoff: 0.05
Smoothness: 0 


-----------------------------------------------------------------------------------

Step 11: Create in "Icon" -> MiniMap Camera
___________________________________________________________________________________


11.A) Inside "Icon", create a "Camera" & rename it to "MiniMap Camera"

11.B) Make sure the "Layer" is set as: "MiniMap"

11.C) Now we need to tie this to the Player so we need to drag this to the holder:
      "PlayerController" as this will get the position.  After such, let us now 
      "Zero Out" everything.

Modify like so:

Position: X: 0  Y: 0  Z: 0
Rotation: X: 0  Y: 0  Z: 0
Scale:    X: 1  Y: 1  Z: 1

11.D) Now we need to make this independent, so we need to drag this outside of
      everything and place it at the very bottom of scene below all. In essense
      (not inside anything) as this will grab the world-space position. You will 
      now see some numbers change as that is now grabbing the world-space position.

11.E) After such we need to change only the Y / Height position to raise it way up.

Modify:

Position: Y: 1100

11.F) Now let us change some camera settings.

Remove Component: Flare
Remove Component: Audio Listener

Change these as follows:

Camera:
-------

Clear Flags: Solid Color
Background: #000000
Culling Mask: Change to "Nothing" to unselect everything & then do select "MiniMap"
Projection: Orthographic
Size: 50
Far: 5000
Depth: 10
Target Texture: MiniMapTexture

Transform:
----------

Rotation: X: 90

11.G) Next, change your terrain to have the "Layer" set as: "MiniMap"

11.H) Add Component (Script): "DWG_MiniMapFollow.cs" to "MiniMap Camera"

Modify:

Mini Map Follow (Script):
-------------------------

Script: DWG_MiniMapFollow
Rotate With Player:
Mini Map Height: 1100

Note: "Rotate With Player" is optional and is up to your preference to use or not.


-----------------------------------------------------------------------------------


That is it and concludes the MiniMap setup steps.

Best of Luck!