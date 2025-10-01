class CF2120A
{
    public string CanSquare(int l1, int b1, int l2, int b2, int l3, int b3)
    {
        if (l1 == l2 && l2 == l3 && b1 + b2 + b3 == l1) return "YES";

        if (l1 == l2 + l3 && b2 == b3 && b1 + b2 == l1) return "YES";

        if (b1 == b2 && b2 == b3 && l1 + l2 + l3 == b1) return "YES";

        if (b1 == b2 + b3 && l2 == l3 && l1 + l2 == b1) return "YES";

        return "NO";
    }
}