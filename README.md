# UnityFakeFriendships
You know how you're in a scray game and the monster is chasing you and you're firend down the road and he trips and fall distracting the monster as a meal and you escape and laugh as you find it funny that you hear his voice in the background yelling, yeah what if you're the reason why he trip. -> into a game


## GOALS for Version 0.0.1 
- 🗸 Goal: Make a system where this monster chases the closet player and attempts to eat them. 
	- 🗸 Make testing field
	- 🗸 Make player 3d assets + make monster 3d assets 
	- 🗸 Make script where monster attacks player closets 
	
- 🗸 Goal: Make a handcuff item that a player can attach to another player while the mosnter is chasing
	- 🗸 Make a chain item asset + item that chain can connect to
	- 🗸 Make player 1 grab chain item
	- 🗸 When player two get close to player 1 he chains him to an object near by if it's chain able 
	
- Goal: Import last two goals into a FPS controls
	- Have cuff item pickup activate when player gets close to it
	- Have player 1 run up to drop a Cuff item to another player
	- Do the same but with another pillar 

- Final Goal: Have a multiplayer base setup
	- Each player can grab chains and chain another player to escape the monster
	- Have player be spawned in random locations
	- Have player joining multiplayer more than once

# Step 0:
	- 🗸 Make scripts, prefabs, assets , scene, and Game object for testing
	- 🗸 Made two scripts to test the mechanic out of cuffing your friend while running for exit
	- 🗸 When a monster comes to close to a player they stop moving 
	- 🗸 Players want to be moving to the exit all times
	- 🗸 When the player hits the exit, they escape and disappear 
	- 🗸 Make some obstacles and players colliders 
	- 🗸 Get some debugs for organization
	
# Step 1:
 	- 🗸 Make a basic first person controller 
	- 🗸 Have Monster Roam Randomly
	- W/ first person, have monster chase player
	- Have cuff works within first person mode by pressing "E"
	- Have a hover icon for other player to chain them
	- When Pressing "E", the player will be cuffed
	- Configure same process but without a chain and ball, it'll be a chain and pillar
	- Have player chain another player
	- Have player chain to another pillar
	-  Vise Versa 
	- Once player has been chained to pillar, they can move around within set radius 
# Step 2: 
	- Make offical testing map and test NPCs
	- Configure director for spawning levels and classes
	- Offically create an place holder prefabs
	- Clean up all scripts and files
	- Keep bug check and debug active for now 
# Step 3:
	- Once scripts have been figured out and organize start multiplayer
	- Find way to have connections through multiplayer 
	- May have to build APK
	- Find best way for people to join each other / Host
	- Work out more research about multiplayers
	- Make small UI for joining in top left screen for now
	- Button: Host / JOIN host
	- Make button scripts based on multiplayer scripts
# DEV NOTES:
		- When too many scripts for different item mechanics are made, make a mechanics folder"""
		- Flying assests will use circles 
		- Walking Monsters will use Squares 
		- Hiding Monsters will use Capsules 
		- Stalking monsters will be planes 