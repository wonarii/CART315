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

Assets are being added in!

Looks great:)

![Dino eating food](/Process/Media/images/dinoEatingGrilledCheese.gif)

Ok, I'm pretty satisfied with this prototype so I'll be stopping here. 

## Exploration Prototype 4

### 16/02/2026

I can't believe it! I got sick again!!!!

I thought this couldn't happen! Llike you uild an immunity or something after getting sick the first time.

Anyways... I'm feeling pretty bad so this week is going to be very simple I guess.

I've gotta think of some idea.

I feel like this time I might want to follow a tutorial (or just watch, idk yet). That would require less thinking from me which is good because I feel like my brain has been replaced by mucus. 

I've been wanting to do a driving simulator for the longest time for the continuation of my [Tomsu series](https://wonari.net/tomsu/) so I'll try and find a relevant tutorial on youtube.
Something short and easy to follow hopefully.

#### FOund a playlist?

Ok so I found this [playlist](https://www.youtube.com/playlist?list=PLyDa4NP_nvPcP4l93hJQDoRMvp3emkSs7). It's a lot. I'm not following all that. 

I'll maybe just do the first video. And forget about having pretty models, we're doing an implementation prototype!

mmmmmmmm

Video isn't what I wanted it to be.

I think I'm going to go find another one. 

hrmmmm

I'm gonna go take a nap actually.

Idk these driving sim youtube videos are making me motion sick :(

#### Trying again

Ok so there was no nap but I did think about it a bit more and I will use the stuff I made for my snowball and just re-use that.

Now that I think about it, I'm just remaking the snowball game but worse ;-;

How do I turn this into something new?

Maybe I can try to implement a braking system or something.


![Screenshot of my rectangular prism on a road](/Process/Media/images/ScrrenshotOfREctangle.png)

Snowball movement is not working, my prism is just doing a slight jump up and down but not actually moving....

also there's a weird kshhhhhhhh noise coming out of my computer whenever I press play. Not sure if it's like the fans or just the scene itself has some sort of ambiant noise?

Ohhh ok upped the speed and it's moving my prism just not very well. I'm going to actually try and maybe make it so the prism glides above the floor?

Hehehe ok it looks kinda fun like this actually!

It works now so I'll just add the camera thing so it follows (from my snowball).

Camera follows!!!

Um. Good enough for now I guess, my next step would be to figure out turning.

I want it to turn, not just glide sideways.
If that makes sense.

So I'll be finding a tutorial.

This one by Ketra looks quite good: [Rotating a Character in the Direction of Movement](https://www.ketra-games.com/2020/12/rotating-a-character-in-the-direction-of-movement-unity-game-tutorial.html#google_vignette)

Ok so it sort of works

Still pretty wonky though.

It's not doing diagonals with the way I have it coded. Right now, it can only choose one of the four cardinal diirections to move towards. I might have to rethink the movement to make it smoother and allow for some diagonals.

I think the force thing was good for my snowball because it allowed for rolling, but here, maybe I should just do regular translations and stuff without the force.

Might look and feel better.

That'll be done another day though.

#### Giving up

I don't want to do that anymore.

I'm instead going to turn my attention to the dinosaur game.

The driving sim is fun but it feels repetitive to what I have already done with the snowball, and I don't want to have to figure out 3D movement anymore.

So dinosaur game improvements: 

1. Add a score
2. Add sound
3. We'll see if we have time for 3 but maybe downwards force so you're not stuck in a jump.

#### Adding a score

Using the same concepts learnt in class. I am adding a score so it goes up by one for every grilled cheese eaten.

The text was not appearing for some reason.
After "debugging", I pressed play and it suddenly appeared now so I guess that works...?

### 19/02/2026

Good morning!

Time to keep on working on dino game!

I got distracted yesterday and just stopped working on the game to do something else but we're back now.

I will finish up the score system!

![Score goes up everytime the dino eats a grilled cheese](/Process/Media/images/scoreGoingUp.gif)

It works pretty well now, but I feel like I compartmentalized it a bit too much, I have a GameManager, a Score and the grilled cheese all communicating with each other and that seems like a lot of unecessary steps.

I'll keep it for now though. I feel like the game manager has to stay, in case we switch scenes, weonly have to really keep the game manager.

eh.

I want to switch up the font and colour of the text for the score so I'll do that next.

I chose the font [Slackey](https://fonts.google.com/specimen/Slackey?preview.text=Score:&specimen.preview.text=Score:&categoryFilters=Feeling:%2FExpressive%2FPlayful) from Google fonts

![Screenshot of the nice font](/Process/Media/images/BeautifulScore.png)

I'm prettysatsfied with that!

#### Sound time!

Rawr!

I will go look online for sounds to add in.

Here's what I'm looking for:

1. A blip or chomp or nomnom noise when you eat the grilled cheese
2. a Boing noise when you jump

Heheh sounds added!

Can't really show that with a gif but trust me, they are there!

They're really cute actually!

Very happy with what I have :)

I think this is where I will stop with my dinosaur for now.

I definitely can add more things, such as downwards force, side to side movement, new food items (bad or good), a lives system, a background music track...

Those are future plans though, and not for today!

## Iterative Prototype 1 - Coming up with ideas

### 19/02/2026

#### In class brainstorming

So we were given a few minutes to come up with one idea.

With what's been going on in my mind lately, I decided I want to make a game for my best friend. She's been cheering me on for forever and has been feeling down so I feel like it makes sense for me to do something for her. 

And it also relieves me a bit of the pressure to do really well. Because I only need to do well for her. And she's impressed with almost anything I do so...

Anyways, here's the list of "how might we"s I've come up with during that first brainstorm:

How might we....
- Make a game for (best friend)?
- Make a game where you are a squirrel? (squirrel simulator)
- Make a game to cheer up (best friend)?
- Make a game about ducks?
- Make a game that can help communicate bad feelings?
- Make a game to visualize/organize thoughts?
- Make a collecting game?
- Make a multiplayer cooperative game?

WE DO NOT JUDGE THE IDEAS HARSHLY PLEASE

And so this was the start of something. The main theme is now obvious to me because I know my target audience very well. My target audience is me and my best friend.

Next was to brainstorm a list of words related to the initial concept.

I will now list a bunch of words and then after I will pass back and maybe expand on the ones I thought were interesting. (the pass back is happening one day later, so I had time to simmer a bit)

- Multiplayer: I want to be able to play together with my friend. I think a cooperative game would go really well here because it's like I can show her what I've done by participating actively and being in the game world too. I do think I want it to be same device multiplayer though. Like Fireboy and Watergirl.
- Different perspectives: It would be really cool if I can make it so the two players have different experiences as they play the game. 
- Difficult communication: Speaking with NPCS or interacting with the world but also maybe between players themselves too.
- Water/Drowning: I am a big fan of water imagery to represent emotions
- Obstacles
- Good ending: I don't want this game to be depressing, I want this to have a good ending. Or at least make you feel better after playing. Not frustrated or upset lol.
- Cute: This is important. To get my friend to want to play a game, it should be cute. For that initial attraction.
- Squirrels, ducks and cats: my bestie's favourite animals but also mine
- Doing bad things: moral decisions?
- Big bad
- Fear
- Anxiety
- Unfamiliar world: Unconventiional interaction?
- Things not made for you
- Accessibility: This would be an interesting theme to explore, especially if I can create an unequal balance between the two players, where one action is much harder for one of the players to accomplish, and vice-versa.
- Blue and yellow: our favourite colours but also colours that have symbolism (blue is sad and yellow is happy). Good contrast.
- Eye contact: The ultimate insult
- Forced smiles
- Masking: This is a theme I might want to explore. This ties with exhaustion, energy levels and forgetting yourself.
- Forgetting yourself
- Loneliness in a coop game: THemes of loneliness would also be an interesting direction to take. And in a co-op game, how could we convey loneliness?
- Music? Drone? Sounds?
- Levels
- Bad thoughts
- Words
- Nightmares
- Judgement
- People pleasing
- Bullying
- Family
- Anger/Rage
- SHame, Sadness, Despair, Guilt, Tired
- Easy option vs difficult path
- Energy levels
- Love, joy, acceptance, grief
- Disapointment
- Expectations
- Invisible barriers
- Unequal skills
- Platformer
- Abyss
- Crowds
- Asking for help
- Searching for community
- Simple controls: If it's for my best friend, controls that control quick reaction times or the coordination of multiple buttons at once might not be it.
- No reading: my friend doesn't read in games.

The hybrid activity done in class was nice, but I became very attached to this idea, so not much of what was proposed helped out. EXCEPT for Nadia's idea. Nadia and I had the words Rage and High-alert. We came up with a game where you have a rage meter and you are trying to keep it under control by interacting with different elements. (for example, screaming into a pillow, or petting your cat). Triggers in the world try to make your rage worse.

I liked the idea of a meter and trying to keep it under control. This ties in really well with my intial ideas.

And then I went home and just as I'm about to sleep I get some new wonderful ideas.

3D glasses?

What if I could make a game that is played on one screen but using advanced 3d glasses technology, each player sees a different thing?

So you know the thing where a red lense erases all the red stuff. And then the blue lense erases all the blue stuff so you only see the red?

Yeah, that.

Maybe that's something I want to play around with?

Another idea I had that is more of just expanding on my keywords was to make a player a duck in a squirrel world or a squirrel in a duck world. Not sure which one yet, but the main concept would be that the squirrels and ducks have very different abilities, and if one tries to fit in with the others, they are doing significantly more work.

Tomorrow I think I want to try and test out the red and blue thing, and maybe see if it works with other colours too. (i don't like red and blue, it just reminds me of tiktok and that's no good)

I also want to remind myself that I need to choose something SMALL. ACHIEVABLE. LIMIT YOUR SCOPE.

I always fall into the habit of wanting to do everything and then ending up with an unfinished mess I do not like.

So I will choose ONE idea and then make something simple and basic but well done.

And then if I have time I can consider doing more, but realistically, we won't be. 

Also, I'll be seeing my friend this weekend so I will get the opportunity to discuss with her! Maybe I can get some good insight, or even have her involved in the game creation process as an assistant game designer. It might help me stay motivated and it helps to get external feedback as you do things. 

### 21/02/2026

#### Forcing myself to sit down in front of this computer and think

I have all these great concepts but now I want to try them out.

I'll start with the 3D thing with the red and blue.

I do not have 3D glasses anywhere in my house so I'm going to try and colour a plastic protector sheet and see if that works?

I'll also do a yellow one to see if that might work too.

And orange. Orange is pretty hihihi

Ok Hold on, I want to try and structure my journal a bit better so let's try something out here:

#### Coloured lenses Experiment 1

##### Description

Testing coloured lenses as a potential way to have one screen show different things depending on what colour glasses users are wearing.

##### Goal

Is this a good concept to continue working with?

Do colours other than red or blue work?

##### Process

1. Cut out pieces of transparent plastic
2. Colour the plastic red, blue, orange and yellow
3. Make drawings with the same colours on paper
4. Move the plastic over the drawings and observe results

Using the adobe express gif converter.Hopefully there's not secret charge hidden somewhere.

 ![me testing the coloured lenses](/Process/Media/images/ColouredLenses1.gif)

  ![Testing the coloured lenses with light blue](/Process/Media/images/ColouredLenses2.gif)


##### Results

The blue was too dark  when drawn on paper. This means I have to be careful that the colours I use are lighter or the same as the colours of the lenses.

The red plastic hides yellow, red and orange, the orange plastic hides orange and yellow and the yellow plastic only hides yellow.

So this means I can use yellows and oranges too!

Marker on plastic doesn't dry and my hands are now incredibly colourful. And that means my keyboard too...

Going back to my questions, 

Is this a good concept to continue working with?

I think it is fun, so yes.

Do colours other than red or blue work?

Yeessss!! Let's use blue and yellow!

##### Future plans

Try it on the computer monitor instead of on paper.

#### Coloured lenses Experiment 2

##### Description

Testing the physical lenses on digital drawings and digital lenses on digital drawings.


##### Goal

Can I use the physical lenses to make the pictures on a monitor look different?

Can I make a digital version of the lenses to add within the game?


##### Process

1. Draw scribbles of different colours in my drawing program. Test different coloured backgrounds too.
2. Put lense in front of monitor and observe results.
3. Put lense in front of my eyes/the camera and observe results
4. Make a digital lense (low opacity coloured rectangle and observe results
5. Test with multiple opacities and transparency settings

 ![testing the coloured lense on the monitor](/Process/Media/images/ColouredLenses3.gif)

![Testing digital version of coloured lenses](/Process/Media/images/DigitalColouredLenses2.gif)

![Getting confused by colour theory](/Process/Media/images/DigitalColouredLenses1.gif)


##### Results

It... doesn't work?

Also I don't want to stain my monitor so the lenses are staying a bit away.

I think maybe my monitor colours are too dark?

Also, while testing with the different background colours, I've noticed that the way the colours look and stand out changes based on the background.



Can I use the physical lenses to make the pictures on a monitor look different?

Maybe with better lenses but right now, no. I might have to find actual coloured plastic for this?

Can I make a digital version of the lenses to add within the game?

Also no, but I should try and find some online resources, maybe that would work?
I feel like maybe having some sort of flashlight system?

##### Future plans

So, it doesn't really work, I think I want to pivot a bit and start thinking of what exactly I want to do for the game. This was fun to test though.

#### Thinking....

Eye contact.

Maybe I can make a game environment to show how awful eye contact feels?

Or like, a daily life platformer, and then there are obstacles?

That would be too much. We must limit!!!

Ok so here's what I want:

- 2 players
- same screen multiplayer
- cooperative
- yellow and blue
- each player has their own strength and weaknesses in terms of what they can do in the game
- each player perceives the world differently

And the game will be centered around ONE issue

Here's a list of potential issues I may want to explore:

- Loneliness/isolation
- Eye contact
- Communicating with others
- Fear of being judged
- Masking
- Anxiety
- Pressure to be a good person
- Nightmares

I'll sit on it a bit and then come back when I've chosen one.

### 23/02/2026

#### Coming up with ideas is so much easier together

Was in a bit of a slump but bouncing ideas off my firend really helped me feel more excited about this project!
I can now picture how things could look like in the end.

Here's some screenshots of our conversation:

![Screenshots of text messages](/Process/Media/images/Messages1.png)
![Screenshots of text messages](/Process/Media/images/Messages2.png)
![Screenshots of text messages](/Process/Media/images/Messages3.png)
![Screenshots of text messages](/Process/Media/images/Messages4.png)
![Screenshots of text messages](/Process/Media/images/Messages5.png)
![Screenshots of text messages](/Process/Media/images/Messages6.png)
![Screenshots of text messages](/Process/Media/images/Messages7.png)
![Screenshots of text messages](/Process/Media/images/Messages8.png)

So, here's the final idea:

1. It's a platformer with boss fights

At the end of a level there will be a boss fight.

2. The players are a duck and a cat

They will be controlled using wasd and arrow keys. 

3. Each player has an energy bar

This will be their stamina/health and will go up or down depending on different obstacles. I think I want the bar to be different for each, so maybe one player has 25 and the other has 30 energy.

4. Each player has different abilities

Duck: can swim, fly (if not weighted down), dive

Cat: Can climb and balance on some structures

5. The world is made for squirrels (wires and trees and lots of vertical things)

6. Collecting shiny things

There are shiny things to collect. These are group points.

7. Getting food

The goal of the game would be to collect all the food throghout the level, beat the boss and leave.

I'm thinking there should be 3 foods for each player to get (only they can get it).

8. In the style of fireboy and watergirl

There will be obstacles that will require both players to work together to overcome.


Now here are some level ideas:

1. Getting out of bed
2. Preparing to leave the house
3. Commuting
4. School
5. Job/work
6. Buying something at a store
7. Restaurant
8. Going to sleep

I think for the sake of scope, I will only be making a single level. I want to choose commuting because I have ideas for that one.

Now I should make a list of tasks for myself, and things I need to make this game happen. I'll sort them into must haves, should haves and could haves.

##### Must Haves

- 2 controllable player characters that can move left and right, and jump

##### Should haves

- trees to climb
- puddles to swim through
- food items to collect
- energy meter

##### Could haves

- boss
- wires
- squirrels
- eye contact
- crossing streets

This list will probably evolve with time, so I will leave it a bit bare for now.

I'll give myself a list of things I should do next:

- Sketch out level design
- Make working characters in Unity
- Work on the must haves, could haves, should haves list

That feels manageable. So future me, these are the three next things we should be focusing on!

## Video Game Analysis - Fireboy and Watergirl

I think this is one of the best multiplayer co-operative games out there. It's something I played a lot of as a kid with various different people. It is a game meant to be played with two players, one person controlling watergirl and the other fireboy. Each uses different keys but the characters can do the same movements: run and jump.

Here's the link to play it online: [Game](https://fireboyand-watergirl.com)

![Fireboy and Watergirl's first level](/Process/Media/images/Level1FireWater.png)

### Let's analyze why it was fun!

1. Simple controls

wasd keys and arrow keys. That's it. No other buttons to press or memorize combinations of. I think the simple controls made the game very accessible to new players. It was your basic video game character controls, and it felt very intuitive. Up arrow meant up (jumping). Left and right are to move left and right. Pretty easy to get for a beginner. This meant not a lot of time had to be spent explaining the controls to anyone new you wanted to play with.

I remember playing this as a kid, the wasd keys were for the most experienced player, as they were less intuitive than the arrow keys. It was an honour to be able to switch to the wasd keys when you became better at the game.

2. Good tutorials/onboarding

As you start the game, it explains how to play. It doesn't throw every single feature and puzzle at you at the start, it slowly introduces them and gives the player time to understand them, before adding someting else. The way the levels are built, you can trust that the next level might have some of the obstacles you currently encounter, plus maybe something new or an added twist. The familiarity between levels reduces utter confusion as to what to do next, and helps players solve the puzzles.

![Fireboy and Watergirl's first level](/Process/Media/images/TutFireWater.png)
![Fireboy and Watergirl's first level](/Process/Media/images/LeverFireWater.png)

3. Challenge

As you progress, the game becomes increasingly harder. The challenge and difficulty of the game was a mix of both physical skills (getting timings right, good reflexes) but also mental skills (solving puzzles, coordinating with your teammate).  This means players who might not be so good at one aspect (for example, aren't good at jumping at the right time) could still be good in other ways (solving the puzzles, determining which path to take...). The bigger the challenge, the better te satisfactiont to overcoming it. There was always big cheers when your teammate or yourself managed to get past a particularly difficult section. 

![Fireboy and Watergirl's first level](/Process/Media/images/GameOverFireWater.png)

4. Variety

While each new level keeps some similarities to the previous one, there are also always new challenges or obstacles mixed in. Each new level required players to think about which path they should take, and how to get past new obstacles. The roles and responsibilities also get switched up, sometimes players need to be the ones to press the buttons while the other runs, or other times one player needs to jump on a platform and wait for the other to flick a lever. 
Since every level feels new, the game doesn't feel repetitive, despite the characters only really being able to take 3 actions (run, wait or jump).

![Fireboy and Watergirl's first level](/Process/Media/images/Level2FireWater.png)

### What can I make better?

While this is a really great example of a good co-operative game, there are some details I might want to change when making my own game.

1. Challenge

While the difficulty in fireboy and watergirl did make it feel more fun when you DO succeed, it was not so fun when you constantly fail. Especially so, when (as a kid who did not have the most quick reflexes) it was always the same person who messed up. This caused frustration and even lead to some people not wanting to play with you anymore if you sucked that bad. It also meant sometimes you would get pushed out of the way so they could take over your character and play your part for you. 

For my own game, I want to make it more discovery and puzlle-y than reflex-y and timing. This would help reduce the skill gap and make players feel more involved. There will be no playing for another person here!

2. Visuals

To be fair, I'm not sure I want to focus on the visuals too hard for my own prototype but I will say that fireboy and watergirls visuals are a bit outdated. They still look cool though! and very nostalgic! But I'm not sure that's the style I want to go for with my own game. I would want my colours more cohesive. That's probably the only issue I have. Other than that the style itself is cute:)

3. Lives system?

Rather than an instant death and restart, maybe I could implement a life system, to be a bit more lenient with players and reduce frustration of having to restart constantly at the same spot.
The number of remaining lives could affect final performance so players who want that extra difficulty could go ahead and try to get the best score possible, while players who are less skilled now have a higher chance of being able to progress forwards. 

### What can I use?

I would love to be able to use a similar system of two players relying on each other (so for example, the switches in Fireboy and watergirl need a player to stand there in order to activate a bridge, or open a door). 

I also like how they implemented the tutorial, with text fading in and out as a player approaches a new obstacle. It is straight to the point, and let's the players learn by doing, rather than being forced to read. If they don't understand the new feature, they are barred from progressing, since understanding the feature is the only way to move forward. This prevents players getting stuck in further levels, where there isn't any tutorial text to guide you.

I like how the game re-uses similar components but puts them in different situations. This can make the game easier to make but still provides variety for the player to go through. Perhaps I might want to make my own preset of obstacles, and then mix and match them to create levels.

## Integration Prototype 2

### How do we start?

There's so much to do but we need to choose one question to answer! Something we can answer by making a prototype!

Risk assessment style.

I want to focus on level design and collaborative play here. 

### Role Prototype - Level design sketches

#### Description

I will sketch out possible level designs and ideas for challenges and puzzles that require two people to work together to solve.


#### Goal

Can I make a level that encourages both players to work together to succeed?

If I can't design any levels that would require two people and are fun, then the whole collaborative aspect is just useless.


#### Process

I used previous ideas andconcepts from fireboy and watergirl to come up with various different sketches.

1. List out ideas with words
2. Sketch various different obstacles and features to explore

#### Results

Here are pictures of my sketches.

![Picture of my level sketches](/Process/Media/images/levelSketch01.jpeg)

![Picture of my level sketches](/Process/Media/images/levelSketch02.jpeg)

![Picture of my level sketches](/Process/Media/images/levelSketch03.jpeg)

#### Feedback

I have presented the prototypes to the co-designer to see what we can change and improve. 

1. No getting chased/time-sensitive events

Having a monster chase you would be too stressful and would increase the difficulty to a point where playing is no longer cozy and is instead scary.
While it would be a great motivator for players to advance, this game should be calmer to allow more communication between players and exploration.

2. Lack of initial theme?

While the obstacles are cool, there lacks a motivation or storyline to keep the player motivated to continue. There should be clearer goals and "rewards" for progressing. Just having obstacles makes the game feel empty, there should be more meaning behind actions.

#### Review

After going through all the sketches and reviewing the feedback, I've come up with a level design I think is much better.
The story is that both players are navigating their nightmares. We'll start with Duck'snightmare, which explores the fear of isolation and loneliness.
I've decided to make Duck glow, but Cat will not. This way, Duck will feel a bit alone in a sense because they will need to move around to find Cat and will often be left alone in a spotlight.

The whole level would be dark with only Duck producing light, which brings an extra layer of difficulty to my simple puzzles, without being too stressful (like the being chased thing).

With this level design, I feel more secure about my game, and I would like to start working on implementation! While I have no yet designed the boss fight, I think it is best for me to focus on small sections at a time so I can have at least something functional at the end.

![Picture of my level sketches](/Process/Media/images/levelSketch04.jpeg)

### Implementation Prototype - Flashlight feature

#### Description

I want to test out the flashlight/spotlight aspect and see what it would look like, and how hard it would be to incorporate lighting into the game.


#### Goal

Can I make a simple spotlight that follows a sprite around, while the rest of the screen is pitch black?

#### Process

I searched for tutorials online and found a very short one that seems to be good.

1. Create the project files
2. Add shapes and platforms (objects to light up)

![screenshot of the shapes and platforms](/Process/Media/images/flashlightLayout.png)

3. Follow tutorial and make the whole screen dark

![screenshot of the shapes but dark](/Process/Media/images/flashlightDark.png)

4. Add a spotlight
5. Test different ranges and intensities

![screenshot of the  flashlight](/Process/Media/images/flashlightTest.png)

#### Results

The lighting works!

I still need to find out if I can make light go through obstacles but so far it looks good!

It is actually much simpler to implement than I thought, so the game will be very cool:)


#### What's next?

Testing light going through platforms and obstacles.

### Light through objects

#### Yeah it works.

It really wasn't that hard to test, I could have done it yesterday lol.

![Recording of the flashlight moving](/Process/Media/images/FlashlightScreenRecording.gif)


#### Next?

Actually implementing the level would be nice. I will work on an implementation prototype and try and have a functioning level!

First step would be to make the players move and jump, then add in the platforms and flashlight feature.

Next, I would do the button with the door opening.

I will save the climbing, puddle and quick sand for last because those are the most difficult, but also I can still make a playable level without them.

## Integration Prototype 3

### Review of last week's prototype

In class I showed my level design sketches to Nisma and Ethan. 

Since my main goal for this game is to make it for my best friend, it was important that the difficulty of the game comes from the cooperation and puzzle solving aspects, and not time-sensitive elements or physical skills (pressing the buttons in the correct order very quickly).
That's why suggestions of adding deaths, timers or unforgiving obstacles (obstacles that would mean instant game overs) were set aside.

I asked them about giving extra hints or having elements glow, but they both agreed that having the players figure it out themselves was the better option. They did like the idea of me having tutorials and short explanations for features as they appear. Ethan warned against introducing features too early, especially if they aren't going to be used in a while, because players would forget about them and get frustrated if they encounter them later and don't know how to overcome them.

I was also able to notice I forgot a climbing pole in part 2 for cat to get out of the button area.

Nisma also suggested the door only opens when the button is held down (part 2 sketch). I really liked this idea because it had duck be more involved.

This however, posed a problem with the quicksand trap, where a playercould get stuck by themselves in the trap and the other can't reach them.

To solve this, we added a door that would only open once both players are in front at their spots. This would ensure that there is no one left behind, so the quicksand trap won't block them.

### Implementation Prototype: Player movement


#### Description

I want to get the basic player movements in and implement Duck's light. 

Duck should be able to walk side to side using a and d and w to jump. s was also mapped as down but might be used later for extra actions (such as pulling someone out of the quicksand).

Cat uses the arrow keys but both players move the same.

#### Goal

Is the player movement speed appropriate?

Is the jump height adequate for the obstacles presented in the level?

How do the players interact with each other?

Is Duck's light powerful enough to light up Cat's way, without lighting up too much?

#### Process

1. Fumble around with previous projects to try and make the movement
2. Try (and fail) to use the new input system for Unity.
3. Struggle with the old system for Unity.
4. Find a [YouTube tutorial](https://www.youtube.com/watch?v=0-c3ErDzrh8)
5. Discover the constrain rotation checkbox. (This could have solved my Dino getting knocked over by grilled cheese problem)
6. Realize velocity is obsolete in Unity now.
7. Find an alternative (Linear velocity).

 ![Recording of the player jumping](/Process/Media/images/duckJumpingAround.gif)

9. Make a prefab for the players so we can copy over the hard work easily for the second player.
10. Struggle because gravity suddenly stopped working. (It was the simulated checkbox....)
11. Add in platforms to jump around on.
12. Add Duck's light.

![Recording of Duck in the dark finding Cat](/Process/Media/images/catAndDuckInteracting.gif)

12. Test and fix problems.

Problems encountered:

1. Players can infinitely jump up.

![Recording of Duck and Cat going up](/Process/Media/images/DuckAscending.gif)

Solution: Make a boolean to check if they are touching the ground or not.

2. Players can't jump when on each other's heads.

Solution: Give the players hats (collision boxes) on their heads to act as the ground.

3. Players stick to walls.

![Recording of Duck sticking to the platform wall](/Process/Media/images/DuckSticky.gif)

Solution: Add a physics material to the player with friction set to 0.


#### Results

I'm very happy with how it turned out, I like the light's radius and I'm really happy duck and cat can jump on each other's heads, I think that encourages cooperation and gives the players more opportunities to interact with each other. Unfortunately, this might also cause problems where players can reach areas they shouldn't be able to, so I will have to test carefully and make sure this feature doesn't make it so players can trap themselves in weird places.

![Recording of Duck and Cat moving around](/Process/Media/images/finalMovement.gif)

#### What's next?

Next, would be working on the camera system. I would like the camera to follow the players as they move forwards or backwards.

I also want to implement the buttons and doors.

## Iteration Prototype 4

### Review of last week's prototype

#### Issue: Player slides on floor

Got to class to show all my progress from yesterday and when opening the game I noticed my players slid all over the ground.

When I stop pressing the keys, they still continue gliding as if the floor was a slip n slide.

##### Potential solution: Adding shoes?

Maybe if I add another collision box under the character to reduce the sliding effect with a physic material it could help?

....

It made everything worse. 

Shoes were NOT it.

##### Potential solution: Go back a version on github

I don't remember my players sliding so much last time I worked on the project so if I revert my last commit, maybe they will stop sliding around.

.....

That didn't solve anything, the last commit didn't change much.

I did discover the source of the problem.

##### The source of the problem.

The source of the problem is..... the anti-stick to walls is anti-stick to everything :(

If i remove it... we stick to walls again:/

#### Potential solution: Remove the material

The anti-stick to walls material is causing problems, so we'll remove it so we have less slip.

We'll also modify the drag code (what was supposed to make the character slow down on the ground and move faster in the air).

The drag modifications work, now we don't slip everywhere, but we also still stick to walls.

I'm re-adding the material for no stick...

And we stick? But there's no more slipping... hmmm

![Fixed movement](/Process/Media/images/slideIssue01_dragFix.gif)

#### IT WAS THE HAT!!!!!!!!!!

THE HAT!?!?!?!? 

I added a hat to my characters so they would recognize each other's heads as the ground. The hat size is what was interfering with the wall sticky-ness.

By reducing the hat size and making it smaller than the body's width, I can make sure the hat never touches the walls, so the character will slide down properly.

![Fixed movement](/Process/Media/images/slideIssue01_THEHATJHSAKLFN.gif)

#### Comments from testers

Fayfay said she really liked the squares and thinks I could just keep the game like that without adding sprites. It's something to think about since I might not have time to make some fully-animated sprites.

Kelly suggested a really good option to mix the styles, and keep the squares but give them little faces and cute features. I really like this idea, I think it's a great time saver, since I won't have to deal with resizing all the colliders and it will still look super cute!
I'm not at the stage yet where I want to add sprites in, but once I reach that point, I'll think about this idea again.

### Camera movement

#### Main Question

How can I make the camera movements follow the players around the level smoothly?

#### Additional requirements

I think it would be really neat if Cat controls the camera movements while Duck has the light. This does however, add the extra challenge of making sure Duck can't get trapped anywhere. I need to restrict camera movement to make sure none of the players can get stuck off-screen.

#### Process

For my camera movement, I initially had the idea of putting colliders on each side of the screen (linked to the camera). This is cool, but Jimmy suggested another method I will use instead.

Jimmy suggested using two emptys to track an x value on each side of the screen.

In the code, I would check if the character has passed that point or no and then move the camera accordingly. This method is practical because I can always move the emptys around if I want to modify where the screen starts moving.

![Camera movement](/Process/Media/images/cameraMovement01.gif)

Unfortunately, now a new issue arises.

The camera is super choppy.

![Camera movement](/Process/Media/images/cameraMovement02.gif)

To fix that, I used [this link](https://discussions.unity.com/t/smooth-camera-movement/783467/3)
which led me to [this unity function](https://docs.unity3d.com/ScriptReference/Vector3.SmoothDamp.html)

Camera damp!

Super useful, solved my camera issues! Now it's just modifying the speed and I think it looks good.

![Camera movement](/Process/Media/images/cameraMovement03.gif)

##### Camera walls

I added walls (colliders) to the camera anyways... These are there so the players can't go offscreen at all. They need to wait for the camera to move.

Problem: Will these walls also interact with other objects too?

I want to make sure these walls can only affect players...

And there's a built-in unity function for that!

I just changed the layer overrides in the collider attributes, and now only players can interact with the walls :)

#### Results

The camera works well, it follows Cat, but stops if Duck is too close to the other edge. This ensures the camera field of vision is consistent all the time. 

There are also walls to prevent the players going off the screen!

### Cat climbs...?

While testing, I discovered Cat can climb walls. I'm not sure why or how, but this is super convenient, since one of cat's powers was being able to climb walls...

Guess that's done then?

![Fixed movement](/Process/Media/images/catClimbs.gif)

### Switch

Next, I want to make a button that when clicked, will open the door to let Cat out.

I decided on a switch with a lever, so Cat can push it into position. This will help the visual feedback, and should help differentiate between hold-down buttons (that will be added later ) and one time pushes.

#### Goal

How do I make a switch that Cat can interact with, and that is intuitive to use?

#### Issue 1

![Lever leaving](/Process/Media/images/switch01.gif)

... My lever leaves...

After a 30 minute attempt to code it to stop, I've thought of a much simpler solution to this.

I put collision walls inside the lever base.

Now the lever stays put where it is supposed to be:)

![Lever not leaving](/Process/Media/images/switch02.gif)

I also wanted to reduce the slipperyness of the lever. Thanks to the wonderful Shrekathon mentors, I was able to learn about Linear damping, a simple value that removes that slide motion.

#### The buttons

I want the green and red lights to turn on when the lever is above them. 

To do this, I added a collision box on the lights themselves. So now, when the lever overlaps with them, they get activated.

SPECIAL MENTION: ONENTER IS NOT THE SAME AS ONTRIGGER

(there was a slight struggle there)

![Lever works for green](/Process/Media/images/switch03.gif)

Got it working for green, now for red!

#### The door

Now that the switch works, I need to link it so that it actually activates the door.

This is not too difficult, as I conveniently already made a way to check the lever position with the green and red lights.

Now, the lever opens and closes the door for Cat!

![Lever levering](/Process/Media/images/switch04.gif)

### Water

The next feature I want to implement is the water obstacle. 

#### Goal

How do I make an obstacle Duck can easily cross, but Cat needs Duck's help to overcome?

#### Idea

Let's drop the raft idea.

Why?

Because Duck IS the raft!

Cat can just jump up on Duck's head!

It's perfect!

Now I need to think of the water obstacle itself.

One of my main design goals here, is to make it so players can't "die" in my game.

However, I want to prevent Cat from getting over without any help.

Potential reactions to water could be...

- Sinking?
- Getting stuck?
- Bouncing back?
- respawning...

The solution I came up with is to have Cat respawn on the side of the water if it falls in.

This prevents Cat from getting to the other side, without killing it or being too frustrating.

#### Implementation

Right, so making the water is no problem at all. I can also use tags to let the water know if Duck or Cat is there.

But now the issue is...

The respawn is too fast!

Cat immediately reappears, causing issues if a player is holding down right.

They'll get stuck in a little loop of falling into the water, unless they stop pressing.

I want to give them a bit more of a heads up before they plunge to their death.

#### New problem?

Cat can respawn off screen....

Cat is trapped outside the camera...

NOT GOOD.

I decided to make it so Cat will respawn to the side closest to Duck, so they can never get stuck outside the camera (hopefully).

This does give an easy cheat way to get across but I think that's a sacrifice I am willing to make.

![Water!](/Process/Media/images/water01.gif)

## Iteration Prototype 5

### Feedback from Tianshun and Junming

#### Playing

I got a duo to test my game. I think they're perfect playtesters since they haven't seen any of the previous game iterations, so they'll have a completely fresh perspective.

They're also always hanging out with each other so I think they'll do a good job with the cooperative aspects.

Here's the introduction I gave them:

> This is a two-player cooperative game. One person uses the wasd keys and the other uses the arrow keys.
> There are two squares, a yellow and a blue one. Only yellow has the light, so you have to find each other.

Junming was yellow (Duck) and Tianshun took blue (Cat).

It was really fun watching them figure it out without any clues. Junming started by exploring and jumping around. He soon discovered Tianshun and then they both started jumping around, staying near each other. This is something I haven't really thought of much, but it makes lots of sense. The players will prefer to stay near each other so they can see what they're doing.

Both of them spotted the pink platform pretty quickly, and knew that was the way out for Tianshun (Cat). Unfortunately, they couldn't figure out how to get through. THey tried jumping on it, Junming (yellow) tried exploring the left side, but the camera was preventing movement.

This is when i decided to give them a clue: Blue (Cat) controls the camera. 

Right away, Tianshun knew where to go and they found the switch.

There was a slight struggle getting out of the hole, since Junming fell in and to get out Duck NEEDS to jump on Cat's head.

Cat can exit on their own by climbing. I don't think either of them figured out Cat's climbing abilities, so I'll have to find a way to introduce that.

The water segment was the most fun to observe. Tianshun immediately went and died in the water, but didn't realize what happened, since when he respawned he was out of the light radius. Junming came back with the light to see what happened, and they pieced together that one person dies in water and the other doesn't. They did the little boat shuffle where both players try and move to the side at the same time bit by bit. This is exactly the type of collaboration I'm looking for!

And that's the end of the level I worked on!

#### Feedback

##### Camera movement

Both of them agreed I needed to find a way to let the players know that Cat controls the camera movements. 

My initial plan is to have it written down like in Fireboy and Watergirl, but Junming got me thinking of how I could design the level to SHOW players that feature and have them figure it out.

I think I might combine both approaches, so players who prefer exploration and who don't read can still figure it out, while slower players who take their time to read won't have to stumble around to try and figure it out.

I'd like to try and redesign my level to have a long corridor where Duck and Cat are separated. This will force camera movements, and hopefully be able to show it.
It would be even more effective if I could find a way to slow down Duck so players can clearly see which player is the one moving the camera.

##### Water explanation

Tianshun suggested adding a sign to show how Cat dies in water but Duck doesn't.

When he first died, it was confusing since it looked like the character just vanished.

Some indication or maybe a flash of light when Cat respawns could help.

##### Sound effects

Both of them told me how useful sound effects would be. Since most of the game happens in the dark and there's very little visual input, having audio input could counter that and help players get more information about what's going on. 

This would help them move around even when visibility is low.

It would also be useful to have sounds on the switch, so players can hear that something happens, even if they can't see it.

##### Colour coded walls

Tianshun suggested adding another feature: colour coded walls.

The concept is simple.

Blue can walk through blue walls, but yellow cannot. And vice-versa.

It's an interesting idea to explore, but I think I will save this for later. Introducing too many features right away might be too complicated (both for the players to understand/play and for me to code)

##### Switching colours

Junming suggested players could be able to change colours, so they can swap abilities.

This is a really cool concept too. I wouldn't let my players do it anytime, but having specific "colour-swapping" sections could be really fun to explore.

Unfortunately, just like the last suggestion, this is something I will save for later for the sake of time...

Great ideas for a level 2 if I want to make one!

Junming shared a game he made for CART253 (pippin's class) that had a similar colour-changing and colour coded wall concept.

It's a good inspiration if ever I have some extra time and want to try out the colour stuff!

[Junming's game](https://le7els001.github.io/VariationJam/)


#### Additional observations

##### Cat starting point

I think Cat should start in a small area where there IS light. This way, both players can situate themselves before diving into the level and puzzle solving. I noticed one issue was that Tianshun would have never known there was the Blue square unless I told him.

Their initial reaction was: Where's the second player?

While I do want to keep the theme of isolation and loneliness, I think having a light at the beginning only won't hurt the theme if it is small enough and placed strategically.

##### Start screen

I think I can have a cute start screen, where I would explain the controls before jumping into the game.

This does feel like an extra, but if I'm not there to explain the game like I did today, how would players know what to do?

### Adding platforms

Working on the rest of the game...

Important constraint to remember when placing platforms: CAT CAN CLIMB!!

This feels like spider-proofing your house in minecraft.

I need to make overhangs to everything to make sure Cat can't access weird areas and get stuck.

![Platform placement](/Process/Media/images/platformPlacement.png)

### Feedback from Ethan

I wanted to show Ethan my progress too

#### Playing

Ethan played as both characters, which requires a bit more concentration and motor skills to coordinate. 

There was a big struggle to find Blue at the beginning ( I think it may be because he was jumping with both characters at once, making it so Duck can never spot Cat).

Once he found Blue, he did understand the pink platform was significant, but again here, it wasn't easy to figure out what to do. 

I was worried it's too hard to understand, but he did mention that games do have a learning curve, and its good to have players explore. Which is very true! I shouldn't be giving my payers everything for free, they need to figure some stuff out themselves!

Once he found the lever, there was an issue where he thought it had to be pushed right. (nu-uh)

##### Switch lights

THE GREEN LIGHT ISN'T VISIBLE!

Players can only  see the red light, so how could they know which way to push the lever?

To fix this, I think I should either make the lever thinner, move it to the right more or change Duck's light radius slightly.

I want to stay away from modifying Duck's light though, since I like the current level of visibility they have.

##### Cat climbing

Ethan thinks Cat can jump higher. Hasn't really figured out the climbing aspect.

I really need to make it more obvious, especially since you use it to get out of the box.

##### Water

Again, the water respawn was a bt confusing, but he did figure it out pretty quickly, so it's not so bad a problem. This does confirm there are the same pain points as with Tianshun and Junming.

##### Down arrow / S

Those keys currently do nothing. Should I make it so the down keys make you plunge? This is default gamer controls, and I do think it would help make the characters easier to manipulate.

Not quite sure on this yet, but something to think about...

### Hold down buttons

#### Goal

Make a set of buttons that only open a door when held down (player stands on it). If a player gets off, the door closes.

#### Issue 1: Button shape

As seen with my switch, having a square platform is complicated, since my square players can't just walk on, they need to jump.

For my switch, I added sloped sides so you can walk up to it.

I think I will do the same thing for my button, since I expect Cat to do the button press in the dark, and that feels impossible to do if you have to constantly be jumping around to find the button.

So sloped sides it is!

![A trapezoid](/Process/Media/images/button01.png)

#### Issue 2: Jitter and button won't go down

The button moves smoothly when rising but jitters when lowering.
I think it's because of my code, when the button lowers, the player exits the collision area for a split second, causing the button to rise just a little bit.

This looks ugly.

![Video of the button not lowering](/Process/Media/images/button03.gif)

##### Solution 1: Increase the speed of the button

This didn't work, the same problem is present.

I think it may even have gotten worse.

##### Solution 2: Decrease the speed of the button

Also does not solve my problem at all.

The jitter is still very present.

##### Solution 3: Increase the collision box area

The jitter is still present but now the player floats above the button...

##### Solution 4: Big collision box and trigger?

If I set the collision to trigger and I modify my code a bit... Maybe?

It works!!!

The button goes down smoothly and my player doesn't float!

![Video of the button lowering nicely](/Process/Media/images/button04.gif)

#### Issue 3: Square in front of the platform...?

This might have to do with layer order so I'll just go explore what I did for the triangles and why they're going behind the platform.

Ok so no difference really that I could spot, so I just put the entire button back by changing the z position to 1.

It still works so no issue there!

![Green square left over the platform](/Process/Media/images/button02.gif)

![Green square gone](/Process/Media/images/button05.png)

#### Linking the button to the door

Pretty much re-using the code for the other door (pink one), with just some modifications done to the values so it opens vertically.

It works, but I'm wondering if it's a bit too fast?

![Door opening when the button is pressed](/Process/Media/images/button06.gif)

Also tested to see what happens if a player gets squished by the door. They get shoved into the ground but they can get out just fine, so it's not really a problem.

![Duck getting squished by the door](/Process/Media/images/button07.gif)

#### Second button

uh oh

this is a problem...

#### Issue 4: second button

The second button interferes with the first one, since now the door is constantly opening unless both buttons are pressed.

I think I will add a condition in the code that overrides the other button if one is activated...?

I think I will need the help of my trusty debug.logs for this

Very strange because my holds and releases seem to still be working, there might be an issue somewhere else...?

Ok so found one issue and it's that the door is both trying to open and close at the same time.

I'm going to try and make a static variable that is shared between both buttons so they can alert their condition to each other.

....

OK WELL NOW BOTH BUTTONS GO UP AND DOWN TOGETHER

![Both buttons work together](/Process/Media/images/button08.gif)

another variable!

It works now!

New bug introduced though.

If both are messing with the buttons at the same time, there could be some unpredictable results and the door can get stuck.

![Door getting stuck](/Process/Media/images/button09.gif)

This is actually the stuff I'm learning in operating systems so I'll try and use a counting semaphore here.

woohoo!

Who knew computer science courses could actually be useful!

![Working hold down buttons](/Process/Media/images/button10.gif)

### No quicksand

Yeah so even if it is in my initial level design sketch, I'm going to remove the quicksand. It's just another complicated thing to explain, and will just confuse players more than anything.

I'm happy with the current features I have right now, so I'll be skipping the quicksand part and moving on.

### Parkour parkour

Now it's just about adding some jumping sections.

I'll purposefully add parts where they need to use each other's heads to jump up.

That was pretty simple. 

![Parkour section complete](/Process/Media/images/platforms01.png)

### Exit/end

The last thing I want to add before i go back and fix my level is a way to actually win.

I brainstormed a bit on paper and made a few sketches. I settled on making the pit of light idea.

I want each player to have their own platform (colour coded to them) that they have to stand on at the same time.

Then, I want a pit to open up below that they have to jump in together.

I want to play around with the light, so have the pit emit light. I'm not quite sure yet how I'll do that though...

Something to experiment on.

![Sketch for game end and possible new level](/Process/Media/images/sketchGameEnding.jpeg)

