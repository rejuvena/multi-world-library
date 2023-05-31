# Research

How are we going to make this?

## Singleplayer

In singleplayer, we can essentially just replace the `Main.tile` tilemap, but this leaves some disparities with multiplayer functionality.

## Multiplayer

In multiplayer, we can spawn additional server processes -- there is notable memory overhead in this approach, though. The client remains unchanged and should just connect to spawned server processes.
