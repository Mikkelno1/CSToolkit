namespace CSToolKit;

public class BooleanLogic
{
    #region Propositional variables

    //p and q are frequently used as variables, but may also include r, s, t, u etc

    #endregion
    
    //not p
    public static bool Negation(bool p)
    {
        return !p;
    }
    
    //both p and q true, && operator
    public static bool Conjunction(bool p, bool q)
    {
        return p && q;
    }
    
    //inclusive or - one must be true or both not false
    public static bool DisjunctionInclusive(bool p, bool q)
    {
        return p || q;
    }
    
    //exclusive or - either p or q true
    public static bool DisjunctionExclusive(bool p, bool q)
    {
        return (p && !q) || (!p && q);
    }

    //if p, then q
    public static bool Conditional(bool p, bool q)
    {
        return !p || q;
    }

    //the converse of a conditional statement, if p -> q, then the converse is q -> p
    //logically equivalent to the Conditional() proof
    public static bool ConditionalConverse(bool p, bool q)
    {
        return !q || p;
    }

    //the contrapositive of a conditional statement, if p -> q, then the contrapositive is !q -> !p
    //logically equivalent to Conditional()
    public static bool ConditionalContrapositive(bool p, bool q)
    {
        return !p || q;
    }

    //p and only if q
    public static bool Biconditional(bool p, bool q)
    {
        return (p && q) || (!p && !q);
    }

    //a tautology is always true
    public static bool Tautology(bool p)
    {
        return p || !p;
    }

    //a contradiction is always false
    public static bool Contradiction(bool p)
    {
        return p && !p;
    }

    //a universal quantifier is true only if the predicate is true for every value of x in the domain
    //returns true if every integer in the array is even
    public static bool UniversalQuantifier(int[] numberArray)
    {
        bool all = true;
        for (var i = 0; i < numberArray.Length; i++)
        {
            if (numberArray[i] % 2 != 0)
            {
                all = false;
                break;
            }
        }

        return all;
    }
    
    //an existential quantifier is true if the predicate is true for at least one value of x in the domain
    //returns true if at least one integer in the array is odd
    public static bool ExistentialQuantifier(int[] numberArray)
    {
        bool all = false;
        for (var i = 0; i < numberArray.Length; i++)
        {
            if (numberArray[i] % 2 != 0)
            {
                all = true;
                break;
            }
        }

        return all;
    }
    
   

   

}