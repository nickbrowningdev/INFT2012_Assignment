# INFT2012 Assignment
## Description
This was a dice game for my C# Windows Forms course back in 2019. 

Each player has a ‘cumulative score’, and there is a single ‘running score’ which is used in turn by whichever player is currently active. The active player rolls the dice as many times as (s)he likes, and the numbers that show on them are added to the running score. The alternative to rolling the dice is to pass them to the opponent; when a player does this, the running score is added to the player’s cumulative score.

Why would a player ever bother to pass the dice? Because there is a risk in rolling them. If either of the dice rolls a six, the running score is lost, and the dice automatically pass to the opponent. The idea is to roll until the running score contains something worth saving, and then to save it in the cumulative score by passing the dice.

Once your opponent has the dice, you have nothing to do (except bite your nails, if you’re that way inclined) until either the opponent wins or the dice come back to you. Winning means getting to the goal score or above it. The points don’t all have to be in your cumulative score; the program should be smart enough to know when the sum of the cumulative and running scores has reached the goal.

Oh, yes, one small point: if you’re silly enough to throw a seven (in the specific form of a six and a one), you lose not only the running score but also your cumulative score, and your turns ends. Next time it’s your turn you start again from nothing. Note that this does not apply to other combinations that make seven: two and five or three and four.
A goal between 50 and 100 seems to make for a reasonable game. Goals of less than 50 tend to let the first player win too often, while goals of more than 100 tend to have lots of sevens, and so go for a long time.
