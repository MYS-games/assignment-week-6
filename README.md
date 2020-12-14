# Assignment-6 

* Shir Avraham
* Yuval Zarbiv
* Matti Stern

We chose section 3 and create Angry Birds game with 4 levels.

Each level has a bird, some pigs, a torch and some levels also have boxes.
The goal is to hit all the pigs at once.

#### The Bird
The bird is the Player Character, it has a script that is responsible for the bird situation in the game.
* If the bird has crossed the boundaries, the player is disqualified.
* If the bird is sitting on the ground for more than 3 seconds it means that the player didn't pass the level and the level starts again.

The script is also responsible for the movement of the bird, according to physical laws.
* When the player pulls the bird to one side it returns to the other side with a force that depends on the speed we set for the bird.
* After the player launches the bird, its gravity varies from 0 to 1.

The script: https://github.com/MYS-games/assignment-week-6/blob/master/Assets/Scripts/Bird.cs

#### The Pigs
The pigs are the Player's enemies, they have a script that is responsible for the their situation in the game.
* If a pig is hit by a bird it dies.
* If a pig is hit by a box it depends on where the box hit him, if the box hit his head he's dead, otherwise nothing's happening to him.

The script: https://github.com/MYS-games/assignment-week-6/blob/master/Assets/Scripts/Enemy.cs

#### The Torch
The role of the torch is to move on to the next level. It has a script that check how many pigs there are in the game at the moment.
* If there are 0 pigs in the game it means the player has managed to kill them all and he moves on to the next level, Otherwise nothing happens.

The script: https://github.com/MYS-games/assignment-week-6/blob/master/Assets/Scripts/MoveScene.cs

## Level 1

The scene: https://github.com/MYS-games/assignment-week-6/blob/master/Assets/Scenes/Level1.unity


<img src="https://user-images.githubusercontent.com/57191216/101473770-ec549600-3952-11eb-9ff0-ec1d060eae69.png" width="700" height="400">


## Level 2

The scene: https://github.com/MYS-games/assignment-week-6/blob/master/Assets/Scenes/Level2.unity


<img src="https://user-images.githubusercontent.com/57191216/101473783-f1194a00-3952-11eb-85c9-e45548883f99.png" width="700" height="400">


## Level 3

The scene: https://github.com/MYS-games/assignment-week-6/blob/master/Assets/Scenes/Level3.unity


<img src="https://user-images.githubusercontent.com/57191216/101473786-f2e30d80-3952-11eb-9fab-6a4f20fe89bf.png" width="700" height="400"> <img src="https://user-images.githubusercontent.com/57191216/101473791-f5456780-3952-11eb-8060-1042ce654cc4.png" width="700" height="400">


## Level 4

The scene: https://github.com/MYS-games/assignment-week-6/blob/master/Assets/Scenes/Level4.unity

<img src="https://user-images.githubusercontent.com/57191216/101473801-f70f2b00-3952-11eb-914b-383baaab3217.png" width="700" height="400"> <img src="https://user-images.githubusercontent.com/57191216/101473806-f8d8ee80-3952-11eb-947e-431049e306d0.png" width="700" height="400"> <img src="https://user-images.githubusercontent.com/57191216/101473812-fa0a1b80-3952-11eb-8f74-c103d6e2dd21.png" width="700" height="400">



