# Class Journal

## Make a Thing

I chose Bitsy!

I want to use this opportunity to learn more about Bitsy and use some of the more advanced features rather than just stick to things I am familiar with.

I especially want to try and use a Bitsy hack for dialog options. This will allow me to learn how to install Bitsy hacks but will also give me even more features to mess with when I’m making my little game!

The first step will be to find the Bitsy hack and figure out how to use it.

https://seleb.github.io/bitsy-hacks/dist/dialog-choices.js

Here’s a link to the BItsy hack I will be using.

It was very easy to find and there are so many different hacks available in this github repo, the Bitsy community is very resourceful!

https://seleb.github.io/bitsy-hacks/

For my theme, I chose to make a fishing/aquarium theme. I started by designing a simple room where the character might be able to collect fish and store them in their fishtank.

Once I had a little scene going, I used Borsky to hopefully be able to implement the hack for the dialog choices.

http://andrewyolland.com/borksy/



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
Oof that was hard. Now for some simple dialogs to finish everything off.


I’M DONE!!!!!!! THE GAME WORKS!!
And now I can say that I know how to use the dialog choices Bitsy hack!
(Very important to pay attention to the indentation and brackets)
Time to save this somewhere safe.







