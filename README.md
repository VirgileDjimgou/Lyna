# 🛠️ Fabrik3D Lite - Educational Industrial Simulator (Vue.js + ASP.NET Core + MQTT)

Fabrik3D Lite is a lightweight and educational-focused **industrial cell simulator** that combines:
- A robotic arm with simple predefined movements
- A CNC toolpath simulator based on basic G-code
- An interactive 3D interface with Vue.js and Three.js
- A backend built with ASP.NET Core and MQTT messaging

---

## 🎯 Project Scope (Simplified)

The goal is **not** to replicate real industrial complexity, but to:
- Visualize robotic and CNC actions in a simulated factory
- Learn about automation flows and message-based control
- Create an extendable, modular base for training or prototyping

---

## 🧩 Core Modules

### Frontend (Vue.js + Three.js)
- 📦 `3DRenderer` — Visual scene renderer
- 🎮 `ControlPanel` — HMI control for launching jobs
- 🦾 `RobotAnimator` — Animates arm from position list (no real IK)
- 🛠 `CNCAnimator` — Executes and shows linear G-code toolpaths
- 🔌 `FrontendMQTTHandler` — Listens for MQTT messages

### Backend (ASP.NET Core)
- 🧠 `JobRunner` — Reads JSON job definitions and sends MQTT commands
- 🌐 `RestApi` — Launch jobs and expose system status
- 💬 `MQTTPublisher` — Publishes minimal robot/CNC actions
- 📚 `MongoDbGateway` — Saves job history and logs

### Simulated Execution Services
- 🤖 `SimRobotExec` — Interprets robot move commands
- ⚙️ `SimCNCExec` — Parses and executes G-code lines

---

## 📦 Project Structure

```
fabrik3d-lite/
├── Simulator.Client/           → Vue.js + Three.js HMI
│   └── components/RobotAnimator.vue, CNCAnimator.vue
├── Simulator.Api/              → ASP.NET Core backend
│   └── Controllers/SimulationController.cs
├── Simulator.Models/           → JSON data models
│   └── JobDefinition.cs, ToolpathLine.cs
├── Simulator.MqttWorker/       → MQTT message handler
│   └── RobotMoveHandler.cs
├── Simulator.SimEngine/        → Execution logic
│   └── TrajectoryPlayer.cs, ToolpathPlayer.cs
├── Simulator.Shared/           → Constants, enums, etc.
└── MongoDB/                    → Seeded simulation data
```

---

## 🚀 MVP Implementation Plan (4 Weeks)

### Week 1
- [x] Build project structure and components
- [x] Setup 3D scene and load robot/CNC models
- [x] Implement MQTT basic publishing/subscription

### Week 2
- [x] Define a simple job runner (with hardcoded sequences)
- [x] Build RobotAnimator + CNCAnimator (from JSON input)
- [x] Display simulation status in UI

### Week 3
- [ ] Store job history and simulation logs in MongoDB
- [ ] Implement job selector with progress feedback

### Week 4
- [ ] Polish UI/UX (HMI), add manual overrides
- [ ] Deploy backend with Docker

---

## 📚 Example Simulation Flow

1. User clicks “Launch Job A” in HMI
2. `JobRunner` reads JSON and sends MQTT messages like:
   ```json
   { "topic": "robot/move", "data": [{ "x": 100, "y": 0, "z": 150 }] }
   ```
3. MQTT worker and frontend receive and animate accordingly
4. MongoDB logs movement history

---

## 🔗 Technologies
- Vue 3 + TypeScript + Three.js
- ASP.NET Core + C#
- MQTT (via Mosquitto or HiveMQ)
- MongoDB
- Docker (optional deployment)

---

## 💡 Use Cases
- 📘 Robotics training
- 🧪 Testing automation flows
- 🏫 Educational demos for students
