> **Important note**: This is the *BmSDK for Arkham Knight* repository.
>
> The scripthook is also available for [Batman: Arkham City](https://github.com/Team-BmSDK/BmSDK-AC).

<br />

<p align="center">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://github.com/user-attachments/assets/ab0b54fe-b851-4021-aaf4-c8e0a834f051">
    <img alt="BmSDK" width="600" src="https://github.com/user-attachments/assets/d5446cc2-16c8-4dd0-98fa-7248708d6c46">
  </picture>
</p>

<br />

<p align="center">
A powerful, easy-to-use scripting platform for Batman: Arkham Knight that lets you integrate custom C# code for gameplay mods and more.
</p>

<br />

<p align="center">
  <a href="./LICENSE.md">
    <img alt="MIT license" src="https://img.shields.io/badge/license-MIT-green.svg?style=for-the-badge" />
  </a>
  <a href="../../releases/latest">
    <img alt="Latest release" src="https://img.shields.io/github/v/release/Team-BmSDK/BmSDK-AK?style=for-the-badge" />
  </a>
  <a href="../../releases/latest">
    <img alt="Downloads" src="https://img.shields.io/github/downloads/Team-BmSDK/BmSDK-AK/total?style=for-the-badge" />
  </a>
  <a href="https://dotnet.microsoft.com/en-us/download/dotnet/10.0">
    <img alt=".NET 10" src="https://img.shields.io/badge/.NET-10.0-512bd4?style=for-the-badge" />
  </a>
  <a href="https://discord.com/invite/arkhamworkshop">
    <img alt="Community Discord" src="https://img.shields.io/discord/1218395254013558844?logo=discord&logoColor=E0E3FF&label=Community%20Discord&labelColor=5865F2&style=for-the-badge" />
  </a>
</p>

<hr />

<br />

Scripts get the same types, properties and functions the original developers worked with, plus life-cycle events *(e.g. tick and game enter)* and helpers on top. Below is an example mod that shows off some of BmSDK's capabilities:
<details> 
<summary>Example Script</summary>

```csharp
using BmSDK;
using BmSDK.BmGame;
using BmSDK.BmScript;

[Script]
public class DemoScript : Script
{
    public override void OnKeyDown(Keys key)
    {
        if (key != Keys.J) return;

        var player = Game.GetPlayerPawn();
        var population = Game.GetPopulationManager();

        // Spawn Joker combat enemy
        var define = Game.FindObject<RCharacterDefine>("MainCharacterDefines.Villain.JokerHealthy");
        var joker = population.SpawnPawn(
            RPawnVillainThug.StaticClass(),
            define,
            RCharacter_Thug.StaticClass(),
            player.Location
        );

        // Move Joker in front of the player
        var dir = player.Rotation.ToDirection() with { Z = 0 };
        joker.Move(dir * 100);
    }
}
```
</details>

Check out the [documentation](https://bmsdk.dev/docs) for more info!

## 🚀 Getting started
If you want to use mods, here's how you get set up:
1. Download [the latest installer](../../releases/latest/download/BmSDK-AK-Installer.exe) and run it.
2. Pick your Arkham Knight folder. Steam installations are detected automatically, and you can browse for one yourself if yours isn't listed.
3. Press **Install**, then start the game. Script mods go in your `BmGame\Scripts` folder as .cs files.

The installer isn't code-signed, so Windows SmartScreen may warn you the first time you run it. Choose "More info" → "Run anyway" to continue.

<details>
<summary>Installing manually instead</summary>

1. Download the `BmSDK-AK-*.zip` from the latest [release](../../releases/latest) and open it.
2. Inside you'll see two folders: `Binaries` and `BmGame`. Copy both to your game folder (likely `C:\Program Files (x86)\Steam\steamapps\common\Batman Arkham Knight`). There should already be 2 folders in there with the same names.
3. BmSDK is now installed! Script mods go in your `BmGame\Scripts` folder as .cs files.
</details>

Keep in mind that script mods can potentially harm your computer. Make sure you only download and install mods from trusted sources.

### ⚠️ Notice for Epic or GOG users:
Only Steam copies of Arkham Knight are supported currently. EGS/GOG support is being considered, but BmSDK unfortunately does not work on these platforms for the time being.

## 🧩 Setting Up for Mod Development
Follow these steps to set up your environment for building, running, and debugging script mods:
1. [Install BmSDK](#-getting-started)
2. Go to [visualstudio.microsoft.com/downloads](https://visualstudio.microsoft.com/thank-you-downloading-visual-studio/?sku=Community&channel=Stable) and run the Visual Studio Installer.
3. In the Visual Studio Installer, select "**.NET desktop development**" from the _Workloads_ tab.
4. Start Visual Studio and open the solution in `%GameDir%\BmGame\ScriptsDev`.
5. Write your code in any C# source file in `%GameDir%\BmGame\Scripts`.
6. Run your code by pressing **F5** in Visual Studio.
7. Follow the [docs](https://bmsdk.dev/docs/guides/first-mod/) to write your first script.

## 🛠️ Contributing
To get started contributing to BmSDK, see the docs for instructions: [Building from source](https://bmsdk.dev/docs/contributing/building/)

## 📋 Legal notice
BmSDK is published under the [MIT licence](LICENSE.md).

BmSDK is not associated with Warner Bros. Games or Rocksteady Studios. All product and company names are trademarks or registered trademarks of their respective holders. Use of these names does not imply any affiliation or endorsement by them.
