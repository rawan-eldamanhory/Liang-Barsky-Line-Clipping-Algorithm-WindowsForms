# Liang–Barsky Line Clipping Algorithm

This project demonstrates the **Liang–Barsky Line Clipping Algorithm** using **C# Windows Forms**.

## 📐 Algorithm Overview
The Liang–Barsky algorithm is an efficient line clipping algorithm that uses
parametric equations and inequalities to determine the visible portion of a line
within a rectangular clipping window.

Compared to Cohen–Sutherland, it performs fewer calculations and avoids repeated intersection tests.

## 🧮 Mathematical Concept
A line is represented parametrically as:

P(t) = P₁ + t(P₂ − P₁), where 0 ≤ t ≤ 1

The algorithm calculates:
- `tE`: entering point
- `tL`: leaving point

## 🎨 Visualization
- **Blue line**: original line
- **Black rectangle**: clipping window
- **Red line**: clipped line segment

## 🛠 Technologies
- C#
- Windows Forms
- GDI+

## ▶️ How to Run
1. Open the solution file in Visual Studio
2. Build and run the project
3. Observe how the line is clipped within the rectangle

## 🎓 Educational Purpose
This project is designed for learning computer graphics algorithms,
line clipping techniques, and parametric geometry.
