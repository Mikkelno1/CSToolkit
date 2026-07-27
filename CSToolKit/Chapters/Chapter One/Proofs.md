# Application of laws

Sitting here, listening to ambient Halo music, while reading through Rosen's Discrete Mathematics and Its Applications
made me realize that future me needs to have some written proofs, not just in my old notebook, but also in a digital 
format that can be preserved.
The purpose of this particular document is to provide proofs, both finished (and correct) ones, but also showcasing the 
ones I got wrong. The incorrect proofs are equally important, as they show where I forgot to apply laws or simply forgot
something. They will serve as a reminder that progress comes slowly and with effort, corrections and persistence. 

_A correct proof shows the destination. An incorrect proof shows the path that led there._


## First proof $$(p \to q) \land p \equiv p \land q$$

This is a fairly simple proof. However, it caused me a bit of trouble, since I had misunderstood a very fundamental 
thing about the distributive law, which I will show later. 

First, the correct proof:

$$
\begin{aligned}
(p \to q) \land p &\equiv (\neg p \lor q) \land p && \text{Implication} \\
(\neg p \lor q) \land p &\equiv (\neg p \land p) \lor (q \land p) && \text{Distributive} \\
(\neg p \land p) \lor (q \land p) &\equiv F \lor (q \land p) && \text{Negation} \\
F \lor (q \land p) &\equiv F \lor (p \land q) && \text{Commutative} \\
F \lor (p \land q) &\equiv p \land q  && \text{Identity}
\end{aligned}
$$

Now for the incorrect one:

$$
\begin{aligned}
(p \to q) \land p &\equiv (\neg p \lor q) \land p && \text{Implication} \\
(\neg p \lor q) \land p &\equiv (\neg p \land p) \land (q \lor p) && \text{Distributive} \\
(\neg p \land p) \lor (q \land p) &\equiv T \lor (q \land p) && \text{Negation} \\
T \lor (p \land q) &\equiv p \land q  && \text{Identity}
\end{aligned}
$$

First of all, I misunderstood the distributive law. That's the problem with self-studying - you have no one to ask
if things aren't clear to you, and YouTube can only help you so much.
I believed that the first proposition should be distributed over the rest of the expression. 
This proof demonstrates that that is not the case. That error sent my proof
down the wrong path very quickly. Together with me forgetting to change the logical 
operators, made it appear as if I had proven the two expressions equivalent, even though that clearly wasn't the case.

### Lesson learned
When applying any equivalence law, I should first identify the pattern that matches the expression instead of deciding 
in advance which proposition to distribute.


## Second proof


