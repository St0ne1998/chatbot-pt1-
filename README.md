Amusement Lubisi

Student Number: st10500573

Institution: Rosebank College

Module: Part 1 Project / Coursework

CybersecurityBot (WEchat) - Project Documentation & Technical Report
1. Introduction & Project Overview
CybersecurityBot (also known as "WEchat") is a modular C# console application engineered to provide interactive cybersecurity guidance, threat mitigation tips, and automated conversational responses. Built utilizing a clean command-line interface, the project emphasizes structured object-oriented design, robust error handling, and extensible architecture.

2. System Architecture & Component Breakdown
The application follows a modular structure where specific responsibilities are cleanly separated across distinct class files:

Program.cs: Acts as the application entry point. It initializes the user interface, handles audio triggering, starts the chat engine, and incorporates top-level try-catch exception handling paired with a blocking terminal read to prevent premature closure.

BotUI.cs: Manages visual presentation by rendering clean ASCII art headers and formatting console output for the user.

AudioPlayer.cs: Handles programmatic audio execution, utilizing System.Media.SoundPlayer to load and play .wav voice greetings synchronously upon application launch.

ChatBotEngine.cs: Houses the core conversational loop, routing logic, and response generation rules for user interactions.

CybersecurityBot.csproj: The project configuration file defining target frameworks, C# language features, and Windows-specific desktop assembly references.

3. Technical Specifications & Configuration
To support native Windows API features—specifically audio playback through System.Media—the project is configured to target .NET 10.0 with Windows Forms integration enabled.

XML
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net10.0-windows</TargetFramework>
    <UseWindowsForms>true</UseWindowsForms>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
  </PropertyGroup>

</Project>
4. Execution & Environment Handling
Depending on the host environment and local security controls (such as Windows Application Control or AppLocker policies that restrict direct binary execution within user directories like source\repos), developers can run the application via multiple pathways:

Visual Studio IDE (Recommended for Windows): Opening the solution file (CybersecurityBot.sln) and pressing F5 invokes the built-in development debugging host, bypassing restricted binary launch policies.

Alternative Environments (Ubuntu / Linux): The codebase can be transferred to Linux environments running the .NET SDK (dotnet-sdk) and executed via dotnet run, ignoring Windows-specific audio wrappers safely through built-in exception blocks.

5. References & Documentation Guidelines
Microsoft .NET Documentation: C# Guide and Console Applications

System.Media Namespace Reference: SoundPlayer Class (System.Media)
