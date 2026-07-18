# Event Management System

A desktop-based Event Management System developed as an academic requirement for **ITEC 81 – Event-Driven Programming** during **Academic Year 2024–2025 (1st Semester)**.

The application allows administrators to manage events, organizers, students, and event feedback within an institution through a Windows Forms desktop application integrated with a MySQL database.

---

## 📖 Overview

The Event Management System is designed to streamline the management of institutional events by providing administrators with tools to organize events, register students, manage organizers, collect feedback, and monitor participation. It serves as a practical implementation of event-driven programming concepts using Visual Basic .NET.

---

## ✨ Features

- 🔐 User Authentication (Login & Signup)
- 📊 Dashboard Overview
- 👨‍🎓 Student Registration
- 📅 Event Creation and Management
- 👥 Organizer Management
- 🗂️ Event Categories
- 📝 Student Participation Tracking
- 💬 Feedback Collection
- 💾 MySQL Database Integration

---

## 🛠️ Technologies Used

- Visual Basic .NET (.NET 8 Windows Forms)
- MySQL
- XAMPP
- MySQL Connector/NET
- Visual Studio 2022
- Git
- GitHub

---

# 🗄️ Database Setup

The required database is already included in this repository.

### Database Location

```
Database/
└── event_management_db.sql
```

### Importing the Database

1. Start **Apache** and **MySQL** in XAMPP.
2. Open **phpMyAdmin**.
3. Click **Import**.
4. Select the following file:

```
Database/event_management_db.sql
```

5. Click **Go**.
6. Verify that the database name is:

```
event_management_db
```

---

### Default Connection String

The project is configured to use the following local database connection:

```vb
Server=127.0.0.1;
Database=event_management_db;
Uid=root;
Pwd=;
```

If your MySQL server uses different credentials, update the connection string inside:

```
Connection.vb
```

---

## 🚀 Installation

1. Clone the repository.

```bash
git clone https://github.com/Loblachii/event-management-system.git
```

2. Open the project in **Visual Studio 2022**.

3. Restore the NuGet packages.

4. Import the database located at:

```
Database/event_management_db.sql
```

5. Ensure XAMPP's **MySQL** service is running.

6. Build and run the project.

---

## 📁 Project Structure

```
EVENT MANAGEMENT SYSTEM
│
├── Database/
│   └── event_management_db.sql
│
├── My Project/
├── Dashboard.vb
├── EventCreation.vb
├── EventRecords.vb
├── OrganizerTracking.vb
├── StudentRegistration.vb
├── StudentParticipationTracking.vb
├── FeedbackCreation.vb
├── FeedbackCollection.vb
├── Connection.vb
├── Login.vb
├── Signup.vb
├── EVENT MANAGEMENT SYSTEM.vbproj
├── .gitignore
└── README.md
```

---

## 👤 User Role

- **Administrator**

---

## 👨‍💻 Developers

| Name | Role |
|------|------|
| **Jehuel A. Angcao** | Back-End Developer |
| **John Sean T. Bataclan** | UI/UX Designer, Front-End Developer |

---

## 📷 Screenshots

### Login

<img width="1314" height="591" alt="image" src="https://github.com/user-attachments/assets/13df915d-cca5-43af-b3b9-4d38993a4ba6" />


---

### Dashboard

<img width="1893" height="944" alt="image" src="https://github.com/user-attachments/assets/012aba83-7e9c-42af-917e-a3faef048fbf" />


---

### Event Creation

<img width="1894" height="943" alt="image" src="https://github.com/user-attachments/assets/3f5da3da-1282-47b5-94db-4bde7079833d" />


---

### Organizer Tracking

<img width="1892" height="941" alt="image" src="https://github.com/user-attachments/assets/52939008-898a-4c94-8c73-29abc41280e5" />


---

### Student Registration

<img width="1895" height="945" alt="image" src="https://github.com/user-attachments/assets/7dc8fb85-487c-4472-989e-b0d3f3e7f765" />


---

### Feedback Collection

<img width="1893" height="942" alt="image" src="https://github.com/user-attachments/assets/f9dcf1b7-6e5a-4340-bd59-9e2d9608539c" />


---

## 🔮 Future Improvements

- Multi-user support
- Role-based access control
- QR Code attendance system
- Email notifications
- Event attendance analytics
- Export reports to PDF/Excel
- Improved dashboard analytics

---

## 📄 License

This project was developed exclusively for **academic purposes** as a course requirement for **ITEC 81 – Event-Driven Programming**.

This repository is intended for educational reference only.

---

## 🙏 Acknowledgements

Developed as part of the **ITEC 81 – Event-Driven Programming** course during the **Academic Year 2024–2025, First Semester**.
