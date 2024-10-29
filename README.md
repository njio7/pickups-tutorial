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


create two scrpts. one called "Player" and one called "CoinScript". you can name them what you want but i will be naming them like so to make it easier to tell the diference from the coin object and the coin script.
after that, drag your Coin script onto your coin and your Player script onto the cube. when selecting your cube or coin, you should be able to see one script each in both objects, like so:

![image](https://github.com/user-attachments/assets/e9630234-ec1f-480a-a79f-df33a94dbcaf)
![image](https://github.com/user-attachments/assets/c8b6db61-8b4d-4f66-9d3b-c3ff84f074a2)

