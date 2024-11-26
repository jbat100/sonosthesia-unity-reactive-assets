# sonosthesia-unity-reactive-assets

# Build for Quest

I had a bit of a nightmare importing the Meta SDKs, it broke most of my stuff, it's very opinionated and there isn't much documentation on how to get it to run alongside the XR interaction toolkit

https://developers.meta.com/horizon/documentation/unity/unity-prepare-for-publish
https://unity.com/blog/engine-platform/get-started-developing-for-quest-3-with-unity

Trying to get hand tracking:
- oculus build settings specify hand tracking 
- oculus xr plugin gives me no hands
- open xr with both controller and hands gives me hands but no actors and permanent UI beams like shape is not detected 

# Tips and Tricks

### Cleanup Unity files

Library delete can be extremely slow on Windows if done in the normal Recycle Bin way

This is nearly instantaneous

del /f/s/q Library > nul
rmdir /s/q Library
