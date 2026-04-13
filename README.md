# Orion

Reverse engineering workspace for analyzing the Sim Sports / IDRA launch monitor stack and designing a replacement shot engine.

## What This Repo Contains

This repository is focused on the parts of the recovered system that are useful for understanding and rebuilding the shot pipeline:

- decompiled managed C# source in `Idra Decompiled/`
- extracted native analysis artifacts in `native-analysis/`
- Ghidra helper scripts in `ghidra-scripts/`
- working documentation in `documentation/`

The original vendor binary drop is intentionally not tracked in git right now. The repo is meant to be a working reverse-engineering and rebuild workspace, not an archive of all original application files.

## Current Understanding

The main proprietary shot engine does not appear to live in the managed .NET UI and orchestration layers alone. The strongest evidence points to the native DLL `GolfInLib.dll` as the core engine responsible for:

- camera initialization and buffering
- shot triggering
- ball detection and reconstruction
- club extraction and trajectory building
- spin estimation
- shot callback/export flow

The decompiled .NET code is still important because it shows the managed/native boundary, data wrappers, callback flow, and simulator integration.

## Key Docs

- `documentation/idra-learnings.md`: current findings from the decompiled managed code and native DLL analysis
- `documentation/build-our-own-shot-engine.md`: plan for building a clean replacement shot engine

## Suggested Starting Points

If you are new to the repo, start here:

1. Read `documentation/idra-learnings.md`.
2. Read `documentation/build-our-own-shot-engine.md`.
3. Inspect `Idra Decompiled/IDRA-8.1.9/GICTSCore/` to understand the managed/native boundary.
4. Inspect `native-analysis/golfinlib-shot-pipeline/summary.txt` and the extracted `.c` files to understand the recovered native pipeline.

## Repository Layout

```text
.
├── README.md
├── Idra Decompiled/
├── documentation/
├── ghidra-scripts/
└── native-analysis/
```

## Notes

- Decompiled and decompiled-native outputs are recovered artifacts, not original source.
- Some names remain obfuscated because they came from compiled binaries.
- Secrets detected during import were redacted before the initial push.

## Goal

The end goal of this repo is to move from analysis to implementation: understand the original shot-processing pipeline well enough to build an independent, maintainable replacement engine.
