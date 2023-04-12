class Solution
{
	// get all combinations of symbols in str:
	private void Permute(string str, int l, int r)
	{
		if(l == r)
		{
			result.Add(str);
			return;
		}

		for (int i = l; i <= r; i++)
		{
			str = Swap(str, l, i);
			Permute(str, l + 1, r);
		}
	}

	private string Swap(string str, int l, int r)
	{
		var ns = str.ToCharArray();

		var tmp = ns[l];
		ns[l] = ns[r];
		ns[r] = tmp;

		return new String(ns);

	}
}
