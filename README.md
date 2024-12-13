# Metin2 Private Server Language Selector

This project is a **Language Selector** created for the Metin2 private server **Valkyrie**. The selector allows players to easily switch between multiple supported languages for the game client. The design is smooth, and the code is simple, making it highly customizable and user-friendly. A lot of people asked me for the sources of this after the shut down so here you are.

---

## Features

- **Supports 14 Languages**: 
  - English
  - Magyar
  - Čeština
  - Deutsch
  - Dansk
  - Español
  - Français
  - Ελληνικά (Ellinika)
  - Italiano
  - Holland (Dutch)
  - Polski
  - Português
  - Română
  - Русский (Russkiy)
  - Türkçe

- **Simple and Clean Code**: 
  - Easy to read and modify.
  - Ideal for adding or customizing supported languages.

- **Smooth Design**:
  - Built with an intuitive and visually appealing interface.

---

## How to Add a New Language

To add a new language, follow these steps:

1. Open the **form designer**.
2. Add a new language in the ComboBox:
    ```xml
    <ComboBoxItem Content="YourLanguageName" />
    ```
3. Update the corresponding locale code in the `switch` case logic:
    ```csharp
    case "yourlanguage":
        localeCode = "YourLocaleCode";
        break;
    ```
4. Make sure the locale code is correct and that the client supports the desired language.

---

## Locale Codes

Each language has its own locale code, which must be correctly configured in the game client. For example:

```csharp
case "english":
    localeCode = "10002 1252 en";
    break;

case "magyar":
    localeCode = "10021 1250 hu";
    break;

// Add more cases as needed... 
```
**Note: The client must support multilanguage functionality, and you should pre-install the language locale in your client before adding it to the selector**.

## Screenshots
![Language Selector Interface](http://i.epvpimg.com/oEOXaab.png)

