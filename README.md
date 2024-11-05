# pickups tutorial

from the GameObject tab at the top of the screen, create a cube, plane and a cylinder.
 ![image](https://github.com/user-attachments/assets/1e61a4b6-e2bb-46f7-b6f1-c11820de13cf)

make sure to rename the cylinder to "coin" so it's easier to identify in the hierachy.
make the cylinder flat enough to resemble a coin shape and rotate it 90 degrees on the X axis.

you can choose to either use the capsule collider provided with the cylinder or delete the capsule collider and create a sphere collider under "Add Component".
to make sure the collider for the coin isn't too big, you can turn the size of it down to 0.5. also make sure that the "Is Trigger" box is ticked. this lets the "player" interact with the coin and initiate an action.
![image](https://github.com/user-attachments/assets/fbe10a6d-de7e-40a2-8ab0-846359c1943f)

after properly naming and creating your coin, drag it from the Hierachy (left of your screen) into the Assets folder (bottom of your screen). 
your Assets folder should look like this if done propperly. the coin in your hierachy should also now be blue instead of white.

![image](https://github.com/user-attachments/assets/07a2bdf0-2da7-4f6a-ac34-cf721984e50e)

doing this creates a "prefab". this allows us to have one version of the coin that we can freely place in our scene while being able to update each coin just by using the one in the assets folder.

there are now two ways to create more coins in the scene because we have created the "Coin" prefab. you can either drag them from the Asset folder into the Scene or you can use Ctrl+D to duplicate the coin that's already in the Scene and move it around.

![image](https://github.com/user-attachments/assets/1b16780a-7245-4048-b4d6-4b0d360927a0)
i will personally have my scene displayed like this, but you can move the coins and cube around however you want to.



now we can move onto creating the scripts for the coins and player movment.

create two scrpts. one called "Player" and one called "CoinScript". you can name them what you want but i will be naming them like so to make it easier to tell the diference from the coin object and the coin script.
after that, drag your Coin script onto your coin and your Player script onto the cube. when selecting your cube or coin, you should be able to see one script each in both objects, like so:

![image](https://github.com/user-attachments/assets/e9630234-ec1f-480a-a79f-df33a94dbcaf)
![image](https://github.com/user-attachments/assets/c8b6db61-8b4d-4f66-9d3b-c3ff84f074a2)


for the player code, we're going to use this code down below:
![image](https://github.com/user-attachments/assets/ecacdd75-d68e-4278-a61f-9f128795ea6e)

the goal for this tutorial is to understand how to create pickups and have the player interact with them, which is why i will only be giving a brief explanation of what it does below:

this code will allow you to move the cube left and right, along the X axis, using the arrow keys or A/D.
the line "UnityEngine.Input.GetAxis("Horizontal")" makes use of the default unity inputs and movment axis that are located in Edit (top right in the window) > Project Settings... > Input Manager.
changing these will stop the code from working.
![image](https://github.com/user-attachments/assets/5e4241e0-46c5-4ddc-90f6-bd3f489cf3da)

to test if the cube moves left and right, press the play button at thte top of the Scene and wait for it to load. once it does, press A/D or the left/right arrow keys. the cube should move.
if it does not, make sure to double check the inspector and the code for any erros or spelling mistakes.

once the cube is able to move, we can then work on getting the coins to dissapear when the cube interacts with it because currently, you should be able to see the cube go through the coins and not do anything.
if anything strage is happening, try going through the code again to make sure things work.

next, we need to give the cube a rigid body so it can interact with the coins. for this example, you will most likely want to disable "Use Gravity" as it may cause the cube to be influenced by fricttion as it moves along the plane.
![image](https://github.com/user-attachments/assets/e23a9307-6b20-4ff5-9b0f-4686a5964686)

to test if things are working as intended, you can press play on the scene and move the cube into the coins. if it colides with the coins and doesn't go through, you may have forgotten to enable "Is Trigger" in the coin's Sphere Collider.
if the cube passes through the coins then things should be working correctly.

one last step before moving on is that you should make sure that the cube has the "Player" tag in the inspector as this will make referencing it in the unity engine a lot easier.

![image](https://github.com/user-attachments/assets/e338ca3a-17ff-4816-b980-96ddb3c02bf6)




now we can work on getting the coins to detect when the cube has touched them. it is imprtant that one of our two objects have a rigidbody so that they can interact with eachother, but our cube already has one which makes things easier.

firstly, create a script called, "pickup"
in this script, we will be creating an "OnTrigger" function that will check for a collision between the cube and the coins each frame.

the function bellow allows us to create an instance that will act on it's own seperately from "void start" and "void update".
![image](https://github.com/user-attachments/assets/30807305-e3e4-4200-bd86-c68d36f41936)

inside our new functtion, you can put:

![image](https://github.com/user-attachments/assets/d113a379-f4ea-46f5-882e-89be7108742f)

which will check for objects that pass through it with the "Player" tag on them. if an object touches thhe coin that does not have the "Player" tag, it will not interact with the coin and nothing will happen.

after this we are now able to make the coin vanish if we use:

![image](https://github.com/user-attachments/assets/3a075668-3828-4467-926b-ea3fe2a21af9)

which simply destroys the coin from the scene and provides the visual confirmation of collecting the coin. "destroy" meaning it get's deleted from the scene entirely.






to go a bit further with this and confirm that the coin are being collected

