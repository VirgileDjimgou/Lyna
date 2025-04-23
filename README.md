
# 🚘 DriveGuide AR – Augmented Reality Assistant for Automotive User Support

**DriveGuide AR** is a hybrid AI-powered application that helps car users understand their vehicle’s interior using real-time object detection, enriched explanations (text/audio), and AR-based overlays.
This project is built for technicians, rental users, or drivers who want to learn about the cockpit, dashboard symbols, or control buttons **just by pointing their smartphone camera inside the car**.

## 🧠 Project Scope

DriveGuide AR combines:
- 📸 Real-time object detection inside a car (steering wheel, gear shift, dashboard symbols, etc.)
- 🧠 An AI engine (YOLOv8) to recognize these components from live video frames
- 💬 An explanation system that provides instant textual or audio feedback
- 🧩 Modular architecture: Flask (AI) + ASP.NET Core (API) + Vue 3 + Capacitor (mobile frontend)

## 🧩 Architecture Overview

[Vue 3 + Capacitor App] 
     ↓  (camera frame)
[Flask + YOLOv8 Detection API] 
     ↓  (object label)
[ASP.NET Core API + MongoDB] → Info bubble: text + audio + icon

## 🧱 Core Components

### 📱 Mobile Frontend (Vue 3 + Capacitor)
- Camera preview and frame capture
- Overlays with object labels + tooltips
- Audio playback (text-to-speech)
- Communication with Flask and ASP.NET Core APIs

### 🧠 AI Microservice (Flask + YOLOv8)
- Receives image frames from the client
- Runs object detection using a pre-trained YOLOv8 model
- Returns list of detected components and coordinates

### 🔧 Info API Backend (ASP.NET Core)
- Serves rich metadata (name, usage, audio, translations, etc.)
- Connects to a MongoDB or JSON-based store
- Manages endpoints for frontend use

## 🧰 Example Object Record (JSON)

```json
{
  "id": "gear_shift",
  "name": "Levier de vitesse",
  "descriptionShort": "Permet de changer les vitesses.",
  "descriptionLong": "Le levier permet de sélectionner les modes : Drive, Neutre, Recul, Parking.",
  "models": ["Mazda 3", "Toyota Corolla"],
  "audio": {
    "fr": "gear_shift_fr.mp3",
    "en": "gear_shift_en.mp3"
  },
  "icon": "gear.svg"
}

## 🧪 MVP Roadmap (April–May 2024)

### Week 1
- [x] Setup Vue 3 + Capacitor + Camera preview
- [x] Create YOLOv8 + Flask backend
- [ ] Implement object detection and API connection

### Week 2
- [ ] Build ASP.NET Core API + MongoDB connector
- [ ] Design data schema for in-car components
- [ ] Display overlays and labels on camera

### Week 3
- [ ] Add tooltip logic + proximity/zoom detection
- [ ] Integrate audio playback (Web Speech / Capacitor)

### Week 4
- [ ] Package as APK with Capacitor
- [ ] Dockerize Flask + ASP.NET Core backends
- [ ] Test with 2 real car models (Mazda, Toyota)

## 🛠 Technologies Used

- **Frontend**: Vue 3 + TypeScript + Capacitor + Three.js
- **AI Engine**: Python + Flask + YOLOv8
- **API Backend**: ASP.NET Core Web API
- **Database**: MongoDB (or static JSON dataset)
- **Packaging**: Docker + Docker Compose

## 💡 Potential Use Cases

- 🧰 Technician assistance on-site
- 🚗 Rental car quick onboarding
- 📘 Automotive education (demo mode)
- 👁️ AR-based dashboard diagnostic help

## 📸 Sneak Peek (coming soon…)

![preview](./docs/mockup-preview.jpg)

## 🤝 Contributors

- **Patrick** – Concept, architecture, and full-stack implementation  

## 📜 License

MIT License – Free to use, contribute, and expand under open innovation principles.
