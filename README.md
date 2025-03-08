# 🏗️ Havel-Hakimi Algorithm - بررسی توالی گرافیک




## 🌍 About the Project | درباره پروژه
This project implements the **Havel-Hakimi algorithm** in **C#** to determine whether a given degree sequence is **graphic** (i.e., can form a simple graph).

این پروژه **الگوریتم هاول-حکیمی** را در **C#** پیاده‌سازی می‌کند تا بررسی کند که آیا یک توالی درجه **گرافیک** است (آیا می‌تواند یک گراف ساده تشکیل دهد یا نه).

---

## 📌 Features | ویژگی‌ها
✅ Step-by-step visualization of the algorithm in the console  
✅ Colored messages for better readability  
✅ Modular design with a separate function for handling messages  
✅ Simple and interactive user input handling  

✅ نمایش مرحله به مرحله الگوریتم در کنسول  
✅ پیام‌های رنگی برای خوانایی بهتر  
✅ طراحی ماژولار با تابع جداگانه برای مدیریت پیام‌ها  
✅ دریافت ورودی از کاربر به صورت تعاملی  

---

## 🚀 Installation & Usage | نصب و اجرا
### 1️⃣ Clone the repository | دریافت پروژه
```bash
git clone https://github.com/MehradYaghoubi/HavelHakimiAlgorithm.git

📌 Example Input & Output | نمونه ورودی و خروجی
📝 Input | ورودی:
Please enter a degree sequence (e.g., 3,3,2,2,2,1):
3,2,2,2,1

📊 Output | خروجی:
Processing sequence: [ 3, 2, 2, 2, 1 ]
Step 1: [ 1, 1, 1, 1 ]
Step 2: [ 0, 1, 1 ]
Step 3: [ 1, 1 ]
Step 4: [ 0 ]

✅ SUCCESS: The sequence is graphic.
Final Result: The sequence is graphic because the last remaining node has a degree of zero.


⚙️ How It Works | نحوه کار
1️⃣ The user enters a degree sequence (e.g., 3,3,2,2,2,1).
2️⃣ The program sorts the sequence and applies the Havel-Hakimi algorithm.
3️⃣ The algorithm iteratively removes and modifies degrees, showing each step.
4️⃣ The final result determines whether the sequence is graphic or not.

1️⃣ کاربر یک توالی درجه وارد می‌کند (مثلاً 3,3,2,2,2,1).
2️⃣ برنامه توالی را مرتب کرده و الگوریتم هاول-حکیمی را اجرا می‌کند.
3️⃣ در هر مرحله، بزرگ‌ترین مقدار حذف و مقادیر بعدی تغییر داده می‌شوند.
4️⃣ در نهایت مشخص می‌شود که آیا توالی گرافیک است یا نه.



📝 License | مجوز
This project is licensed under the MIT License.

این پروژه تحت مجوز MIT منتشر شده است.

If you like this project, don't forget to ⭐ star the repository!


