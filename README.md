# Cat Laser Project

A C# Windows Forms application that controls a cat laser toy mounted on two servo motors via Arduino over USB serial. Movements are programmed as X/Y servo angle pairs, stored in a list, and executed sequentially — keeping the cat busy so you don't have to.

## Features

- **Serial connection** to Arduino (configurable COM port, 9600 baud)
- **Live manual control** via two sliders (X and Y servo angles)
- **Movement list** — add, sort, clear, save, and load sequences of positions
- **Async execution** — steps through the movement list with a 500ms delay per position, highlighting the active step
- **Stop button** — halts execution mid-sequence
- **Random generation** — adds 10 random positions to the list in one click
- **File save/load** — export and import movement sequences as `.txt` files (CSV format)
- **Bubble sort** — sorts the movement list by X angle

## How It Works

The app sends commands to the Arduino in the format `X{angle}Y{angle}\n` over a serial port. The Arduino reads these and moves the two servos accordingly, repositioning the laser dot on the floor.

```
WinForms App  ──serial (USB)──▶  Arduino  ──PWM──▶  Servo X (horizontal)
                                                  └──PWM──▶  Servo Y (vertical)
```

Movements are stored as `Miscare` objects (Romanian for "movement") with `X` and `Y` integer properties representing servo angles in degrees.

## Controls

| Button | Action |
|--------|--------|
| Connect / Disconnect | Opens or closes the serial port to Arduino |
| Add | Saves current slider position to the movement list |
| Sort | Sorts the list by X angle (bubble sort) |
| Execute | Runs through the movement list asynchronously |
| Stop | Interrupts a running sequence |
| Random | Generates 10 random positions and adds them to the list |
| Clear | Empties the movement list |
| Save | Exports the movement list to a `.txt` file |
| Load | Imports a movement list from a `.txt` file |

## Requirements

- Windows (WinForms, .NET Framework)
- Visual Studio
- Arduino with two servo motors wired up and flashed with matching firmware

## Running

1. Open `CatLaserProiect1.sln` in Visual Studio
2. Build and run the project
3. Wire up the Arduino and note the COM port (e.g. `COM3`)
4. Enter the COM port in the text box and click **Connect**
5. Use the sliders to position the laser, then click **Add** to record the position
6. Click **Execute** to run the sequence

## Skills Demonstrated

- C# WinForms GUI development (event handlers, async/await, controls)
- Serial communication with hardware via `System.IO.Ports`
- Data structures — custom `Miscare` class, `List<T>`, bubble sort implementation
- File I/O — save and load CSV-formatted movement sequences
- Asynchronous UI with `async/await` and `Task.Delay` to keep the interface responsive during execution
