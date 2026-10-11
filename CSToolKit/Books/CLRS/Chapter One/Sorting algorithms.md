## Introduction ##
Here I'll explain different types of sorting algorithms, their applicability and their O-notation. I'll add pseudocode
as well to practice breaking problems down into their smaller parts.

### Dictionary ###
#### Loop invariant ####
A condition or a property that is true before the loop executes and remains true after each iteration - think of it as 
promise. If the promise is broken, the algorithm is not working.
The loop invariant has three separate stages:
Initialization, maintenance and termination.

#### Initialization #### 
The condition or property that is true prior to the first iteration of the loop.

#### Maintenance ####
The condition that the condition or property must remain true before next iteration, if it was true before the first.

#### Termination ####
When the loop terminates, the property will be equal to the condition set in the loop (for example if i > 20) and, 
together with the invariant, can conclude that the final result is correct.



### Insertion Sort ###
Imagine a scoreboard with no entries. As soon as a new score is being entered into the system, the scoreboard will 
update based on the value being inserted. The first value will always be at the top of the scoreboard as there are no
other values to compare it to. The scores that follow will then be compared to the existing scores on the scoreboard,
one at a time, and moved up or down based on their value and the values of the displayed scores.

#### Pseudocode ####
What I need: An array that needs sorting.
What I need to do: Take one index (key) and compare it to the rest of the stored values. If the value at index i is 
greater than the key, position the key to the left of the value. 
If larger, position it to the right. The already checked values will translate left or right in the array based on the 
result of the comparison.


