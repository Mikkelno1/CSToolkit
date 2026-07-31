# Predicate Logic
Predicate logic is a more powerful form of propositional logic, where the statement is neither true nor false
before the truth values are specified for the variables. With predicate logic, we introduce a more general statement
that has the ability to transform based on the variable.

Take the example from Rosen's book: 

"Every computer connected to the university network is functioning properly"

The above statement can't be described using propositional logic alone, and this is why predicate logic exists.

A predicate is a statement that describes a property that can be examined. The predicate also needs a domain 
(the area of which we are examining this statement in) and a subject, of which the statement is referred to. 

To describe that, we let the domain be "every computer connected to the university network", the subject (variable) 
"a computer" $$ x $$ and the predicate $$ P(x) $$ "functioning properly". 
We can then determine the quantifier we need to use by examining the statement. It's a way to describe the extent 
to which the predicate is true in the domain.
The universal quantifier, "every single element of x" is $$ \forall $$ 
The existential quantifier, "at least one element of x" is $$ \exists $$

So the above sentence can be described as $$\forall xP(x)$$

Or, if the sentence had been "There exists at least one computer connected to the university network that's
functioning properly" $$\exists xP(x)$$

Lastly, all logical connection can be used in predicate logic:
Let P(x) be the statement that "x has a cat", C(x) "x has a sister" and D(x) "x likes long walks" and the domain "all 
of my neighbors". 
We can then use the same logical connections to create longer predicate statements:

$$ \forall x\ ((C(x) \land D(x)) \to P(x))$$

"For every one of my neighbors, if they have a sister and like long walks, then they have a cat"