Game Engine Lab 4 Exercise 2

I implemented an observer pattern to play the audio source based on if the player collided with an enemy object. I invoked the action "dead" to play the sound when the enemy died.

The singleton was a count variable that displayed the number of enemies that the character killed. I also had a script which incremented a counter whenever the instance was called which was used every time the player collided with an enemy. By calling the instance and using the AddScore function, I was able to update my enemies exterminated counter that was located on the top region of the screen which kept track of the enemies the player collided with. 