# DivineFPS

A NeoModLoader mod for WorldBox focused on measured, configurable performance improvements.

## Current status

This repository contains the initial NML mod scaffold. It registers with the loader and writes a startup message to the NML log. It does not yet change game behavior or claim to improve FPS. Performance features will be added after identifying a repeatable bottleneck and verifying that the change preserves simulation behavior.

## Build

Requirements: WorldBox installed locally, NeoModLoader installed in the game's `worldbox_Data/StreamingAssets/mods` folder, and the .NET Framework 4.8 targeting pack / MSBuild on Windows.

The project expects the game root two directories above this repository by default. If your layout differs, pass `GameRoot` explicitly:

```powershell
dotnet build .\DivineFPS.csproj -p:GameRoot="C:\Path\To\WorldBox"
```

The build uses the game's managed assemblies and NML DLL as references; those files are not committed. Copy `bin/Debug/net48/DivineFPS.dll` and `mod.json` into a `DivineFPS` folder under the game's `worldbox_Data/StreamingAssets/mods` directory, then launch with Experimental Mode enabled.

## Next step

Before implementing an optimization, record the WorldBox version/platform and a reproducible lag scenario (world size, approximate population, game speed, and whether the symptom is low FPS or slow simulation). That lets us profile and target the actual bottleneck rather than add risky blanket patches.
