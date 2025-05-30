# Selenium Form Automation Test

A robust C# Selenium WebDriver solution for automated testing of web forms with resilient element location strategies.

## 📋 Project Overview

This project demonstrates automated testing of the CloudQA Practice Form using Selenium WebDriver in C#. The solution is designed to remain functional even when HTML element properties or positions change, making it ideal for dynamic web applications.

## 🎯 Task Requirements

- Automate testing of any three form fields
- Ensure the solution works even if element positions or properties change
- Use C# and Selenium WebDriver
- Target URL: `https://app.cloudqa.io/home/AutomationPracticeForm`

## 🛠️ Technologies Used

- **Language**: C# (.NET 10.0)
- **Testing Framework**: Selenium WebDriver 4.15.0
- **Browser Driver**: Chrome WebDriver
- **IDE**: Visual Studio Code

## 🏗️ Project Structure

```
SeleniumTest/
├── bin/
├── obj/
├── Program.cs          # Main automation script
├── SeleniumTest.csproj # Project configuration
└── README.md          # Project documentation
```

## 🚀 Features

### Robust Element Location
- **Primary Strategy**: Direct ID targeting (`fname`, `lname`, `email`)
- **Fallback Strategy 1**: Name attribute matching
- **Fallback Strategy 2**: XPath and CSS selectors with semantic targeting

### Error Handling
- Graceful handling of missing or changed elements
- Continues execution even if individual elements fail
- Comprehensive console logging for debugging

### Form Fields Tested
1. **First Name** - Multiple location strategies including placeholder text matching
2. **Last Name** - Semantic targeting with surname/last name detection
3. **Email** - Type-based and placeholder-based element location

## 📦 Dependencies

```xml
<PackageReference Include="Selenium.WebDriver" Version="4.15.0" />
<PackageReference Include="Selenium.WebDriver.ChromeDriver" Version="119.0.6045.10500" />
<PackageReference Include="Selenium.Support" Version="4.15.0" />
```

## 🏃‍♂️ How to Run

### Prerequisites
- .NET 10.0 SDK installed
- Google Chrome browser
- ChromeDriver (automatically managed by Selenium.WebDriver.ChromeDriver package)

### Steps
1. **Clone the repository**
   ```bash
   git clone https://github.com/Avinashrkrk/CloudQA_Task.git
   cd SeleniumTest
   ```

2. **Restore packages**
   ```bash
   dotnet restore
   ```

3. **Run the automation**
   ```bash
   dotnet run
   ```

## 📊 Expected Output

```
🌐 Navigated to the form page
📋 Form loaded successfully

🔍 Testing First Name field...
✅ First Name filled successfully!

🔍 Testing Last Name field...
✅ Last Name filled successfully!

🔍 Testing Email field...
✅ Email filled successfully!

🔍 Validating form inputs...
✅ First Name validation passed: 'Avinash'
✅ Last Name validation passed: 'Pathak'
✅ Email validation passed: 'avinashpathak298@gmail.com'

🎉 All form fields tested and filled successfully!
```

## 🔧 Technical Approach

### Resilience Strategy
The automation uses a **cascading fallback approach**:

1. **Primary**: Target elements by their specific IDs
2. **Secondary**: Use name attributes and semantic selectors
3. **Tertiary**: Employ XPath and CSS selectors based on content/type

### Why This Approach Works
- **Position Independent**: Doesn't rely on element positioning
- **Attribute Flexible**: Multiple ways to locate the same element
- **Semantically Aware**: Uses meaningful attributes like input types and placeholder text
- **Maintainable**: Easy to add new location strategies

## 🧪 Test Data Used

- **First Name**: Avinash
- **Last Name**: Pathak
- **Email**: avinashpathak298@gmail.com

## 🤝 Contributing

This project was created as part of a CloudQA developer internship application. Feel free to suggest improvements or report issues.

## 📄 License

This project is created for educational and demonstration purposes.

---

*This automation solution demonstrates best practices in web testing with Selenium, focusing on maintainability and resilience to UI changes.*
