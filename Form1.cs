namespace NumsToList
{
	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
		}

		private int[] GetNumbers(string text)
		{
			return text.Split("\r\n")
				.Select(x => x.Trim())
				.Where(x => Int32.TryParse(x, out _))
				.Select(x => Int32.Parse(x))
				.Distinct()
				.OrderBy(x => x)
				.ToArray();
		}

		private string NumbersToList(int[] vals)
		{
			string strList = String.Join(",", vals);

			return $"({strList})";
		}

		private void btnNumbersToList_Click(object sender, EventArgs e)
		{
			string text = Clipboard.GetText();
			int[] numbers = GetNumbers(text);

			if (numbers.Length > 0)
			{
				string strList = NumbersToList(numbers);
				tbOutput.Text = strList;
				Clipboard.SetText(strList);
			}
			else
			{
				tbOutput.Text = "No numbers found on clipboard. Clipboard unmodified.";
			}
		}
	}
}