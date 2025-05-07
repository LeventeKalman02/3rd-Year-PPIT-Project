# The Revenge of The Fallen Knight
 BSc in Computing in Software Development
 
 Year 3
 
 Professional Practice in IT

 By: Levente Kalman

[Youtube Demo](https://www.youtube.com/watch?v=dIJk8Y2DR-Y)

## Introduction

For the project I decided to go with a Unity game. The main idea behind the game itself is:

I wanted to make a wave-based survival game in 2D where the player is transported to an arena and must fight off waves of enemies.
Those waves increase in difficulty by increasing the number of enemies that spawn for each wave and decreasing the time between the waves. 
After every 10 waves, it will give the player the option to “return to base” by having a portal appear that the player can use. If the player chooses to re-enter the arena, then the waves restart back at 1.

Functionality:
-	Being able to move between the scenes.
-	Scene transition when the scenes change.
-	Store and currency functionality for upgrades. -Not implemented
-	Audio cues for button clicks and the portal that is used to go to and from the Arena.
-	Player Health and attacking.
-	Enemy Health and attacking with a delay.
-	Enemies drop coins to use for upgrades in the Store. – Not implemented
-	Animations and visuals. – Partially implemented

Some of the functionality in the project has not been implemented as I could not find a way to solve it and implement it in a way that I liked or that I felt fit into the design of the game.

## Reasons for Choosing Project
This section should discuss why you choose to do this project. For example, you may be interested in a specific technology, or wish to use this project to learn a new technology/architecture/framework.

I chose Unity as it is a technology and program that I have used previously in my own time, and I am interested mostly in making games. I wanted to use this opportunity to make a game of some kind that would help me learn multiple various aspects of using Unity and C#, especially the syntax that is used with unity. My main interest is in games, and it is the reason I want to become a developer. I want to be able to make games whether that is as an Indie game dev or working for game studio.

I thought this project was a good opportunity to see what it is I can do in a brief period of time as my previous knowledge and experience with Unity was limited. I took it as a challenge and to see how far I can take it from scratch and to figure everything out as I go along.

I really enjoyed being able to do my own thing, implement my own features and not having to fill out a bunch of requirements that were preset. Having the freedom to do as I wanted and having the passion to make games and to learn more about Unity and making games as a whole really helped me in deciding what it was that I wanted to do.

## Technologies you plan to use
You should list the technologies you are planning to use in the project.

During this project I plan to use multiple technologies. These include the basics of Unity itself, Visual Studio, which is the editor that Unity uses by default. 
These are what I used to make the project and do the work. Besides this I used Google and YouTube for help with issues that I faced during the project to help solve them. 

For the project management aspect of the project, I mainly used Trello to keep track of my ideas and things that I wanted to do and implement in the game. 
On this I also have the key issues that I faced during the making of the project and the things that I needed to solve in order to make the project functional and work as intended. There is also a link to that Trello board that I made at the top of the report. 

For the Trello board, I also added automation so that it makes the project management slightly easier. I added commands or “Rules” such as giving the “Work in Progress” tag to any new card that is added, or if the “To Do” checklist is completed then it automatically moves the card to the “Completed” list. 
There is also separate automation for the Issues section of the Board, so if there is a card added to the “Known Issues” List then it is given the “Issue” tag along with the previously mentioned “Work in Progress” tag. Once the issue has been resolved, again with the use of the “Fixed?” checklist, it will automatically be moved over to the “Fixed Issues” list.
I used this method to keep track of the things that I was doing in the project and that things that I wanted to implement and issues that I faced along with the ones that I have resolved.

## Self-Learning
What new technologies/frameworks/processes you intend to gain experience in during the project.
In this project there were several things that I wanted to try and learn more about. I wanted to improve my abilities as a programmer as the main focus. I wanted to learn more about and be able to use the syntax for Unity easier and learn more things about it and how it works to improve on my skills.

Having the Mobile Application Development module this semester which focused on Unity really helped at the start and getting my project off the ground. 
By the time it came towards the end of the year I had long since overtaken that module in what I was doing in my project and what was being covered.

There was a lot of issues that I faced mostly regarding the movement of the player and enemies, especially the jumping mechanic, which is why I decided to leave that out of the game and make it have a top-down perspective. 
This is mostly due to the fact that there are so many different ways to implement these features not just with code but also with the Movement Manager that Unity added recently in 2021 to the editor.

I was able to learn more about using the Syntax of unity, things such as “Time.DeltaTime” which is the interval in seconds between each frame. This can be used to slow things down to be more in real time such as the movement of the player for example. 
I learned things such as, you use the “FixedUpdate” function for calculating anything that requires physics calculations. This is a default function of the Unity Editor, along with “Start”, “Update”, “Awake”, and many more, but these are the main ones that I used during the making of the project. 
There are many other aspects of the Unity syntax that I didn't know previously to starting this project.

I was able to get better at searching the internet for assistance whenever I ran into any issues. Being able to take snippets of code and changing them to fit the needs of my project for parts that I was struggling with. 
I was able to watch YouTube videos that explained things such as the sprite animation or all the different ways it was possible to implement the attacking, for example. I was able to use those videos for inspiration for how I wanted my game to turn out and things that I wanted to implement.

Along with Unity and Visual Studio, I was also able to learn how to use Trello for managing my project. I figured out ways that I could automate aspects of it to make the management of the project and the board easier for me. 
This allowed me to be able to add all of my ideas and things I wanted to try to implement to the board and update things as I went along. This also helped me keep track of any issues I was facing, the things that I still needed to do and the things that I have completed. 
It helped me stay focused and tackle one thing at a time to be able to keep up and have everything working in a way that I wanted and liked. 

Seeing as it is a game there were a lot of aspects of Unity that I had to learn. 
This includes using sprites and images files that I found, being able to animate them with the proper timings so that it looks good in the game, being able to add audio and local audio that is attached to an object such as the portal that is in the game for example. 
These are all things that are built into the unity Editor, but they are all things I have had no experience with in the past, so I had to learn as I went. 

## Architecture
This section should describe, at a high level, the proposed architecture of the system. It does not have to be a detailed diagram/description at this stage of the project.

For the project consists of multiple scenes including the game scene, the “Home Base”, the Main Menu and the Controls scene. Each one of these have multiple functionalities.

**Main Menu** – The main menu serves as the screen that the game opens to, this is where you can navigate to exit the game, to view the controls and to launch the game.  
I have added a scene transition that fades the screen to black and back out when loading the game scene. This scene transition required a delay to implement correctly so this also allowed me to add audio to the button clicks on the menu itself.

**Controls** – The controls scene is a submenu of the Main Menu where you can view the controls that are needed to play the game. I had plans to also implement multiple features here such as volume controls, resolution controls and other player preferences that the user might like to adjust while playing the game.

**Home Base** – This scene is the first scene that I created with the intention of having it being like a hub for the player. Currently it just allows the player to travel to the arena and back. I had plans to implement a shop feature that the player can buy upgrades at after returning from the arena. 
There is a portal to the left of the crossroads that this scene is based around that the player uses to travel between this scene and the arena. 

**Arena** – The arena is where most of the action in the project happens. This is where the player can fight and kill enemies that spawn. I had plans to implement features such as a coin system or something similar that the enemies drop when killed that the player can use when he returns to the Home Base to upgrade their gear and make the next run easier.

**Player** – For the player there was alot of different things that needed to be addressed. Things such as the movement, the attacking, the health, adding a health bar. The most challenging parts were the health and the attacking. I had to translate the direction that the player is facing for the ranged attack so that the sprite of the arrow is always facing the correct direction. The health bar on the screen is linked with the actual health stat of the player. The movement was the easiest part to implement as it's just the X and Y axis transformed to move the player.

**Enemies** – Alot of the scripts that were used for the Player were able to be re-used for the enemies in the game. There were slight adjustments that had to be made, for example the movement on the enemies relies on getting the current position of the player and tracking towards that for the movement. The attacking of the enemies had to be changed slightly compared to the player. It works on a system that once it detects the collision with the player, after a set delay, the attack range of the enemy is shown and if the player is within that range they take damage. 

## Project Management

For the project I used a Trello Board as a type of Kanban board to keep track of the things that needed to be done. I added my ideas to the board at the start of the project as an outline of what it was that I wanted to do and achieve, and I expanded on it as I was working on the project and implementing features. 
I also implemented aspects of Scrum management.
I had weekly meetings with my project supervisor in which I outlined what I had done in the previous week and what I was planning to do in the coming week. I would plan out the details of each feature that I wanted to add on the kanban board in each card and try to implement them all and get them working by the next week’s meeting.
The Kanban Board consists of multiple different lists. One for each “Topic” as such that was used in the game such as “UI” or “Player” to be able to categorise them. There were also lists for each scene in the project so the Main Menu, the Home Base, the Arena. 
To each list I added the Cards containing the features that I wanted to implement. For example, the UI List contains the “Player Prefs” card which is a feature I was not able to include. 
All these cards consist of a brief description and then a “To Do” checklist in which I write all the things that I want that feature to be able to do, so in terms of “Player Prefs” it would be things such as adjusting the volume in game or the resolution of the game window.

## Test Plans

In terms of testing, each aspect of the code was tested as it was being written to make sure that it was functioning as intended. This had to be done to ensure that there were no issues before moving on to the next aspect of the game or the code.
For example, the health bar of the player. It required multiple testing phases and had a separate function for testing if the bar updated correctly when the player takes damage. 
This required multiple testing phases as the health system had to be incorporated with the health bar and tested that the variables were updating correctly, and the health bar was decreasing as intended.
Another example would be the Wave Spawner. 
There were a lot of issues with this script, each individual list had to be tested and debugged as to understand where it was going wrong and why it would sometimes just not work and other times spawn in hundreds of waves in one go. 
To achieve this, I went through the code disabling certain parts and testing each function at a time to see what it outputs to the console. 
This way I was able to find and solve the issues and where the loop continued to break.

## Future Works

I had a lot of ideas that I would’ve liked to implement in the game but sadly didn't get an opportunity to. Some of these ideas include:
•	Saving player data so that it continues if you close and re-open the game.
•	Adding a pause menu.
•	Adding a shop where the player can upgrade/buy gear.
•	Finishing the design work of the maps.
•	Adding animations to the enemies and the attacking animations to the player.
•	Adding more things to the Home Base as there are 2 other directions that are unused.
These are just some of the main ideas that I've had while making the game of things that I would like to see added and that I believe would make the experience far better than it currently is.

## Conclusion

In conclusion, I feel like I have learned a lot while making this project. I learned a lot about Unity and how it works and a lot of different aspects of Unity as well. 
At the end I happy with how the game turned out considering I had very little knowledge going into this project. 
There are a lot of things that I would change about how I went about some of the planning and definitely add a lot more to the game. 
I feel unsatisfied with how it turned out in certain aspects as I definitely wanted to add more to it but running into issues and trying to find sprites and generally just trying to figure out how I'm supposed to look at some of the issues that I faced took up most of my time. 
But i believe that is also a good thing as I was able to learn a lot from this experience that I will be able to use in the future.
