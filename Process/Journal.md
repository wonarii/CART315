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

