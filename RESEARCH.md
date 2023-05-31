# Research

How are we going to make this?

## Network Mode Differences

### Singleplayer

In singleplayer, we can essentially just replace the `Main.tile` tilemap, but this leaves some disparities with multiplayer functionality.

### Multiplayer

In multiplayer, we can spawn additional server processes -- there is notable memory overhead in this approach, though. The client remains unchanged and should just connect to spawned server processes.

There should be an optional way to send every player to a subworld, with potentially some mod-customizable way to vote whether to go. Singleplayer doesn't care about this because it's just one player.

## Mod API

There should be two different ways to interface with the mod's API, `object Terraria.ModLoader.Mod::Call(object[])` and a regular API. The former will just accept parameters that describe behaviors and other settings, as well as a \[potentially deprecated\] Subworld Library API mimic (does this still exist? John erroneously removed it under false pretenses a while ago and I am unsure it was ever added back).

What's most important is being able to define basic world features, such as its side and generation passes.
