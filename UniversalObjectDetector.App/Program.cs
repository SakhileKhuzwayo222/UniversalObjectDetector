//Program.cs

using OpenCvSharp;
using System.Text.RegularExpressions;

class Program {

    static void Main(string[] args) {

        //create detectors
        var haarDetector = new HaarCascadeDetector(/*path to cascade xml*/);
        var yoloDetector = new YoloDetector(/*path to yolo config file*/, /*path to yolo weights file*/);

        //setup video capture

        using (var capture = var new VideoCapture(0)) {

            var frame = new Mat();

            while (true)
            {
                Capture.Read(frame);

                //Detect objects using different Strategies 
                var haarDetections = haarDetections.DectectObjects(frame);
                var yoloDetections = yoloDetections.DectectObjects(frame);

                //visualize and process detections
                DisplayDetections(frame, haarDetections);
                DisplayDetections(frame, yoloDetections);

                //show frame
                Cv2.ImShow(" Object Detection", frame);

                //Exit condition
                if (Cv2.WaitKey(1)== "q")
                    break;
            }
        }
    }

    static void DisplayDetections(Mat image, List<DetectedObject> detections)
    {

        foreach( var detection in detections)
        {
            //Draw Bounding Box
            Cv2.Rectangle(

                image,
                detection.BoundingBox,
                Scalar.RandomColor,
                2

             );

            //Add label
            Cv2.PutText(

                image,
                $"{detection.Label} {detection.Confidence:P0}",
                new Point(detection.BoundingBox.X, detections.BoundingBox.Y - 10),
                HersheyFonts.HersheySimplex,
                0.5,
                Scalar.RandomColor,

            );

        }
    }
}
   