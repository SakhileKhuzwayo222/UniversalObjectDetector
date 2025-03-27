﻿# UniversalObjectDetector

# UniversalObjectDetector

## 📌 Project Description
**UniversalObjectDetector** is a powerful and flexible object detection framework that integrates multiple detection methods, including **Haar Cascades**, **YOLO (You Only Look Once)**, and **custom Machine Learning models**. It is designed to work with images and real-time video streams, providing accurate and efficient object detection capabilities.

This project is structured into three main components:
- **Core**: Defines object models, interfaces, and utility functions.
- **Detectors**: Implements multiple object detection strategies.
- **App**: A console application demonstrating real-time object detection.

## 🚀 Features
- 🔍 **Multi-Model Support**: Uses Haar Cascades, YOLO, and ML models for detection.
- 🎥 **Real-Time Detection**: Processes live video streams from webcams.
- 🖼 **Image Processing**: Supports image-based detection.
- ⚙️ **Modular Design**: Easy to extend with new detection models.
- 📂 **Configurable Resources**: Uses XML, model weights, and configuration files.

## 🏗️ Project Structure
```
UniversalObjectDetector/
├── UniversalObjectDetector.Core/
│   ├── Models/
│   │   ├── DetectedObject.cs
│   │   ├── ObjectCategory.cs
│   ├── Interfaces/
│   │   ├── IObjectDetector.cs
│   ├── Utilities/
│       ├── ImageProcessingHelpers.cs
│       ├── ConfigurationManager.cs
│
├── UniversalObjectDetector.Detectors/
│   ├── Implementations/
│   │   ├── HaarCascadeDetector.cs
│   │   ├── YOLODetector.cs
│   │   ├── MachineLearningDetector.cs
│   ├── Config/
│   │   ├── DetectorConfiguration.cs
│   ├── Utilities/
│       ├── DetectionHelpers.cs
│
├── UniversalObjectDetector.App/
│   ├── Program.cs
│
├── resources/
│   ├── cascades/
│   ├── models/
│   ├── training_images/
│   ├── config.json
│
└── README.md
```

## 📦 Dependencies
Install the following NuGet packages in each project:
```sh
OpenCvSharp4
OpenCvSharp4.runtime.win
System.Drawing.Common
```

## 🔧 Setup and Usage
### Clone the Repository
```sh
git clone https://github.com/your-username/UniversalObjectDetector.git
cd UniversalObjectDetector
```

### Build and Run
1. Open the project in Visual Studio.
2. Restore NuGet packages: `dotnet restore`
3. Run the console application:
   ```sh
   dotnet run --project UniversalObjectDetector.App
   ```

### Configuration
- Store Haar cascade XML files in `resources/cascades/`
- Store YOLO weights and config in `resources/models/`
- Modify `config.json` to switch detection methods

## 📜 License
This project is licensed under the **MIT License**.

## 🤝 Contributing
Contributions are welcome! Feel free to submit issues and pull requests.

## 📬 Contact
For any inquiries, reach out via [GitHub Issues](https://github.com/your-username/UniversalObjectDetector/issues).

