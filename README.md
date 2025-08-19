# Flarpy Blorb

A simple Flappy Bird-style game built with Unity. This is my first ever thing with Unity!

## Features
- Bird movement and flapping
- Pipes that move and spawn at random heights
- Score increases when the bird passes through pipes
- Game over when the bird falls off the screen or collides with obstacles
- Prevents score increase after game over
- Bird cannot flap above the screen height ("bonks" at the top)

## How to Play
- Classic Flappy Birds.
- Press the spacebar to make the bird flap upwards
- Avoid hitting the pipes and the ground
- Try to score as many points as possible by passing through the gaps

## Setup
1. Open the project in Unity (recommended version: 2022.3 or later)
2. Make sure the Input System package is installed and set as active in Player Settings
3. Assign required references in the Inspector (e.g., Rigidbody2D, Logic_manager, etc.)
4. Press Play to start the game

## Project Structure
- `Assets/` - Contains all scripts, scenes, prefabs, and assets
- `bird_script.cs` - Controls bird movement and game over logic
- `Logic_manager.cs` - Handles scoring and game over UI
- `PipeMoveScript.cs` - Moves pipes across the screen
- `PipeSpawnScript.cs` - Spawns pipes at intervals
- `middleCollider.cs` - Detects when the bird passes through pipes for scoring

## Screenshots
### In-Game
![In-Game Screenshot](assets/ingame.png)

### Game Over Screen
![Game Over Screenshot](assets/gameover.png)

## License
This project is for educational and personal use. Feel free to modify and share!
