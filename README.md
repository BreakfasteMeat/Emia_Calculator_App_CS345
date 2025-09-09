# Emia Calculator App (CS345)

A simple Windows Forms calculator built with **C#**.  
This app supports basic arithmetic operations with a clean and minimal UI.

---

## ✨ Features
- ➕ **Basic Operations:** Addition, subtraction, multiplication (×), and division (÷)  
- ⌫ **Backspace:** Remove the last entered character  
- 🔢 **Decimal Support:** Prevents multiple decimals in a number  
- ⚠️ **Error Handling:** Displays `Error` for invalid expressions  
- 📜 **History-ready:** Expression is stored before evaluation (can be extended)  

---

## ⚙️ How It Works
- Input numbers and operators using on-screen buttons  
- Symbols `×` and `÷` are automatically converted to `*` and `/`  
- Expressions are evaluated using **`DataTable.Compute()`**  
- Invalid inputs (like divide by zero) show an error message  

---

## 🚀 Usage
1. Clone or download the repository  
2. Open the project in **Visual Studio**  
3. Build and run the application  
4. Click buttons to form expressions and press `=` to evaluate  
