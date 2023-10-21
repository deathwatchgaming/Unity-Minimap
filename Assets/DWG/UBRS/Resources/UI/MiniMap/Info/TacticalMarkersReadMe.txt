Tactical Markers for MiniMap
----------------------------------------------------------------------------------

Description:

Create Tactical Markers for your MiniMap for your Unity projects.

Allows for pressing key: "T" wherever you are looking at & as such this adds 
a Tactical Marker to the MiniMap.


Manual Setup Instruction:
-------------------------

* Simply follow the instruction for manual setup found below.

-----------------------------------------------------------------------------------

Step 1: Create Empty -> TacticalMarker
___________________________________________________________________________________

1.A) Create an "Empty" and rename it to: "TacticalMarker"

1.B) Make sure you add the layer: "MiniMap"

Transform:
----------

Position:  X: 0 Y: 0 Z: 0
Rotation:  X: 0 Y: 0 Z: 0
Scale:     X: 1 Y: 1 Z: 1

This is a "holder"

Ok, now before we continue, it makes sense to focus on creating some materials 
that we will then use shortly after and it will then make sense why we opted to 
pause and do this first now.

-----------------------------------------------------------------------------------

Step 2: Create Material -> "Icon"
___________________________________________________________________________________

2) Create new: "Material" named: "Icon"

Albedo: Knob

Rendering Mode: Cutout
Alpha Cutoff: 0.05

-----------------------------------------------------------------------------------

Step 3: Import Texture and then Create Material -> "Ping"
___________________________________________________________________________________

3.A) Import Texture: "DWG_TacticalPing.png"

Texture Type: Sprite (2D and UI)
Compression: None

Select "Apply" to apply changes.

3.B) Next, create a new: "Material" named: "Ping"

Albedo: DWG_TacticalPing

Rendering Mode: Cutout
Alpha Cutoff: 0.5

-----------------------------------------------------------------------------------

Step 4: Create in TacticalMarker -> 3D Object: Plane -> "Icon"
___________________________________________________________________________________

4.A) Create in "TacticalMarker": a "Plane" and rename it to: "Icon"

4.B) Make sure you add the layer: "MiniMap"

Transform:
----------

Position:  X: 0 Y: 0 Z: 0
Rotation:  X: 0 Y: 0 Z: 0
Scale:     X: 1 Y: 1 Z: 1

4.C) Turn off the: "Mesh Collider"

4.D) Add Material: "Icon" * (what we made in step 2)

-----------------------------------------------------------------------------------

Step 5: Create in TacticalMarker -> 3D Object: Plane -> "Ping"
___________________________________________________________________________________

5.A) Create in "TacticalMarker": a "Plane" and rename it to: "Ping"

5.B) Make sure you add the layer: "MiniMap"

Transform:
----------

Position:  X: 0   Y: 0.15   Z: 0
Rotation:  X: 0   Y:    0   Z: 0
Scale:     X: 1   Y:    1   Z: 1

5.C) Turn off the: "Mesh Collider"

5.D) Add Material: "Ping" * (what we made in step 3)

-----------------------------------------------------------------------------------

Step 6: Animate: "Ping"
___________________________________________________________________________________

6.A) Go to Menu: "Window" and select: "Animation"

6.B) Select: "Create" and name Timeline "Ping"

6.C) Select "Add Property" -> Transform "Scale"

6.D) Select "Add Property" -> Mesh Renderer "Color"

6.E) Add Key at: 1:50

6.F) Scale: start to 1:50

X: 2 then set ignore
Z: 2 then set ignore

At 1:00 delete scale keys

6.G) Color: from 1 to 1:50

At: 1:50
R: 0
G: 0
B: 0
A: 0

That completes that part for ping animation.

-----------------------------------------------------------------------------------

Step 7: Create Prefab: "TacticalMarker"
___________________________________________________________________________________

7.A) Drag the holder: "TacticalMarker" with eveything contained into project to 
     make a prefab.

7.B) Now, Since the prefab is made, we can go ahead and delete the "TacticalMarker"
     in the scene as it is no longer needed.

-----------------------------------------------------------------------------------

Step 8: Add Script: DWG_TacticalMarker & Prefab: TacticalMarker
___________________________________________________________________________________

8.A) Add component script "DWG_TacticalMarker" to your: "PlayerController Holder" 
     ie: "FPSController"

8.B) Add the prefab: "TacticalMarker" to script settings

DWG Tactical Marker (Scipt)
----------------------------

Script: DWG_TacticalMarker
Tactical Marker: TacticalMarker
Tactical Marker Enabled: Checked -> Yes

-----------------------------------------------------------------------------------

That is it and concludes the Tactical Markers for MiniMap setup steps.

Best of Luck!
