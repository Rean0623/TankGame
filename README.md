# TankGame

A tank battle game built solo over three months by a developer 
starting from zero programming experience — a complete journey 
from beginner to shipped game.

## Overview
A single-player tank battle game built in Unity, featuring combat, 
scoring, and a full settings system. This project marks my first 
complete game built after finishing a full C# curriculum and 
transitioning into Unity development.

## Features
- Player and enemy health bar system with a shield mechanic
- Weapon pickup system
- Camera follow
- Score and time tracking with a persistent leaderboard (PlayerPrefs-based)
- Game Clear / Game Over screens
- Settings panel with BGM/SFX volume sliders
- Cross-scene BGM persistence via a singleton SoundManager (DontDestroyOnLoad)
- Full UI built with Unity IMGUI

## Tech Stack
- Unity 6
- C#
- Rigidbody-based physics movement

## What I Learned
- Managing game state across scenes (score, settings, audio) using 
  singleton patterns
- Debugging real Unity-specific issues: race conditions on max HP, 
  self-damage tag bugs, Time.timeScale resets on retry, IMGUI 
  coordinate systems, and cursor lock behavior
- Incorporating senior developer feedback on physics-correct movement 
  (switching from Transform.Translate to Rigidbody.MovePosition/MoveRotation)

## Play
https://rean0623.itch.io/tankgame
