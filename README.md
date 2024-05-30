# Personal Brand Cards Enhancer
Personal Brand Cards Enhancer is an augmented reality (AR) application that enhances personal branding cards by displaying additional social media links and contact information in real-time when viewed through a camera. This app is designed to provide an interactive and informative experience, allowing users to easily access relevant information about individuals.

## Features
- Customizable Information: Easily update the social media links and contact information shown for each card.
- AR Metadata Overlay: Detects personal branding cards and displays associated metadata next to them. (Requires internet)

## Installation
### Prerequisites
- Unity Editor version 2022.3.*
- Vuforia Engine installed and configured in Unity
- Android SDK installed
- Supported Devices: Android

# Had Issues Setting Up The Project in GitHub
.. so here is a more visual look at the configurations and setup ⏬

### This Is The Final View That Your Personal Card Will Get After Applying Our AR
![personal-brand-card-with-effects](https://github.com/KonstantinMB/personal-brand-cards-enhancer/assets/76811860/6dc2c813-5210-475c-ad55-0f95ff036d28)

### The Configurations of the Main Panel ⬇️
![main-card-panel-configs](https://github.com/KonstantinMB/personal-brand-cards-enhancer/assets/76811860/f2456720-25a0-4e04-8fed-5e88ff382a83)

### The Configurations of the Separate Elements (Unity Materials)
![element-configurations](https://github.com/KonstantinMB/personal-brand-cards-enhancer/assets/76811860/ba891a5a-4e77-48c6-b297-68936922eacd)

### You Can Find the Source Code That Handles MouseClicks And Screen Touch Activities;
```c-sharp
\Assets\Scripts\
```

## 💻 Setup
### Clone the Repository:
```bash
git clone https://github.com/yourusername/personal-brand-cards-enhancer.git
cd personal-brand-cards-enhancer
```

### Open the project in Unity:

- Open Unity Hub.
- Click Add and select the cloned project directory.
- Open the project with Unity Editor version 2022.3.*

### Import Vuforia Engine:

- Download Vuforia Engine package from the Vuforia Developer Portal.
- In Unity, go to Assets > Import Package > Custom Package and import the Vuforia Engine package.

### Configure Vuforia:

- Go to Edit > Project Settings > XR Plug-in Management and enable Vuforia.
- Go to Window > Vuforia Configuration and enter your Vuforia license key.

### Set Up AR Scene:

- Create a new Scene or use the default one.
- Delete the Main Camera from the Scene.
- Add an AR Camera from Vuforia in the Hierarchy.
- Add an Image Target and set up with a reference image of the personal branding card.

### Add Metadata Display:

- Create a UI Canvas to display metadata.
- Add UI elements (Text, Image) to the Canvas for displaying phone number, LinkedIn, email, personal website, and Instagram.
- Create a script (MetadataDisplay.cs) to handle metadata retrieval and display, and attach it to the Image Target.

## Usage
### Build and Run the Application:

- Connect your Android device via USB and enable USB debugging.
- Go to File > Build Settings.
- Select Android and click Switch Platform.
- Add the current scene to the build by clicking Add Open Scenes.
- Click Build and Run to build the APK and install it on your device.
  
🎊 Point your camera at a personal branding card to see the AR overlay with additional social media links and contact information. 🎉

Development
