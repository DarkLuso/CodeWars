using System;
using System.Collections.Generic;

public class PagnationHelper<T>
{
    public int ItemsPerPage { get; private set; }
    public int ItemCount { get; private set; }
    public int PageCount { get; private set; }

    public PagnationHelper(IList<T> c, int i)
    {
        ItemsPerPage = i;
        ItemCount = c.Count;
        PageCount = Convert.ToInt32(Math.Ceiling((double)ItemCount / i));
    }

    public int PageItemCount(int pageIndex) =>
      pageIndex < 0 || pageIndex >= PageCount ? -1 :
      pageIndex + 1 != PageCount || PageCount % ItemsPerPage == 0 ? ItemsPerPage :
      ItemCount % ItemsPerPage;

    public int PageIndex(int itemIndex) =>
      itemIndex < 0 || itemIndex + 1 > ItemCount ? -1 :
      Convert.ToInt32(Math.Floor((double)itemIndex / ItemsPerPage));
}