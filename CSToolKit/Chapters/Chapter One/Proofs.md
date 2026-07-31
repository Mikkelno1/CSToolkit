# Application of laws

Sitting here, listening to ambient Halo music, while reading through Rosen's Discrete Mathematics and Its Applications
made me realize that future me needs to have some written proofs, not just in my old notebook, but also in a digital 
format that can be preserved.
The purpose of this particular document is to provide proofs, both finished (and correct) ones, but also showcasing the 
ones I got wrong. The incorrect proofs are equally important, as they show where I forgot to apply laws or simply forgot
something. They will serve as a reminder that progress comes slowly and with effort, corrections and persistence. 
The following three proofs demonstrate the application of many of the fundamental equivalence laws.

_A correct proof shows the destination. An incorrect proof shows the path that led there._


## First proof $$(p \to q) \land p \stackrel{?} {\equiv} p \land q$$

This is a fairly simple proof. However, it caused me a bit of trouble, since I had misunderstood a very fundamental 
thing about the distributive law, which I'll explain later. 

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
down the wrong path very quickly. Combined with my forgetting to change the logical 
operators, this made it appear as though I had proven the two expressions equivalent, even though that clearly wasn't the 
case.

### Lesson learned
When applying any equivalence law, I should first identify the pattern that matches the expression instead of deciding 
in advance which proposition to distribute.


## Second proof $$\neg(\neg p \lor (q \land T)) \stackrel{?}{\equiv} p \land \neg q$$

The second proof was easier. I remember a guy on YouTube stating "Just De Morganize everything". That worked well. 

$$
\begin{aligned}
\neg(\neg p \lor (q \land T)) &\equiv \neg (\neg p) \land \neg(q \land T) &\text{De Morgan} \\
\neg(\neg p) \land \neg(q \land T) &\equiv \neg (\neg p) \land (\neg q \lor \neg T) &\text{De Morgan} \\
\neg (\neg p) \land (\neg q \lor \neg T) &\equiv p \land (\neg q \lor \neg T) &\text{Double Negation} \\
p \land (\neg q \lor \neg T) &\equiv p \land \neg q &\text{Identity} \\
\end{aligned}
$$


## Third proof $$((p \to q) \land (p \to r)) \stackrel{?}{\equiv} (p \to (q \land r))$$

This one looked daunting, but the law of implication really is simple once you know how to use it.

$$
\begin{aligned}
((p \to q) \land (p \to r)) &\equiv ((\neg p \lor q) \land (\neg p \lor r)) &\text{Implication} \\
((\neg p \lor q) \land (\neg p \lor r)) &\equiv (\neg p \lor (q \land r)) &\text{Distributive} \\
(\neg p \lor (q \land r)) &\equiv (p\to(q\land r)) &\text{Implication} \\
\end{aligned}
$$


### Lesson learned
After figuring out how distribution worked, I realized that finding equivalence between two expressions was more a 
matter of pattern recognition than trying to do algebra. That helped me immensely here, especially after realizing that
both the left and right side of a law can be applied to an expression.


## Extra
I've always enjoyed writing on a whiteboard - there's just something very pleasing about being able to wipe the board 
clean after having done any kind of work. I use it for my exams, my homework and now this. I can't recommend it enough.

![Third_proof.jpg](../../Images/Chapter_one_proofs/Third_proof.jpg)