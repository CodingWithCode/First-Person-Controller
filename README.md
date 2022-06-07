# First-Person-Controller


In order for this to work here is what you need to do:

1. Create a Empty. This is going to be out Character Movement Sytem controller.
2. Then, as a child object of the Empty we added, add a cylynder and a camera Remove the collider that the Cylynder already has and I will explain why in the next step. 
3. Now, add a "Character Controller" component to the Empty. Make sure you scale to fit in your cylynder. Make sure it is perfect because this is also going to act as our collider to our cylynder.
**Information about the Camer_Follow.cs script**
4. Add the "Camer_Follow.cs" file to the camera. For the public varables the "player" variable is where you put in the Empty we made earlier. The "sens" variable controls the mouse sensativty when you look around in your scene.
**nformation about the Camer_Follow.cs script**
5. Add the "Camer_Follow.cs" file to the Empty we made. For the pubic varable "speed" this controls the speed of our player. The "normalSpeed", "sprintSpeed", and "accelaration" variables are varable all having to do with sprinting in the controller.
