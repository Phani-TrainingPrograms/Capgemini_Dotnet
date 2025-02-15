---

### **2. Writing a Simple Test with Setup**
✅ **Task:**  
- Create a `Calculator` class with an `Add(int a, int b)` method.  
- Write an NUnit test class where:  
  - The test setup initializes the `Calculator` instance.
  - The test verifies that `Add(3, 5)` returns `8`.  

📌 **Hint:** Use `[SetUp]` to initialize objects before each test.  

---

### **3. Using TestCase for Parameterized Tests**
✅ **Task:**  
- Modify your `Calculator` class to include a `Multiply(int a, int b)` method.  
- Write a **parameterized test** using `[TestCase]` to test:  
  - `2 * 3 = 6`  
  - `-1 * 5 = -5`  
  - `0 * 10 = 0`  

📌 **Hint:** Use `[TestCase(x, y, expected)]`  

---

### **4. Handling Exceptions in NUnit**
✅ **Task:**  
- Add a `Divide(int a, int b)` method in `Calculator` that throws a `DivideByZeroException` if `b == 0`.  
- Write a test to **check if an exception is thrown** when `Divide(10, 0)` is called.  

📌 **Hint:** Use `Assert.Throws<DivideByZeroException>(() => calculator.Divide(10, 0));`  

---

## **🔹 Intermediate NUnit Practice Questions**
### **5. Testing Private Methods Using Reflection**
✅ **Task:**  
- Create a class `SecretManager` with a **private** method `_GetSecretKey()` that returns `"SuperSecret"`.  
- Write a test to **access and verify** this private method using **reflection**.  

📌 **Hint:** Use `typeof(ClassName).GetMethod("_MethodName", BindingFlags.NonPublic | BindingFlags.Instance)`  

---

### **6. Mocking Dependencies Using Moq**
✅ **Task:**  
- Create an `IEmailService` interface with a method `SendEmail(string email, string message)`.  
- Implement a `NotificationService` class that calls `SendEmail()`.  
- Use **Moq** to test if `SendEmail()` is **called exactly once** when `NotifyUser()` is called.  

📌 **Hint:** Use `mock.Verify(m => m.MethodName(), Times.Once);`  

---

### **7. Data-Driven Testing with TestCaseSource**
✅ **Task:**  
- Create a method `IsPrime(int number)` that checks if a number is prime.  
- Use `TestCaseSource` to pass multiple test cases (e.g., `2 → True`, `4 → False`, `5 → True`).  

📌 **Hint:** Use a **separate method** to supply test cases using `IEnumerable<TestCaseData>`  

---

### **8. Testing Asynchronous Methods**
✅ **Task:**  
- Create an async method `FetchData()` that simulates fetching data using `await Task.Delay(2000)`.  
- Write an NUnit test to **await the result** and verify if it returns `"Data Loaded"`.  

📌 **Hint:** Use `await` inside the test and `[Test] public async Task MethodName()`  

---

## **🔹 Advanced NUnit Practice Questions**
### **9. Parallel Test Execution**
✅ **Task:**  
- Create a test suite with **multiple tests** that run in parallel.  
- Ensure that each test runs independently without affecting others.  

📌 **Hint:** Use `[Parallelizable(ParallelScope.All)]` at the **class or test method level**.  

---

### **10. Testing Performance with Timeout**
✅ **Task:**  
- Create a `SlowProcess` class with a method that **sleeps for 5 seconds** before returning `"Done"`.  
- Write an NUnit test that **fails if execution takes longer than 3 seconds**.  

📌 **Hint:** Use `[Test, Timeout(3000)]`  
