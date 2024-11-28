# sonosthesia-unity-reactive-assets

This project demonstrates [sonosthesia](https://github.com/jbat100/sonosthesia-documentation) unity packages which allow XR interaction with procedural graphics and sound. These interactions combine a number of different techniques:

- physics collisions and triggers (using [Unity Physics](https://docs.unity3d.com/Manual/PhysicsSection.html))
- hand shape analysis and pose detection (using [XR Hands](https://docs.unity3d.com/Packages/com.unity.xr.hands@1.5/manual/index.html))
- continuous data flow and processing based on [Rx](https://github.com/neuecc/UniRx)
- a custom affordance system based on interaction sources and actors

Fist, open and pinch [hand shapes](https://docs.unity3d.com/Packages/com.unity.xr.hands@1.5/manual/gestures/hand-shapes.html) have different effects on the reactive assets.

XR controller interaction is implemented as mimicking hand shape through a combination of grip and trigger. It is mostly used for debug porposes, more sophisticated controller interactions will be implemented in later iterations.

# Demo Application

These demo scenes include reactive sound, videos including sound are available. System menu pinch gestures are available to bring up scene selection UI (left hand) and recenter scene (right hand).

### Build Instructions 

- You must open and build `FMODProject` in FMOD studio
- Android build settings are for Quest 3 (you can change the `Oculus/OculusProjectConfig` asset for aditional device support) 
- Standalone settings can build Link executable on Windows but hands are not supported.
- Do not apply the removing HDR support suggestion as it will remove bloom effect.

# Test Scenes

### Pollen

Video with reactive sound available [here](https://www.youtube.com/watch?v=cWXSkkcUVtA&list=PL8HqVGO27FJP4i2wh5F9h6oP8IscdKsg2). 

<p align="center">
    <img alt="RtMIDIInput" src="https://github.com/user-attachments/assets/438dda8a-b4de-4131-9199-3ec0ecad2a4d" width="80%">
</p>

### Spark

Video with reactive sound available [here](https://www.youtube.com/watch?v=Pw_EPlO7XNs&list=PL8HqVGO27FJP4i2wh5F9h6oP8IscdKsg2). 

<p align="center">
    <img alt="RtMIDIInput" src="https://github.com/user-attachments/assets/f6a21a40-8e9c-4807-abb2-b38d2de29527" width="80%">
</p>


# Packages

This project illustrates the use of the following sonosthesia Unity [packages](https://github.com/jbat100/sonosthesia-unity-packages).

### Data Flow

- [com.sonosthesia.signal](https://github.com/jbat100/sonosthesia-unity-packages/tree/main/packages/com.sonosthesia.signal)
- [com.sonosthesia.channel](https://github.com/jbat100/sonosthesia-unity-packages/tree/main/packages/com.sonosthesia.channel)
- [com.sonosthesia.envelope](https://github.com/jbat100/sonosthesia-unity-packages/tree/main/packages/com.sonosthesia.envelope)
- [com.sonosthesia.trigger](https://github.com/jbat100/sonosthesia-unity-packages/tree/main/packages/com.sonosthesia.trigger)

### Interaction

- [com.sonosthesia.dynamic](https://github.com/jbat100/sonosthesia-unity-packages/tree/main/packages/com.sonosthesia.dynamic)
- [com.sonosthesia.interaction](https://github.com/jbat100/sonosthesia-unity-packages/tree/main/packages/com.sonosthesia.interaction)
- [com.sonosthesia.touch](https://github.com/jbat100/sonosthesia-unity-packages/tree/main/packages/com.sonosthesia.touch)

### Procedural Graphics 

- [com.sonosthesia.noise](https://github.com/jbat100/sonosthesia-unity-packages/tree/main/packages/com.sonosthesia.noise)
- [com.sonosthesia.mesh](https://github.com/jbat100/sonosthesia-unity-packages/tree/main/packages/com.sonosthesia.mesh)
- [com.sonosthesia.deform](https://github.com/jbat100/sonosthesia-unity-packages/tree/main/packages/com.sonosthesia.deform)
- [com.sonosthesia.trajectory](https://github.com/jbat100/sonosthesia-unity-packages/tree/main/packages/com.sonosthesia.trajectory)

### Procedural Sound

- [com.sonosthesia.audio](https://github.com/jbat100/sonosthesia-unity-packages/tree/main/packages/com.sonosthesia.audio)
- [com.sonosthesia.fmod](https://github.com/jbat100/sonosthesia-unity-packages/tree/main/packages/com.sonosthesia.fmod)

### Glue

- [com.sonosthesia.deforminteraction](https://github.com/jbat100/sonosthesia-unity-packages/tree/main/packages/com.sonosthesia.deforminteraction)
- [com.sonosthesia.fmodinteraction](https://github.com/jbat100/sonosthesia-unity-packages/tree/main/packages/com.sonosthesia.fmodinteraction)

