using System.Windows.Forms;

namespace CRMKurs.CustomTools
{
    class ListViewCompare : ListView
    {
        private ColumnHeader SortingColumn = null;
        protected override void OnColumnClick(ColumnClickEventArgs e)
        {
            base.OnColumnClick(e);
            var new_sorting_column = Columns[e.Column];
            SortOrder sort_order;
            if (SortingColumn == null)
            {
                sort_order = SortOrder.Ascending;
            }
            else
            {
                if (new_sorting_column == SortingColumn)
                {
                    if (SortingColumn.Text.StartsWith("> "))
                    {
                        sort_order = SortOrder.Descending;
                    }
                    else
                    {
                        sort_order = SortOrder.Ascending;
                    }
                }
                else
                {
                    sort_order = SortOrder.Ascending;
                }
                SortingColumn.Text = SortingColumn.Text.Substring(2);
            }
            SortingColumn = new_sorting_column;
            if (sort_order == SortOrder.Ascending)
            {
                SortingColumn.Text = "> " + SortingColumn.Text;
            }
            else
            {
                SortingColumn.Text = "< " + SortingColumn.Text;
            }
            ListViewItemSorter =
                new ListViewComparer(e.Column, sort_order);
            Sort();
        }
    }
}
