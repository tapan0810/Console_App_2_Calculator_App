# 🧮 Advanced Console Calculator

A clean, extensible, and robust **console-based calculator application** built using **C# and .NET**.  
This project demonstrates how to design even a simple utility using **production-grade coding practices**, including input validation, error handling, and scalable architecture.

---

## 📌 Overview

This calculator goes beyond basic implementations by focusing on:

- Maintainable and modular code structure
- Extensible operation handling (Strategy-based approach)
- Robust input validation and exception management
- Interactive command-line experience

---

## 🚀 Features

- 🔢 Supports multiple operations:
  - Addition (`add`)
  - Subtraction (`sub`)
  - Multiplication (`mul`)
  - Division (`div`)
  - Modulo (`mod`)
  - Power (`pow`)

- 🧠 Uses **Dictionary + Delegates (`Func<>`)** for operation mapping  
- ✅ Input validation using `double.TryParse()`  
- ⚠️ Handles runtime errors (e.g., divide by zero) gracefully  
- 🔁 Continuous loop for multiple calculations  
- 🎯 Clean separation of responsibilities  

---

## 🏗️ Tech Stack

| Category        | Technology        |
|----------------|------------------|
| Language       | C#               |
| Framework      | .NET (6.0+)      |
| Type           | Console App      |
| Concepts Used  | Delegates, Collections, Exception Handling |

---

## 📂 Project Structure
Calculator/
│
├── Program.cs # Entry point & orchestration
├── Calculator.csproj # Project configuration


---

## ⚙️ How It Works

1. User inputs two numbers  
2. Selects an operation (`add`, `sub`, etc.)  
3. Application validates input  
4. Executes operation using mapped function  
5. Displays result  
6. Prompts user for next calculation  

---

## 🧪 Sample Execution

---

## ▶️ Getting Started

### Prerequisites

- Install [.NET SDK 6.0 or later](https://dotnet.microsoft.com/download)

---

### Run Locally

```bash
# Clone the repository
git clone https://github.com/your-username/advanced-calculator.git

# Navigate into project folder
cd advanced-calculator

# Run the application
dotnet run
