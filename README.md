# pickups tutorial

from the GameObject tab at the to pof the screen, create a cube, plane and a cylinder.
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

this will allow you to move the cube left and right, along the X axis, using the arrow keys or A/D.
the line "UnityEngine.Input.GetAxis("Horizontal")" makes use of the default unity inputs and movment axis  that are located in Edit (top right in the window) > Project Settings... > Input Manager.
changing these will stop the code from working.
![image](https://github.com/user-attachments/assets/5e4241e0-46c5-4ddc-90f6-bd3f489cf3da)

to test if the cube moves left and right, press the play button at thte top of the Scene and wait for it to load. once it does, press A/D or the left/right arrow keys. the cube should move.
if it does not, make sure to double check the inspector and the code for any erros or spelling mistakes.

once the cube moves, we can then work on getting the coins to dissapear when the cube interacts with it.
in order to do this, open your Coin script and 
