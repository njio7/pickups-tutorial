# Pickups Tutorial

From the GameObject tab at the top of the screen, create a cube, plane and a cylinder.
 ![image](https://github.com/user-attachments/assets/1e61a4b6-e2bb-46f7-b6f1-c11820de13cf)

Make sure to rename the cylinder to "coin" so it's easier to identify in the hierachy.
Make the cylinder flat enough to resemble a coin shape and rotate it 90 degrees on the X axis.

You can choose to either use the capsule collider provided with the cylinder or delete the capsule collider and create a sphere collider under "Add Component".
For my demonstration, i will be deleting the capsule collider and replacing it with a sphere collider as it better fits the shape of the coin.

To make sure the collider for the coin isn't too big, you can turn the size of it down to 0.5. Also make sure that the "Is Trigger" box is ticked. This lets the "player" interact with the coin and initiate an action.

![image](https://github.com/user-attachments/assets/fbe10a6d-de7e-40a2-8ab0-846359c1943f)

After properly naming and creating your coin, drag it from the Hierachy (left of your screen) into the Assets folder (bottom of your screen). 
Your Assets folder should look like this if done propperly. The coin in your hierachy should also now be blue instead of white.

![image](https://github.com/user-attachments/assets/07a2bdf0-2da7-4f6a-ac34-cf721984e50e)

Doing this creates a "prefab". this allows us to have one version of the coin that we can freely place in our scene while being able to update each coin just by using the one in the assets folder.

There are now two ways to create more coins in the scene because we have created the "Coin" prefab. You can either drag them from the Asset folder into the Scene or you can use Ctrl+D to duplicate the coin that's already in the Scene and move it around.

Personally, it's easier to drag them into the scene using the coin prefab as it leaves little room for error and mistakes.

![image](https://github.com/user-attachments/assets/1b16780a-7245-4048-b4d6-4b0d360927a0)
For the demonstration, i will have my scene displayed like this, but you can move the coins and cube around however you want to.



Now we can move onto creating the scripts for the coins and player movment.

Create two scrpts. one called "Player" and one called "CoinScript". You can name them what you want but i will be naming them like so to make it easier to tell the diference from the coin object and the coin script.
After that, drag your Coin script onto your coin and your Player script onto the cube. When selecting your cube or coin, you should be able to see one script each in both objects, like so:

![image](https://github.com/user-attachments/assets/e9630234-ec1f-480a-a79f-df33a94dbcaf)
![image](https://github.com/user-attachments/assets/c8b6db61-8b4d-4f66-9d3b-c3ff84f074a2)


For the player code, we're going to use this code down below:
![image](https://github.com/user-attachments/assets/ecacdd75-d68e-4278-a61f-9f128795ea6e)

The goal for this tutorial is to understand how to create pickups and have the player interact with them, which is why i will only be giving a brief explanation of what it does below:

This code will allow you to move the cube left and right, along the X axis, using the arrow keys or A/D.
The line "UnityEngine.Input.GetAxis("Horizontal")" makes use of the default unity inputs and movment axis that are located in Edit (top right in the window) > Project Settings... > Input Manager.
Changing these will stop the code from working.
![image](https://github.com/user-attachments/assets/5e4241e0-46c5-4ddc-90f6-bd3f489cf3da)

To test if the cube moves left and right, press the play button at thte top of the Scene and wait for it to load. Once it does, press A/D or the left/right arrow keys. The cube should move.
If it does not, make sure to double check the inspector and the code for any erros or spelling mistakes.

Once the cube is able to move, we can then work on getting the coins to dissapear when the cube interacts with it because currently, you should be able to see the cube go through the coins and not do anything.
If anything unprompted is happening, try going through the code again to make sure things work.

Next, we need to give the cube a rigid body so it can interact with the coins. Normally, you can keep this option enabled, but for this example, you will most likely want to disable "Use Gravity" 
as it may cause the cube to be influenced by friction as it moves along the plane. this can sometimes cause unusual movments and we will most probably want to avoid them in this tutorial.


![image](https://github.com/user-attachments/assets/e23a9307-6b20-4ff5-9b0f-4686a5964686)

To test if things are working as intended, you can press play on the scene and move the cube into the coins. If it colides with the coins and doesn't go through, you may have forgotten to enable "Is Trigger" in the coin's Sphere Collider.
If the cube passes through the coins then things should be working correctly.

One last step before moving on is that you should make sure that the cube has the "Player" tag in the inspector as this will make referencing it in the unity engine a lot easier.

![image](https://github.com/user-attachments/assets/e338ca3a-17ff-4816-b980-96ddb3c02bf6)




Now we can work on getting the coins to detect when the cube has touched them. it is imprtant that one of our two objects have a rigidbody so that they can interact with eachother, but our cube already has one which makes things easier.

Firstly, create a script called, "pickup"
In this script, we will be creating an "OnTrigger" function that will check for a collision between the cube and the coins each frame.

The function bellow allows us to create an instance that will act on it's own seperately from "void start" and "void update".
![image](https://github.com/user-attachments/assets/30807305-e3e4-4200-bd86-c68d36f41936)

Inside our new functtion, you can put:

![image](https://github.com/user-attachments/assets/d113a379-f4ea-46f5-882e-89be7108742f)

Which will check for objects that pass through it with the "Player" tag on them. If an object touches thhe coin that does not have the "Player" tag, it will not interact with the coin and nothing will happen.

After this we are now able to make the coin vanish if we use:

![image](https://github.com/user-attachments/assets/3a075668-3828-4467-926b-ea3fe2a21af9)

Which simply destroys the coin from the scene and provides the visual confirmation of collecting the coin. "Destroy" meaning it get's deleted from the scene entirely.



The last step in the tutorial is to have some way to visually confirm the ammount of coins collected. This can be done in unity's debug console while the game is running.

to do this, we can first create a C# script called "GameManager". this will be our main code that stores the values and outcomes between interactions.

in our GameManager code, we can input the code bellow:

![image](https://github.com/user-attachments/assets/e06fabf3-c179-4540-a164-635bd811f44d)

this will create a public number value called "coins" that can be changed outside of the script. this value will appear in the console *during* the game's runtime.

![image](https://github.com/user-attachments/assets/41ee8bc1-31be-4486-b374-f2d8451fd085)


to test if it works, we can use this code below to make sure that the dev console is actually outputting a value.

![image](https://github.com/user-attachments/assets/e033b152-c849-4523-a9ea-0dda99351312)

"Jump" is being referenced here as the spacebar, meaning that all we have to to do to test the console output is to press the spacebar *while* the unity scene is running.

if the code works correctly, you should be able to press spacebar during the scene's runtime and it will output the number 0.

![image](https://github.com/user-attachments/assets/97a8b7f3-3ab0-43bc-8207-ccda28e63088)

If your console does not display anything then you might need to check that your unity setting are set as default otherwise this wont work.
Alternativly though, we can double check that this isn't a mistake in unity by actually checking for the player object collision with the coin.

In order to do this 




