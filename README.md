# 🏭 Industrial Simulator - Robot & CNC Cell (Vue.js + ASP.NET Core + MQTT + MongoDB)

Fabrik3D is a modern and modular industrial simulation platform that emulates a robotic production cell combining a robotic arm, a CNC machining center, and other connected modules.

It is built to help educators , student-engineers, engineers and integrators visualize, test, and optimize automation workflows without the need for real hardware.

Using cutting-edge web technologies like Vue.js, Three.js, and MQTT, SimuCore brings realistic 3D interaction, real-time messaging, and modular backends via ASP.NET Core and MongoDB — all designed to simulate a real-world smart factory.
This project is a web-based simulation platform for industrial cells combining a robotic arm and CNC machining center, connected through real-time MQTT messaging. It features an interactive 3D HMI for visualizing tasks and machine behavior using Vue.js + Three.js, backed by an ASP.NET Core API and MongoDB for data management.

---

## ✨ Key Features

- 🦾 Simulated robot arm with inverse kinematics
- 🛠 Simulated CNC machining module
- 🌐 MQTT-based communication between modules
- 🎮 Interactive HMI with Vue.js and Three.js
- 📡 Real-time WebSocket sync
- 🧠 Modular backend for jobs, parts, handlers and sensors
- 📊 Historical data tracking and performance logging

---

## 🧱 Technologies

- `ASP.NET Core` (C#) - backend API
- `Vue.js` (TypeScript) - frontend HMI
- `Three.js` - 3D visualization
- `MQTT` - real-time message bus
- `MongoDB` - data persistence
- `Docker` - containerization and deployability

---

## 📁 Project Structure

```
src/
├── client/             → Vue.js + Three.js frontend
├── server/             → ASP.NET Core backend API
├── mqtt-worker/        → MQTT message processor
├── sim-engine/         → Robot/CNC simulation logic
├── models/             → Core data types
├── data/               → JSON configs and seeds
└── shared/             → Shared utilities and types
```

---

## 🛣️ Roadmap

### ✅ Phase 1: MVP Core (Month 1)
- [x] Simulate robotic arm (6 DOF) with basic kinematics
- [x] Simulate CNC toolpath preview
- [x] Vue HMI with basic 3D scene (Fanuc + CNC)
- [x] MQTT messaging between frontend/backend/simulators
- [x] Job execution and result logging

### 🚧 Phase 2: Functional Extensions
- [ ] Add tool changing & gripping modules
- [ ] Integrate real-time sensor simulation (temp, vibration)
- [ ] Add workpiece state and live positioning
- [ ] User authentication and role-based access

### 🔮 Phase 3: Advanced Analytics & AI
- [ ] Predictive maintenance simulation
- [ ] Live production KPIs & optimization suggestions
- [ ] Multi-robot and multi-CNC cell

---

## 📌 Milestones

| Milestone | Description | Status |
|----------|-------------|--------|
| M1 | Project scaffolding and folder structure | ✅ Done |
| M2 | MQTT + REST backend + Mongo integration | ✅ Done |
| M3 | Robot and CNC simulators active | ✅ Done |
| M4 | Real-time HMI 3D visual feedback | 🚧 In progress |
| M5 | Tooling & extension system | ⏳ Planned |
| M6 | Predictive analysis module | ⏳ Planned |

---

## 🧑‍💻 How to Start

1. Clone the repository  
2. Run `docker-compose up`  
3. Access:
   - Frontend: http://localhost:5173
   - API: http://localhost:5000/api
4. Start developing 🚀

---

## 📬 Contributions

Feel free to fork this repo, suggest improvements, or contribute new modules!
