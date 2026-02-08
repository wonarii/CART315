# Class Journal

## Make a Thing 22/01/2026

I chose Bitsy!

I want to use this opportunity to learn more about Bitsy and use some of the more advanced features rather than just stick to things I am familiar with.

I especially want to try and use a Bitsy hack for dialog options. This will allow me to learn how to install Bitsy hacks but will also give me even more features to mess with when I’m making my little game!

The first step will be to find the Bitsy hack and figure out how to use it.

Here’s a [link](https://seleb.github.io/bitsy-hacks/dist/dialog-choices.js) to the Bitsy hack I will be using.

It was very easy to find and there are so many different hacks available in this [github repo](https://seleb.github.io/bitsy-hacks/), the Bitsy community is very resourceful!

For my theme, I chose to make a fishing/aquarium theme. I started by designing a simple room where the character might be able to collect fish and store them in their fishtank.

Once I had a little scene going, I used Borsky to hopefully be able to implement the [hack for the dialog choices](http://andrewyolland.com/borksy/).

![A screenshot of the Borksy tool!](/Process/Media/images/BorksyScreenshot.png)

Unfortunately, using the hack is much more difficult than I had anticipated. I initially thought it would be like Bitsy colour where I would have access to the features within the Bitsy editor. It doesn’t seem to be the case here. I’ve decided to look up a tutorial on YouTube to hopefully make better sense of this.


https://www.youtube.com/watch?v=2vUQR5TXu_I

I’ve gotten it to sort of work but unfortunately it's still iffy. I’ll come back to it later.

~3 days later~

Ok I’m a bit frustrated because I thought this would be easier which has led me to procrastinate on the project thus making it even harder for me to complete and making me even more frustrated.

So we’re going to take a deep breath and restart.

New theme, I’m going to make a little pet care game. Very simple, not much to do. I just need to make something.

I need it to be incredibly easy so I don’t give up.

I started again by making the visuals since those are easier for me and don’t require too much thinking.

Ok, I have most of what I want for the visual assets, I might add more decorations later if I have the energy to.



Now I want to focus on the “game” part of it. 

I want it to be very simple. You just pick up fish and yarn balls, then give them to the cat. There won’t be much else to do here. Not very fun, but the main goal of this “game” was just to learn how to use the Bitsy hacks.

So… That’s what we’ll do.

I will make the player have the option of either feeding the cat or playing with the cat.
That’s what will use the “dialog options” hack and it will modify the inventory.

I’m having a hard time because tab is a keyboard shortcut on safari that seems to be refreshing the page or something, causing me to lose my spot in the data and lose track of what I was doing.

Ok so the dialog options appear but unfortunately the player choice doesn’t seem to be registering. I think I’ll be adding a tester character to help me keep track of the inventory.

Just found out that there is a code button at the bottom of dialogs that would have saved me so much scrolling in the game data…

Alright after some modifications, IT STILL DOESN’T WORK!
Something is terribly wrong…

My variable isn’t changing at all…

Found the issue.
I don’t know if I should cry or laugh.
It was indentation.
I need to make sure things alignnnn :((((((((((((( 



OK, we’re getting somewhere. New bug: only the first choice seems to be working.
It was a missing space.

New bug: the yarn count doesn’t go down.
It was written item 0 instead of yarn.

The dialog choices all seem to be functioning correctly! I do want to add a default option for when you have no fish or yarn.

It’s there but it doesn’t work so I’m going to go count brackets.

I need to edit this in a larger document, the scrolling is driving me insane.

{% raw %}

DLG 0
"""
{
  - {item "2"} > 0 ?
    {
      - {item "3"} > 0 ?
        {choice 
          - Feed the cat (cost: 1 fish)
            {a = 1}
          - Play with cat (cost: 1 yarn)
            {a = 2} 
        }Good choice!{
          - a == 1 ?
            Yum yum yum! Thank you!{item "fish" {{item "2"} - 1}}
          - a == 2 ?
            Yippee! How fun!{item "yarn" {{item "3"} - 1}}
        }
       - else ?
        Feed the cat? (cost: 1 fish)
        {choice
          - Yes
            {a = 1}
          - No
            {a = 2} 
         }The cat is looking hungrily at the fish.{
          - a == 1 ?
            Delicious!{item "fish" {{item "2"} - 1}}
          - else ?
            Awwww...
        }
    }
  - {item "2"} > 0 ?
     {
      - {item "3"} > 0 ?
        Play with the cat? (cost: 1 yarn)
        {choice
          - Yes
            {a = 1}
          - No 
            {a = 2}
       } Play?
       {
          - a == 1 ?
            Yippee!!{item "yarn" {{item "3"} - 1}}
          - else ?
            Boooo....
        }
      }
      - else ?        
        Get fish to feed the cat and yarn to play with the cat!
    
}
"""

Final dialog code:
DLG 0
"""
{
  - {item "2"} > 0 ?
    {
      - {item "3"} > 0 ?
        {choice 
          - Feed the cat (cost: 1 fish)
            {a = 1}
          - Play with cat (cost: 1 yarn)
            {a = 2} 
        }Good choice!{
          - a == 1 ?
            Yum yum yum! Thank you!{item "fish" {{item "2"} - 1}}
          - a == 2 ?
            Yippee! How fun!{item "yarn" {{item "3"} - 1}}
        }
      - else ?
        Feed the cat? (cost: 1 fish)
        {choice
          - Yes
            {a = 1}
          - No
            {a = 2} 
         }The cat is looking hungrily at the fish.{
          - a == 1 ?
            Delicious!{item "fish" {{item "2"} - 1}}
          - else ?
            Awwww...
        }
    }
  - {item "2"} == 0 ?
     {
      - {item "3"} > 0 ?
        Play with the cat? (cost: 1 yarn)
        {choice
          - Yes
            {a = 1}
          - No 
            {a = 2}
       } Play?{
          - a == 1 ?
            Yippee!!{item "yarn" {{item "3"} - 1}}
          - else ?
            Boooo....
      }
      - else ?     
        Get fish to feed the cat and 
        yarn to play with the cat!
        
    
}
"""

{% endraw %}

Oof that was hard. Now for some simple dialogs to finish everything off.


I’M DONE!!!!!!! THE GAME WORKS!!
And now I can say that I know how to use the dialog choices Bitsy hack!
(Very important to pay attention to the indentation and brackets)
Time to save this somewhere safe.

## Exploration Prototype 1

### 26/01/2026

#### OneDrive hates me

Getting my files set up for a new Unity project! Already had a troubling encounter, my OneDrive has been acting up these days.
Many of my files are being randomly deleted and I'm getting warnings from OneDrive. 
My suspicions for this issue is that github is messing with it. So every time I push or pull, thefiles get modified and OneDrive freaks out.
At least, that's what I'm hoping is the problem. Better not be a virus...

Anyways, I disabled OneDrive for now (i use git anyways so stuff should be backed up online there, right...?)
Unfortunately, all my git repositories have been moved on my computer so they're not connecting to github desktop. I had to delete this one and re-clone it.
Seems to work alright now.

#### THE PLAN

For my first exploration prototype, I want to make a snowball simulator thing in Unity.
I chose something that seemed simple but still let me explore different aspects of the software. It's even open to adding more on top, so if its too easy, maybe I can add extra features!

Here's a breakdown of my idea:
1. Have a sphere
2. Give the sphere physics
3. Make the sphere move when it is clicked
4. Make the sphere get bigger when it rolls around

That should be it for a snowball simulator. I guess now I've got to go try it out in Unity!

#### Project is here, time for sphere

Creating that project took so long I had the time to go and catch 4 pokemons on Pokemon Go. And I'm actually pretty bad at the game.

Anyways, project is here, now I will find a sphere.

![A single grey sphere in an expanse of nothingness](/Process/Media/images/sadSphere.png)

It looks quite sad all by itself like that.

It has also come to my attention I will need to find some information online for this because I have no idea what to do next.
I want to make the sphere white. For snow.

Someone asked the same question as me [here](https://discussions.unity.com/t/how-do-i-change-the-color-of-a-sphere/92754)!

Yayayayayayayay!!

![The sphere is now white](/Process/Media/images/whiteSphere.png)

Next step: sphere needs to roll!

....

It has come to my attention that I may need a floor.
My sphere fell into the depths. I may never see it again...

Ok floor is in!
The sphere falls down nicely onto a plane!

I should probably add some walls so that the sphere can't leave from the sides.

I'm getting strange error messages on my github when I commit, yet all my files seem to be present online....
I will choose to ignore the issue and hope nothing bad happens to me.

This guy seems to be doing exactly what I want, so I'm going to follow his [tutorial](https://youtu.be/fESM_UIg1rA?si=MS3N2b-OkIE6QgZ_)

And [this](https://docs.unity.com/en-us/unity-studio/develop/gameobjects/camera)
for positioning the camera.

Four minutes into my tutorial and it seems he's moving the ball with wasd, which is not what i want.
At least I have a camera that follow the ball.
I'll try and find another tutorial.
Later though. I'm hungry. And my laptop is ready for liftoff.

### 28/01/2026

#### The heavens have struck me down

I have developed a cold, resulting in me going to bed very early in the past days.

I was getting too powerful.

Anyways, I have decided to actually follow the guy's tutorial because this seems like the quickest option to get something done.

#### Jimmy to the rescue

[Jimmy](https://github.com/Jimmy-Le/CART-315/blob/main/Process/Journal.md#movement-and-input) is teaching me how to use the new input system for movement. In real life. But he did it himself first so that's why he knows so much.
It's going well.... sort of....

So the move inputs are registering correctly. We had them print to the console.

Adding a movement, and the snowball got blasted into the void.
Jimmy says it's a delta time issue. Here's a [link](https://gamedevbeginner.com/how-to-use-delta-time-in-unity-and-when-not-to/) I found to help me understand it better.
This sums it up pretty well: "Multiplying the movement value by Delta Time converts the rate of change from units per frame to units per second."

I added another snowball to the scene so we can tell if we're moving because other-wise it's just a vast expanse of nothingness.

The ball no longer gets launched but instead now bounces? This is not something I wanted at all...

Jimmy is gone now, so I'll try and continue using the tutorial and the stuff he showed me.

Ok the tutorial worked! However, the axis are not aligned with the camera. I'll try and align the camera properly so that the controls map better to the ball movement.

ok aligning worked!

I will add some more random obstacles and blocks to populate the area.

I'm getting distracted on side quests but I want the snowball to move slower and actually stop when the player stops pressing keys.
So I looked up friction and this is what I got: [link](https://umatechnology.org/how-to-add-friction-in-unity/)

ok so i put the material on both the snowball and plane and set it to 300. I feel like that should make it stop moving but it doesn't.
The problem might instead be in the movement script.

![screenshot of the movement code](/Process/Media/images/CodeForFailedMovement.png)

I tried adding else conditions and it didn't work.

Tried to change the ForceMode, that didn't work.

ok [this](https://discussions.unity.com/t/stop-add-force-quickly/245266/2)looks very promising and it's a combination of the two things I tried to do!

It doesn't work.
I also tried to slow down the speed and it's not working.

I've decided I will give up.

And maybe instead I will go read the Unity tutorial thing we were supposed to read.
I feel like that will help me understand things better. Maybe solve my problem even!

#### A short while later

I made the snowball get bigger when it moves around!

Here is the reference I used for this:

[localScale](https://docs.unity3d.com/ScriptReference/Transform-localScale.html)

I'm still not a fan of the movement, I wish I could make it so the control is more precise and the snowball stops rolling when you stop pressing keys.
I feel like it'll have to be for another project though, I have other things to be working on right now...

## Exploration Prototype 2

### 01/02/2026

WE SUBMITTED A WORKING GAMEEEEEEEEEEEEEEEEEEEEEEE!!!!!!!!!!!!!!!!!

Find it here on itch: [The Fellmonger](https://sh4rpsteel.itch.io/the-fellmonger)

This weekend I got in a team with Ethan, Jimmy, Hubert and Owen to create a game in 48 hours!

This was for a game jam hosted at McGill.

My role was artist and I dabbled in some UI programming.

We started the weekend by brainstorming a bunch of words related to the theme: the Hunt.

![A screenshot of the Google doc where we listed words](/Process/Media/images/GameJamBrainstormDoc.png)

We all decided to do a boss rush, since that seemed like a fun and achievable goal.
My role was environmental art, so I started by working with Ethan (game designer) and Owen (character artist) to come up with the theme and vibe our art should take. 

I made some moodboards to help visualize the vibe more and also serve as reference images.
![Moodboard for the first forest background](/Process/Media/images/RefMoodboardDeerBg.jpg)
![Moodboard for the first forest background](/Process/Media/images/RefMoodboardDragonBg.jpg)

In the bonus challenges, I really wanted to do the multiple art mediums.

I brought a bunch of art supplies to mcgill and got to work with watercolours and crayons. It was a very trust the process kind of thing.

Here's a picture:

![Picture of watercolour grass field](/Process/Media/images/Grass.jpeg)
![Picture of watercolour trees](/Process/Media/images/Trees.jpeg)


I did not like the artwork I made at all so I edited it digitally until it looked different and not the same.

![Edited version of the previous grass field](/Process/Media/images/Background01_DeerForest.png)

I also worked on the deer. I'm very tired so there won't be much text this week. Have some pictures instead.

![First fame of deer walk cycle](/Process/Media/images/Deer_Walk0001.png)

Hated doing this. Had to color in this deer like 20 times for each frame of animation we used.
not fun. don't recommend.

Worked on a bit of random programming tasks with Ethan for the UI.

Love Debug.Log
My best friend:)
Finds where the problems are!

Unity documentation sucks and is so hard to navigate, tell me why they have color and color32 as two different things with different functionalities.

Game is cool:

![The Fellmonger screenshots](/Process/Media/images/TheFellmonger.png)

### 07/02/2026

#### Review of the game jam

I'm a bit better rested now and I feel like I can do a better reflection on the game I worked on last weekend.

I really do think game jams are made to create prototypes.
Especially our own game. We started out with so many more ideas but ended up only having time to implement a few of them.
However, our game is complete enough to show what we were going for. So if a prototype answers a question, then ours is maybe "Can we make a working game in a weekend?"
or maybe "Is the difficulty of this game balanced?" or "Do people know how to play without us having to guide them?"
I think our game prototype was able to give us answers for all of these questions.

And as for the types of prototypes, the final product (the game) is an integration prototype, but each team member kind of worked on the three different prototype types (look/feel, role and implementation).
I think I worked most on look/feel being part of the artist team. The moodboards I made really helped show other people what I was thinking about. This was really helpful because the question here was "Is this the direction we want for the background?"
The first moodboard passed but the second one was not exaclty it. But thanks to the moodboard, Ethan was able to point out which pictures fit, and which ones were off the mark.

I also showed them to the other artist Owen, just so he gets on the same page and knows what the backgrounds will look like. 

I made sketches before starting to draw the final versions and those were mostly just to determine the position of elements.
They still helped working with Jimmy though, because then I could show him the trees on the side and he could comment on the placement and how the game mechanics might work with those in place.

Finally, I also did some role prototypes when I was working on the UI with Ethan. We sketched out how the health system should work and how the display would change. This helped us have a clear goal when programming which is always helpful.

So overall, there was lots of prototyping through the whole event, and it helps communicate ideas, visualize features and show possibilities.

Very glad I did this event:)

## Exploration Prototype 3 

### 07/02/2026

MY friend pointed out this little guy I doodled in my agenda and said "I like this guy. You should make a game with him! His mouth is funny."

![Dinosaur character sketch](/Process/Media/images/dinosaur.png)

So uhhh. I guess that's what I'm doing.

I want to start with brainstorming possible game ideas (that are simple) I can make with this guy in it.

I'll do some low fidelity prototypes through sketching!

OK so some themes/features I want are to incorporate prefabs and have moving objects.

I'm thinking maybe some sort of pacman thing?

Ok, I've realized I don't know where to start with sketching, so I'll instead list a bunch of words in this document more for brainstorming.

- eating
- mouth
- platformer?
- fruits
- hunting
- dinosaur
- dragon
- fire breathing
- collecting
- kirby
- catching (like the mall) horizontal?

Alright so I think I know what I want to do.

Just a simple dinosaur "running" (more like the bg will be moving)

You would be jumping to collect food items that are flying by.

#### Lists!

I'm going to make a list of the elements I think I will need, and then add their functionalities.

1. Dinosaur character
- Jump
- Eat
- Run (ish)

2. Background
- Moves in a loop horizontally (I'm thinking a simple pattern so we can see movement since that will be easy to make it loop and won't require much work )
3. Food items
- Moves with the background
- When eaten (dino hits it), disappears
- Gives points

Let's start with just one for simplicity's sake. I want to maybe do a grilled cheese. Dinosaurs enjoy eating grilled cheeses right?

I think that's all I want to do for now. I have ideas for additional features but that might be for later.

![Dinosaur game sketch](/Process/Media/images/dinosaurSketch.png)

### 08/02/2026

Made a 2d unity project.

I think I want to start with a rectangle as my dinosaur.

After that I can work on making it pretty. So an implementation prototype before look/feel.

The rectangle has gravity and the floor doesn't move! (had to make it kinematic).

![A green rectangle on the floor](/Process/Media/images/dinoRunner01.png)

Now I want to make the dinosaur jump. So I'll try to apply and upwards force on it when the player clicks, presses space, presses w or presses up arrow.

Ok, so the dinosaur jumps but not very high, so I'm going to keep editing the "speed" (which is what controls jump height).

um. Changed the mass and speed and launched my dinosaur into space.

![A gif of the dino rectangle being launched into space](/Process/Media/images/dinoVisitingNeptune.gif)

It was not a gravity issue but a mouse click issue.My dino was infinitely jumping causing it to reach space.

Ok so jump looks good but I want to prevent multiple jumps so the player doesn't leave the screen.

I can either add a ceiling and make it so the dino bumps its head (this would allow the player to fly though)

or

I check when the dino is jumping and prevent jumps.

I'll try method 2.

Ok I can check if the dino is in the air by seeing if it is touching the ground or not.

#### Flying grilled cheese

Now I want to have some grilled cheeses flying across the screen so that the dino can eat them.
We'll start with just having them move across the screen.
(rectangles again, I haven't made any assets).
I'll try and use prefabs and instantiate.

Grilled cheese moves left now.

Grilled cheese now gets destroyed when hitting left edge.

It's going very smoothly:)

Next we want the grilled cheese to destroy and give points when dino hits it.

Ok so good news and bad news

Good news: the grilled cheese spawner works.

Bad news: the grilled cheeses knock over my dino:(

![Dino falling after hitting its head on grilled cheese](/Process/Media/images/dinoGettingHitByGrilledCheese.gif)

Set the mass of the grilled cheese to 0 and it fixed it:)

Now I guess it's just adding assets?
And maybe a point system?
