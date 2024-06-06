# Unity Hangman Game

## Overview
This is a simple Hangman game implemented in Unity using the Unity UI system. The game is designed with modularity and extensibility in mind, allowing easy modifications and additions to game logic and UI.

## Project Structure
- **GameManager**: Controls the game flow and checks for game over conditions.
- **LetterInput**: Handles input from the user, either by clicking a button or pressing Enter.
- **LetterWordCheck**: Checks if the guessed letter or word is correct and updates the game state accordingly.
- **ManHealth**: Manages the player's health and triggers updates when health changes.
- **WordGeneration**: Randomly selects a word from a predefined list of words.
- **FullEntryHandler**: Handles the scenario when the user submits a full word guess.
- **UIManager**: Updates the UI elements based on the game state, including guessed letters, bad letters, and unused letters.

## Installation

1. **Clone the Repository**
    ```bash
    git clone https://github.com/yourusername/unity-hangman-game.git
    ```
2. **Open in Unity**
    - Open Unity Hub.
    - Add the cloned project to your projects.
    - Open the project.

## Setup

1. **Scene Setup**
    - Create a new scene or use an existing one.
    - Create the required UI elements: `InputField`, `Button`, `Text`, and `Image`.
    - Link these elements to the respective scripts via the Unity Inspector.

2. **Script Components**
    - Attach the `GameManager`, `LetterInput`, `LetterWordCheck`, `ManHealth`, `WordGeneration`, `FullEntryHandler`, and `UIManager` scripts to appropriate GameObjects.
    - Set up references in the Unity Inspector for each script to the corresponding UI elements and other script components.

3. **UI Configuration**
    - Configure the `TMP_Text` fields for `letterFields`, `badLettersField`, and `unusedLettersField` in the `UIManager`.
    - Configure the `Image` components for `manImages` in the `UIManager`.

## Usage

- **Starting the Game**: The game starts automatically when the scene is loaded. The `WordGeneration` class selects a random word, and the UI is initialized.
- **Input**: The player can input a letter or a full word guess using the provided input field and submit button.
- **Game Loop**: The `GameManager` manages the game loop, checking if the guessed letters or words are correct and updating the UI and health accordingly.
- **Game Over and Victory**: The game checks for game over or victory conditions and displays the appropriate UI messages.

## Classes and Methods

### GameManager

- **Start**: Initializes the game components.
- **CheckGameOver**: Checks if the game is over or if the player has won.

### LetterInput

- **OnSubmit(string input)**: Handles the submission of input from the user.
- **OnSubmit()**: Overload to handle button click submissions.

### LetterWordCheck

- **CheckLetter(char letter)**: Checks if the letter is in the current word and updates the game state.
- **IsWordGuessed**: Checks if the entire word has been guessed.

### ManHealth

- **InitializeHealth**: Initializes the player's health.
- **DecrementHealth**: Decreases the player's health.
- **IsDead**: Checks if the player's health is zero.

### WordGeneration

- **GenerateWord**: Randomly selects a word from the predefined list.

### FullEntryHandler

- **HandleFullGuess(string guess)**: Handles the submission of a full word guess.

### UIManager

- **InitializeUI**: Initializes the UI elements.
- **UpdateGuessedLetters(char letter, List<int> positions)**: Updates the UI for correct letters.
- **UpdateBadLetters(char letter)**: Updates the UI for incorrect letters.
- **UpdateBadLetters(string word)**: Updates the UI for an incorrect word guess.
- **ShowGameOver**: Displays the game over message.
- **ShowVictory**: Displays the victory message.
- **UpdateManImage(int health)**: Updates the hangman images based on the current health.

## Contributing

Contributions are welcome! Please feel free to submit a pull request or open an issue to discuss your ideas.

## License

This project is licensed under the MIT License.
