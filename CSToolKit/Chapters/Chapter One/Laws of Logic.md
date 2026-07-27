# Laws of logic
Used to expand and simplify expressions, which makes it faster to find whether two
expressions are equivalent, as compared to making truth tables for each expression.
Laws can be applied to both expand and simplify an expression (see distributive law)

This Markdown includes a Layman's terms explanation as well as a formal description of the law. 
For me, having to include more cognitive load by having to translate the laws from English to my native language
was too much of a hassle. I opted to translating the laws to my own words and then looking up a more formal 
definition afterward. 

## De Morgan's law
### Layman's terms
Negates everything inside parentheses and flips the operator
### Formal description
Describes how negation is distributed over conjunction and disjunction by negating each proposition and 
replacing the logical operator with its dual


$$\neg (p \land q) \equiv \neg p \lor \neg q$$

## Implication law (Conditional disjunction)
### Layman's terms
Negates the left side and changes the if operator to or while keeping the right side as-is
### Formal description
Expresses a conditional statement as an equivalent disjunction by negating the antecedent and leaving the 
consequent unchanged


$$p \to q \equiv \neg p \lor q$$ 
$$p \to \neg q \equiv \neg p \lor \neg q$$

## Associative law
### Layman's terms
An expression can have its parenthesis rearranged if the meaning of the expression doesn't change
### Formal description
States that the grouping of operands joined by the same logical operator does not affect the value of the expression


$$ (p \lor q) \lor r \equiv p \lor (q \lor r)$$ 
$$ (p \land q) \land r \equiv p \land (q \land r)$$

## Distributive law
### Layman's terms
Allows one part of an expression to be distributed across another expression, producing an equivalent expanded form. 
Since logical equivalence ($\equiv$) is symmetric, both identities can be applied in either direction to expand or 
reduce an expression.

### Formal description
States that one logical operator may be distributed over another to produce an equivalent expression. The law allows 
expressions to be expanded or factored while preserving logical equivalence

$$p \lor (q \land r) \equiv (p \lor q) \land (p \lor r)$$
$$p \land (q \lor r) \equiv (p \land q) \lor (p \land r)$$

In algebra, the pattern is familiar, where logical AND $$\land$$ plays the same role as multiplication $$\times$$ 
and logical OR $$\lor$$ plays the same role as addition $$+$$ 
which makes the pattern $$a(b + c) = ab + ac$$

## Commutative law
### Layman's terms
The order of the variables won't matter, as long as the meaning of the expression isn't changed
### Formal description
States that the order of operands joined by the same logical operator does not affect the value of the expression


$$p \lor q \equiv q \lor p$$
$$p \land q \equiv q \land p$$

## Absorption law
### Layman's terms
If an expression already has a general requirement, adding a more specific expression which is dependent on the first
requirement becomes redundant, which allows the added expression to be absorbed
### Formal description
States that combining a proposition with a compound expression containing the same proposition results in the original 
proposition, making the additional expression redundant


$$p \lor (p \land q) \equiv p$$
$$p \land (p \lor q) \equiv p$$

## Negation law
### Layman's terms 
A proposition together with its opposite always has a known truth value
### Formal description
States that every proposition is either true or false, so a proposition combined with its negation always evaluates to 
either a tautology or a contradiction


$$p \lor \neg p \equiv T $$
$$p \land \neg p \equiv F $$

## Double negation law
### Layman's terms
Two negatives become a positive
### Formal description
States that negating a proposition twice yields a logically equivalent proposition


$$\neg(\neg p) \equiv p$$

## Idempotent law
### Layman's terms
Applying an operation multiple times yields the same result as applying it once
### Formal description
States that repeatedly applying the same logical operator to identical operands does not change the value of the 
expression


$$p \lor p \equiv p$$
$$p \land p \equiv p$$

## Domination law
### Layman's terms
Combining a proposition with a dominant value (true or false) always results in the dominant value
overriding the proposition
### Formal description
States that combining a proposition with the dominant truth value for a logical operator always produces that dominant 
truth value


$$p \lor T \equiv T$$
$$p \land F \equiv F$$

## Identity law
### Layman's terms
Combining a proposition with an identity element (true or false) leaves the proposition unchanged
### Formal description
States that combining a proposition with the identity element of a logical operator leaves the proposition unchanged


$$p \land T \equiv p$$
$$p \lor F \equiv p$$
