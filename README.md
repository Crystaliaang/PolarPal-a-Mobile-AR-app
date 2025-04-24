# POLAR_PAL
The application, named "PolAR Pal," features a 3D model penguin designed in Blender that interacts with the real-world environment and 3D objects through the AR camera functionality of Unity. It is an Augmented Reality application for iOS mobile devices using Unity and C# (ARkit and ARcore). 

The  AR application has successfully implemented key features suc as plane detection, visual target placement, and joystick controls, creating an engaging and interactive experience for users. These functionalities allow users to navigate and interact with the virtual penguin within their real-world surroundings, providing an immersive and enjoyable AR experience. The incorporation of the weather API integration further enhances the educational aspect of the application, allowing users to observe and learn about the penguin’s reactions to different weather conditions. This promotes an understanding of the importance of preserving
natural habitats and fosters a sense of environmental consciousness.


https://github.com/user-attachments/assets/f0515a74-585e-441a-b1e1-20aa2cb5bed5



The application includes the functionalities:

**- Plane Detection**: Upon selecting the "Play" option, users are immersed in the AR environment, where the application’s camera initiates the process of plane detection. Using advanced computer vision algorithms, the camera detects both horizontal and vertical planes in the real-world surroundings. This enables the application to identify suitable surfaces for placing the virtual objects. To enhance the integration of virtual and real environments, the appearance of the detected planes was modified. The shape and color of the planes were adjusted to achieve a more discrete and seamless blending with the real environment, while avoiding unnecessary occlusion.
Furthermore, colliders were implemented for both the vertical and horizontal planes, as well as for the penguin character, enabling
interactive functionality. These colliders ensure that the penguin interacts with the detected planes realistically, preventing it from passing through them and enhancing the overall sense of immersion and coherence in the AR experience.

**-Visual Target Placer**: Once the planes are successfully detected, a visual target appears on these surfaces to guide and indicate to the user where the penguin can be placed. The visual target serves as a helpful reference point for positioning the penguin within the AR environment. By tapping on the screen, the target disappears, and the penguin is precisely placed on the detected plane, always looking at the camera, seamlessly integrating it into the user’s surroundings.

**-Joystick**: To control the movement of the penguin, a user-friendly joystick interface is provided. Positioned as a blue disk with a white circle placeholder at the center bottom of the screen, the joystick allows users to navigate the penguin within the AR environment. By manipulating the joystick, users can move the penguin in various directions on the detected planes.

**- Weather Reactions**: To enhance PolAR Pal we integrated a weather API provided by https://www.weatherapi.com/. This integration allowed us to provide real-time weather information within the AR environment, adding an extra layer of interactivity and realism to the user experience. When users launch the application, they are presented with various weather-related details. This includes the real-time location, displaying the city and country information, as well as the current date and time. Additionally, the weather condition, such as sunny, cloudy, rainy, etc., and the corresponding temperature were also displayed.
Based on these weather parameters, a corresponding 3D weather object dynamically appeared within the AR environment through the device’s camera. The purpose of these weather objects was to simulate how a penguin would react in different weather conditions.
For example, when it is nighttime, a 3D moon object is displayed and the penguin would exhibit sleepy behavior, whereas, in hot weather, it would express discomfort. This added a touch of realism and allowed users to observe how real animals would react to various weather phenomena.
To further enhance the experience and add a bit of fun and fantasy, we went beyond simple weather objects. For instance, when it was raining, in addition to displaying a cloud and rain object in the AR environment, we also animated the penguin lifting up an umbrella, creating an amusing and engaging interaction.

**- Image Tracking**: Upon successful image recognition (in that case, the rejsekort was used), a virtual lake was placed automatically in the AR environment, and users were tasked with maneuvering the penguin character close to the lake. When the penguin was collided with the lake, the "Dive" button was enabled and by pressing it the penguin performed a captivating diving animation, creating a delightful conclusion to the user journey. This image-tracking feature showcased the application’s ability to merge virtual elements seamlessly with the real world, offering an engaging and interactive experience that highlighted the playful nature of the penguin character and added a sense of accomplishment to the user’s exploration.



https://github.com/user-attachments/assets/77b90857-df09-48ea-94e5-6487ccf08012



**- Light Estimation**: This feature has been implemented to simulate realistic lighting conditions and seamlessly integrate virtual
objects into the real world. It enables virtual objects to interact with the environment’s lighting, shadows, and reflections enhancing the overall visual quality and realism of the AR experience. Light estima- tion involves analyzing the real-world environment captured by the device’s camera and extracting lighting information from it. This information includes the intensity, color temperature, and direction of the ambient light in the scene. Additionally, the brightness is displayed in the user interface (UI), making it accessible for future use and potential developments.

**- Object and Human Occlusion**: The implementation of this feature allows the penguin to realistically interact with real-world objects, giving the illusion of depth and enhancing the overall realism of the AR experience. For instance, when the penguin is moved behind a real table, the occlusion feature ensures that the penguin is visually hidden when viewed from certain angles. This creates a more immersive and believable environment where virtual objects seamlessly coexist with the physical world. It’s important to note that this feature relies on LiDAR technology and is compatible with devices such as iPhones 12 Pro and later models, which provide enhanced depth sensing capabilities.

**- Simulation**:
The Simulation screen offered users the opportunity to simulate various weather conditions and observe the corresponding reactions
of the penguin character. Through a set of interactive buttons, including Dive, Hello, Rain, Lay, and Hot, users could trigger different weather conditions, each accompanied by the penguin’s distinct
reaction in the form of animated behavior. This simulation feature created a Wizard of Oz-like situation, enabling users to explore
and experience how the penguin character interacted with different weather phenomena, fostering a deeper understanding of the animal’s behavior and adding an element of fun and discovery to the user’s engagement with the application.


*This project was created with ME for a course. 


https://github.com/user-attachments/assets/4b35dfdd-8145-4171-ac05-b0b7a43a88f7



