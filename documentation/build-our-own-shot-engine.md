# Build Our Own Shot Engine

## Goal

Build a replacement shot engine that reproduces the functional shape of IDRA without depending on `GolfInLib.dll`.

The goal is not to clone the original implementation line by line. The goal is to build a clean, understandable engine that:

- reads synchronized high-speed camera frames
- detects a shot reliably
- reconstructs ball launch and early trajectory
- estimates club path/speed/attack angle
- estimates spin
- outputs a stable shot object usable by the rest of the system

## What We Already Know

From reverse engineering, the original engine appears to be organized around this pipeline:

1. load and initialize cameras
2. wait for a shot
3. decide whether the ball moved enough
4. extract ball data
5. build ball trajectory and launch
6. extract club data
7. build club path and speed
8. infer backspin and sidespin
9. emit the shot
10. save/export debug and post-shot artifacts

This is enough to design a replacement architecture.

## Success Criteria

For a first usable internal engine, success should mean:

- shot trigger works reliably
- ball speed is directionally correct and repeatable
- launch angle and horizontal launch are stable
- club speed and club path are available on most full swings
- spin estimate is useful, even if initially rough
- every shot produces rich debug artifacts for tuning

For production-level success, add:

- high reliability across lighting conditions
- low false positives
- fast recovery from frame drops and camera issues
- robust calibration and validation tooling
- repeatability across hardware setups

## Recommended Architecture

Break the replacement engine into these modules:

### 1. Camera Runtime

Responsibilities:

- enumerate cameras
- assign master/slave roles
- configure exposure, gain, ROI, and frame rate
- maintain synchronized circular frame buffers
- detect dropped/skipped frames

Suggested output:

- timestamped frame stream for each camera
- frame index metadata
- health/status metrics

### 2. Calibration and Stereo Geometry

Responsibilities:

- load stereo calibration
- validate camera identity against calibration metadata
- compute rectification and triangulation helpers
- expose `ppmm` and world-coordinate transforms

Suggested output:

- camera intrinsics/extrinsics
- rectification maps
- pixel-to-metric scale helpers
- 3D ray/triangulation helpers

### 3. Shot Trigger / Wait-For-Shot

Responsibilities:

- monitor live frame buffers
- detect candidate movement events
- decide if a valid shot window exists
- reject noise, lighting flicker, and non-shot motion

Suggested output:

- buffered frame window around impact
- trigger timestamp
- shot candidate confidence

### 4. Ball Detection

Responsibilities:

- segment the ball in both cameras
- track the ball across frames
- reject invalid detections
- detect unsafe reading zones and out-of-bounds cases

Suggested output:

- per-frame 2D ball detections
- confidence scores
- cleaned track for each camera

### 5. Ball Reconstruction

Responsibilities:

- pair detections across both cameras
- triangulate early 3D ball positions
- compute launch direction
- compute launch angle
- compute ball speed
- compute initial trajectory points

Suggested output:

- ball speed
- launch angle
- launch direction
- 3D trajectory seed

### 6. Club Detection and Tracking

Responsibilities:

- detect club head / face / shaft region
- estimate club movement through impact
- support multiple club categories
- handle handedness

Suggested output:

- 2D club tracks
- impact location estimate
- club category estimate
- club face estimate if available

### 7. Club Reconstruction

Responsibilities:

- combine 2D tracks into 3D or pseudo-3D estimates
- compute club speed
- compute club path
- compute attack angle

Suggested output:

- club speed
- club path
- attack angle
- club-ball impact percent if supported

### 8. Spin Estimation

Responsibilities:

- estimate backspin
- estimate sidespin
- estimate spin axis
- combine geometric features with ML if useful

Suggested output:

- backspin
- sidespin
- spin axis
- total spin

### 9. Shot Validation and Correction

Responsibilities:

- clamp impossible values
- reject low-confidence shots
- log why a shot was rejected
- apply optional correction layers

Suggested output:

- validated shot object
- validation flags
- correction log

### 10. Output and Debugging

Responsibilities:

- emit shot callback/event
- write debug images and logs
- save post-shot video
- persist raw and processed data for tuning

Suggested output:

- stable shot DTO/API
- per-shot debug bundle
- replayable saved cases

## Recommended Build Order

Build in this order:

### Phase 1: Infrastructure

- implement camera runtime
- implement circular frame buffers
- implement calibration loader and validation
- implement frame recording and replay

Deliverable:

- reliable capture and replay environment

### Phase 2: Shot Trigger MVP

- build wait-for-shot logic
- detect gross ball motion
- capture pre-impact and post-impact frame windows

Deliverable:

- robust shot trigger with saved frame bundles

### Phase 3: Ball Metrics MVP

- implement ball segmentation in both cameras
- triangulate early ball positions
- compute ball speed, launch angle, and launch direction

Deliverable:

- MVP ball-only launch monitor

### Phase 4: Club Metrics MVP

- implement club detection/tracking
- compute club speed and club path
- estimate attack angle

Deliverable:

- ball + club launch monitor without advanced spin

### Phase 5: Spin V1

- build initial backspin and sidespin estimator
- start with hybrid rule-based + regression approach
- use replayed shots for tuning

Deliverable:

- useful first-pass spin estimates

### Phase 6: Production Hardening

- improve rejection rules
- improve low-light robustness
- handle dropped frames and camera edge cases
- add calibration drift checks
- build operator diagnostics

Deliverable:

- deployable engine candidate

## MVP Scope Recommendation

Do not try to build the full final engine first.

A strong MVP should focus on:

- two-camera synchronized capture
- shot trigger
- ball speed
- launch angle
- launch direction
- debug replay

Leave for later:

- exact club-face estimation
- advanced club classification
- post-shot export polish
- high-quality spin
- every edge-case fallback

## Suggested Technical Approach

### Classical CV First

Start with classical computer vision for the MVP:

- background subtraction / frame differencing
- thresholding and morphology
- contour or blob filtering
- triangulation from stereo correspondences
- simple trajectory fitting

This gives you a controllable baseline and better debugging.

### Add ML Where It Helps Most

Use ML selectively where it has strong leverage:

- club segmentation/classification
- impact-on-club estimation
- spin regression

Avoid making the whole engine depend on a large opaque model at the start.

## Data Strategy

You need your own replay dataset if you want a good engine.

Start collecting:

- raw paired camera frames around impact
- timestamps and frame indices
- calibration used
- final shot output from existing engine for comparison
- notes about good/bad shots

This enables:

- offline tuning
- regression testing
- model training
- failure analysis

## Validation Strategy

Create a replay harness as early as possible.

For each saved shot, compare:

- shot triggered or not
- ball speed
- launch angle
- launch direction
- club speed
- club path
- attack angle
- spin values

Track:

- absolute error
- repeatability
- failure mode category

## Biggest Risks

### 1. Synchronization

If camera timing is unstable, everything downstream gets harder.

### 2. Calibration Quality

If stereo calibration is weak, 3D ball and club estimates will drift.

### 3. Club Detection Complexity

Club tracking across different club types, lighting, and handedness is likely one of the hardest parts.

### 4. Spin Accuracy

Spin can be the longest-tail problem. Expect several iterations.

### 5. False Triggers

A weak shot trigger will waste a lot of time downstream and fill your dataset with junk.

## Team Recommendation

If possible, split the work into parallel tracks:

- camera/runtime/calibration
- ball pipeline
- club pipeline
- replay tooling and evaluation
- output/API compatibility

## Definition Of A Good First Version

A good first version is not one that matches every IDRA number perfectly.

A good first version:

- triggers correctly
- produces believable ball metrics
- provides enough debug evidence to improve rapidly
- is understandable and maintainable

That is the fastest route to a real replacement.

## Immediate Next Steps

1. Define the target shot DTO and output contract.
2. Build the frame replay harness.
3. Implement camera runtime and synchronized buffering.
4. Build ball-motion trigger and frame-window extraction.
5. Build ball-only reconstruction before touching club or spin.