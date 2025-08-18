namespace PaginationHelper; 

public class Program
{
    static void Main(string[] args)
    {
        IList<int> collection = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 };
        PagnationHelper<int> helper = new PagnationHelper<int>(collection, 10);
        var indeitemCount = helper.ItemCount;
        var pageCount = helper.PageCount;
        var pageItemCount = helper.PageItemCount(2);
        var pageIndex = helper.PageIndex(24);
    }

    public class PagnationHelper<T>
    {
        IList<T> _collection;
        int _itemsPerPage;
        /// <summary>
        /// Constructor, takes in a list of items and the number of items that fit within a single page
        /// </summary>
        /// <param name="collection">A list of items</param>
        /// <param name="itemsPerPage">The number of items that fit within a single page</param>
        public PagnationHelper(IList<T> collection, int itemsPerPage)
        {
            _collection = collection;
            _itemsPerPage = itemsPerPage;
        }

        /// <summary>
        /// The number of items within the collection
        /// </summary>
        public int ItemCount
        {
            get
            {
                return _collection.Count;
            }
        }

        /// <summary>
        /// The number of pages
        /// </summary>
        public int PageCount
        {
            get
            {
                var num = _collection.Count() / _itemsPerPage;
                var remaining = _collection.Count() % _itemsPerPage;
                return remaining > 0 ? num + 1 : num;

                //Best Answer 
                //return (collection.Count - 1) / itemsPerPage + 1;
            }
        }

        /// <summary>
        /// Returns the number of items in the page at the given page index 
        /// </summary>
        /// <param name="pageIndex">The zero-based page index to get the number of items for</param>
        /// <returns>The number of items on the specified page or -1 for pageIndex values that are out of range</returns>
        public int PageItemCount(int pageIndex)
        {
            int fullPages = _collection.Count / _itemsPerPage;

            if (pageIndex > fullPages || pageIndex < 0)
                return -1;

            return pageIndex < fullPages ? _itemsPerPage : (_collection.Count % _itemsPerPage == 0 ? -1 : _collection.Count % _itemsPerPage);

        }

        /// <summary>
        /// Returns the page index of the page containing the item at the given item index.
        /// </summary>
        /// <param name="itemIndex">The zero-based index of the item to get the pageIndex for</param>
        /// <returns>The zero-based page index of the page containing the item at the given item index or -1 if the item index is out of range</returns>
        public int PageIndex(int itemIndex)
        {
            if (itemIndex < 0 || itemIndex >= _collection.Count) return -1;

            return (itemIndex / _itemsPerPage);
        }
    }
}