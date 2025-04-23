# 🚘 DriveGuide AR – Augmented Reality Assistant for In-Car Intelligence

**DriveGuide AR** is a hybrid AI-powered assistant designed to help users identify and understand the components inside a vehicle using their smartphone camera. By leveraging real-time object detection and an augmented reality overlay, DriveGuide AR provides instant feedback about dashboard symbols, control buttons, and cockpit elements — making car interaction intuitive for everyone.


## 🎯 Project Overview

DriveGuide AR combines:

- 📸 Real-time detection of interior car elements (steering wheel, gear shift, AC, warning lights, etc.)
- 🧠 AI-powered backend (YOLOv8) to identify visual components from live camera input
- 💬 Enriched information displayed via tooltips and audio hints (text-to-speech)
- 🧩 Modular hybrid architecture with **Flask (AI)**, **ASP.NET Core (API)**, and **Vue 3 + Capacitor (Frontend)**


## 🧠 Architecture Overview

```plaintext
[Vue 3 + Capacitor Mobile App]
       ↓ (camera frame)
[Flask + YOLOv8 Detection API]
       ↓ (detected object labels)
[ASP.NET Core API + MongoDB]
       ↓ (descriptive metadata, audio, icons)
[Augmented Reality Overlay + TTS Output]
```


## 🧩 Core Modules

### 📱 Mobile App (Vue 3 + Capacitor)
- Live camera feed
- Frame capture and API calls
- 2D/3D overlays (labels + tooltips)
- Audio output via Web Speech API or Capacitor plugin

### 🧠 AI Detection (Flask + YOLOv8)
- Receives camera frames (JPEG)
- Runs YOLOv8 inference
- Returns bounding boxes + class labels

### 🧰 Metadata API (ASP.NET Core)
- Exposes detailed metadata for detected objects
- Handles multilingual text and audio support
- Connects to MongoDB or serves from enriched JSON


## 📦 Example Object Metadata

```json
{
  "id": "gear_shift",
  "name": "Levier de vitesse",
  "descriptionShort": "Permet de changer les vitesses.",
  "descriptionLong": "Ce levier permet de sélectionner les modes de conduite : D, N, R, P. Certains modèles permettent un mode manuel ou sport.",
  "models": ["Mazda 3", "Toyota Corolla"],
  "icon": "gear.svg",
  "audio": {
    "fr": "gear_shift_fr.mp3",
    "en": "gear_shift_en.mp3"
  }
}
```

## 📂 Folder Structure

driveguide-ar/
├── client-app/           # Vue 3 + Capacitor mobile frontend
├── backend-ai/           # Flask + YOLOv8 inference API
├── backend-core/         # ASP.NET Core API (data + metadata)
├── shared-data/          # JSON, icons, audio resources
├── docker-compose.yml    # Docker orchestration for all services
└── README.md             # Project documentation


## 🚀 MVP Roadmap

| Week | Deliverables                                                                 |
|------|------------------------------------------------------------------------------|
| 1    | Vue + Capacitor app with live camera preview                                 |
| 2    | Flask backend with YOLOv8 model and /detect endpoint                         |
| 3    | ASP.NET Core API with enriched vehicle metadata                              |
| 4    | Integration, audio playback, packaging as APK                                |
