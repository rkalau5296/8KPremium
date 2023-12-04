namespace _8KPremium
{
    internal class ColumnExcel
    {
        public int TitleToNumber(string columnTitle)
        {
            int columnNumber = 0;
            for (int i = 0; i < columnTitle.Length; i++)
            {
                columnNumber = columnNumber * 26 + columnTitle[i] - 'A' + 1;
            }
            return columnNumber;
        }
    }
}
