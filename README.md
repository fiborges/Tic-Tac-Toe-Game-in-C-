# Tic-Tac-Toe Game in C#

This project is a console-based implementation of the classic Tic-Tac-Toe game using C#. It also serves as a tutorial for beginners to understand the basics of C# programming, project setup, and execution.

## Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download/dotnet)
- [Visual Studio Code](https://code.visualstudio.com/)

## Setup Instructions

### Step 1: Install .NET SDK

Download and install the .NET SDK from the [official website](https://dotnet.microsoft.com/download/dotnet). This SDK includes the necessary tools to build and run C# applications.

### Step 2: Install Visual Studio Code

Download and install Visual Studio Code from the [official website](https://code.visualstudio.com/).

### Step 3: Install Required Extensions

Open Visual Studio Code and install the following extensions:
- **C#** (developed by Microsoft)

To install extensions:
1. Open Visual Studio Code.
2. Go to the Extensions view by clicking on the square icon in the sidebar or pressing `Cmd + Shift + X`.
3. Search for "C#" and click "Install".

### Step 4: Create a New Project

1. **Open Terminal in Visual Studio Code**:
   You can open the integrated terminal using `Ctrl + ` (backtick).
2. **Navigate to the directory where you want to create the project**:
   ```bash
   cd ~/Documents
    ```

## Create a new directory for the project:
```bash

mkdir TicTacToe
cd TicTacToe
```
## Create a new console project:
```bash

dotnet new console

```
### Step 5: Understanding the Project Structure
When you create a new console project, it generates a few files:

#### Program.cs: 
  This is the main file where you will write your code.

#### TicTacToe.csproj: 
  This is the project file that contains information about the project configuration.


### Step 7: Run the Project

##### Build the Project:
In the terminal of Visual Studio Code, navigate to the project directory (if not already there) and run:

```bash

dotnet build
```
##### Run the Project:
Still in the terminal of Visual Studio Code, run:

```bash

dotnet run

```
## Understanding the Code

### Main Function
The Main function is the entry point of a C# program. It contains the game loop which alternates between the two players until there is a winner or the game is a draw.

```csharp

static void Main(string[] args)
{
    // Game loop
}
```
### Variables

#### char[] arr: 
  Array representing the game board. Each cell contains either a number (initially), 'X', or 'O'.
#### int player: 
  Indicates the current player (1 or 2).
#### int choice: 
  Stores the player's choice of position.
#### int flag: 
  Indicates the state of the game (1 for win, -1 for draw, 0 for continue).
  
## Functions
#### Board(): 
  Function to display the current state of the game board.
#### CheckWin(): 
  Function to check if there is a winner or if the game is a draw.

## Basic C# Concepts
### Variables
Variables are used to store data. In this game, we use several variables to manage the game state.

### Arrays
An array is a collection of elements of the same type. Here, arr is an array that represents the game board.

### Functions
Functions are blocks of code that perform specific tasks. We define two functions, Board and CheckWin, to manage the game logic.

### Conditionals
Conditionals (if, else if, else) are used to perform different actions based on different conditions. We use them to check the game state and determine the winner.

### Loops
Loops (do-while) are used to execute a block of code repeatedly. In this game, the loop runs until there is a winner or a draw.

