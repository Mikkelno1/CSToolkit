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
    public static bool ConditionalConverse(bool p, bool q)
    {
        return !(q && !p);
    }

    //the contrapositive of a conditional statement, if p -> q, then the contrapositive is q -> !p
    public static bool ConditionalContrapositive(bool p, bool q)
    {
        return q || !p;
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

   

}