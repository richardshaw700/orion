# IDRA Learnings

## Core Shot Engine

The core IDRA shot engine appears to live inside the native Windows DLL `Sim Sports Corporation/IDRA/8.1.9/GolfInLib.dll`.

The decompiled .NET projects in `Idra Decompiled` are important, but they are mostly:

- UI
- orchestration
- configuration
- callback plumbing
- shot data wrappers
- simulator integration

The actual low-level logic that turns high-speed camera frames into launch monitor data appears to be in the native `GolfInLib.dll` engine.

## Managed vs Native Boundary

The managed side in `Idra Decompiled/IDRA-8.1.9/GICTSCore` calls into `GolfInLib.dll` through SWIG/PInvoke wrappers.

Important managed boundary files:

- `Idra Decompiled/IDRA-8.1.9/GICTSCore/LightInterface.cs`
- `Idra Decompiled/IDRA-8.1.9/GICTSCore/CameraCallback.cs`
- `Idra Decompiled/IDRA-8.1.9/GICTSCore/GICTSShotData.cs`
- `Idra Decompiled/IDRA-8.1.9/GICTSCore/ShotStatusData.cs`
- `Idra Decompiled/IDRA-8.1.9/GICTSCore/GICTS.Core/GICTSDirector.cs`

High-level boundary behavior:

- `LightInterface` starts and controls the native engine.
- `CameraCallback` receives native events and completed shots.
- `GICTSShotData` and `ShotStatusData` are wrapper objects around native data fields.
- `GICTSDirector` converts native shot output into app-level shot objects and applies post-processing and simulator-facing rules.

## Core Native Shot Pipeline

The native shot pipeline recovered from `GolfInLib.dll` looks like this:

1. Load and initialize cameras.
2. Wait for a shot using buffered high-speed camera frames.
3. Detect whether the ball moved enough to qualify as a shot.
4. Extract ball data from both cameras.
5. Build the ball trajectory and launch data.
6. Extract club data.
7. Build club path, speed, and attack angle.
8. Infer backspin and sidespin.
9. Emit the completed shot through the callback interface.
10. Save shot artifacts and export post-shot video.

This is the main proprietary engine path that matters most.

## Most Important Native Functions

The first-pass Ghidra analysis found these key native functions:

- `GolfIn::Interface::waitForShot`
- `GolfIn::Interface::extractBallClub`
- `GolfIn::Interface::ballHasMoveEnough`
- `GolfIn::Ball::built`
- `GolfIn::Club::built`
- `GolfIn::Interface::compute_back_and_side_spin`
- `GolfIn::Interface::extractClub`
- `GolfIn::Interface::loadCamera`
- `GolfIn::Shot::exportPostShotVideoAndReturnImpactFrame`

These decompilations are currently stored in `native-analysis/golfinlib-shot-pipeline`.

## What Each Core Function Appears To Do

### `GolfIn::Interface::waitForShot`

This function appears to:

- grab synchronized frame buffers
- handle skipped-frame cleanup
- manage state around waiting for a shot
- trigger downstream shot extraction
- later hand off to callback, save, and export tasks

It looks like the top-level runtime loop for turning live camera state into shot-analysis work.

### `GolfIn::Interface::extractBallClub`

This function appears to:

- clear the current shot object
- build timing and frame arrays for both cameras
- call `ballHasMoveEnough`
- extract ball data
- extract club data
- reject shots if measured values are not acceptable

This is one of the clearest centers of the shot-processing pipeline.

### `GolfIn::Interface::ballHasMoveEnough`

This function appears to:

- require calibration data (`ppmm`)
- inspect both `Camera1` and `Camera2`
- run ball segmentation on images
- check unsafe reading zones
- use 3D rectification / multi-camera geometry

This looks like the gate that decides whether a valid ball-motion event exists before full shot reconstruction continues.

### `GolfIn::Ball::built`

This function appears to be responsible for constructing usable ball results after prebuilt detections exist. Based on the recovered strings and decompilation, it is involved in:

- using detections from both cameras
- working with trajectory points
- calculating launch-related outputs
- building ball trajectory data

### `GolfIn::Club::built`

This function appears to be responsible for:

- building club trajectory data
- deriving club speed
- deriving club path
- using 2D and 3D projections
- handling player handedness and club-category logic

### `GolfIn::Interface::compute_back_and_side_spin`

This function appears to:

- request or compute a spin configuration
- apply a backspin boost percentage
- apply a club-face offset
- call internal predictor objects
- update final backspin and sidespin outputs

This suggests the final spin numbers are not just raw geometric outputs. They are adjusted through a predictor-based stage.

## Strong Evidence Of ML Components

Recovered strings from `GolfInLib.dll` indicate the native engine contains ML-assisted subsystems, including:

- club detection and classification
- club-ball impact estimation
- spin predictors

Recovered indicator strings include:

- `Loading ML Spin Predictor service...`
- `IronBackSpinPredictor`
- `IronSideSpinPredictor`
- `WoodBackSpinPredictor`
- `WoodSideSpinPredictor`
- `Club.Detection.ML`
- `Ball.Impact.On.Club`

The binary also references model assets such as ONNX and edge-detection files.

## Current Conclusion

At this stage, the strongest conclusion is:

- the main IDRA intellectual property is centered on the native shot-processing pipeline in `GolfInLib.dll`
- the managed `GICTSCore` code is still valuable, but mostly as orchestration and integration around the native engine
- the shot engine is not a single tiny function; it is a pipeline spanning camera handling, motion detection, ball reconstruction, club reconstruction, spin inference, and shot export

## Current Analysis Artifacts

Relevant locations in the workspace:

- `Idra Decompiled`
- `native-analysis/ghidra-projects/GolfInLibProject`
- `native-analysis/golfinlib-shot-pipeline`

The native function dump summary is at:

- `native-analysis/golfinlib-shot-pipeline/summary.txt`

## Next Documentation Targets

Useful next sections to add later:

- camera initialization and acquisition lifecycle
- detailed ball reconstruction flow
- detailed club reconstruction flow
- spin inference and predictor usage
- callback/output path into managed code
- calibration dependencies and failure modes