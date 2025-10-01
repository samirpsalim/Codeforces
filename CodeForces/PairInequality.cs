class PairInequality{

long PairsSatisfyingInequality(int n, List<long> a)
{
    List<int> positions = new(n);
    List<long> Values = new(n);

    for (int i = 0; i < n; ++i)
    {
        if (a[i] < i + 1)
        {
            positions.Add(i + 1);
            Values.Add(a[i]);
        }
    }
    Values.Sort();
    return PairCountFromDictionary(positions, Values);
}

long PairCountFromDictionary(List<int> positions, List<long> values)
{
    long count = 0;
    int i = 0, j = 0;
    while (i < positions.Count && j < values.Count)
    {
        while (j < values.Count && values[j] <= positions[i])
        {
            j += 1;
        }
        if (j == values.Count - 1 && values[j] <= positions[i])
            j += 1;
        else
            count += values.Count - j;
        i++;        
    }
    return count;
}
}